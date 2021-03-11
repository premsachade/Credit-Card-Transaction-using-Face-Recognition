using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using ATMclassLibrary;

namespace ATMClienteApp
{
    public partial class FrmRecognition : Form
    {
        FrmStartup MYLOG = new FrmStartup();
        atmManager atm = new atmManager();
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.7d, 0.7d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t, mode;
        string name, names, uname;
        public FrmRecognition(String username, int m)
        {
            atm.loadBank();
            atm.loadCustomer();
            bool loginconfirm = atm.validateUserF(username);
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;
                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
                uname = username;
                mode = m;
                label6.Text = username;
                if (mode == 2)
                {
                    label4.Hide();
                    label5.Hide();
                }
                if (mode == 1)
                {
                    imageBox1.Hide();
                    label1.Hide();
                    label6.Hide();
                    label7.Hide();
                    btAddFace.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Trained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btAddFace_Click(object sender, EventArgs e)
        {
            try
            {
                ContTrain = ContTrain + 1;
                gray = grabber.QueryGrayFrame().Resize(440, 330, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(label6.Text);
                imageBox1.Image = TrainedFace;
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }
                MessageBox.Show(label6.Text + "'s face detected and added ", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Idle -= FrameGrabber;
                grabber.Dispose();
                currentFrame.Dispose();
                TrainedFace.Dispose();
                face.Dispose();
                result.Dispose();
                gray.Dispose();
                this.Close();
                MYLOG.Show();
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btDetect_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
            btDetect.Enabled = false;
            timer1.Enabled = true;
            timer1.Interval = (5 * 1000);
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Enabled = true;
            timer2.Interval = (20 * 1000);
            timer2.Start();
            timer2.Tick += new EventHandler(timer2_Tick);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (uname == name)
            {
                Application.Idle -= FrameGrabber;
                grabber.Dispose();
                currentFrame.Dispose();
                face.Dispose();
                result.Dispose();
                gray.Dispose();
                this.Close();
                FrmAtmMain frmMain = new FrmAtmMain(mode, MYLOG, atm);
                frmMain.Show();
                frmMain.Activate();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (uname != name)
            {
                Application.Idle -= FrameGrabber;
                grabber.Dispose();
                currentFrame.Dispose();
                face.Dispose();
                gray.Dispose();
                this.Close();
                MYLOG.Show();
            }
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            NamePersons.Add("");
            currentFrame = grabber.QueryFrame().Resize(440, 330, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            gray = currentFrame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 3);
                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, ref termCrit);
                    name = recognizer.Recognize(result);
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 18, f.rect.Y - 40), new Bgr(Color.Blue));
                }
                NamePersons[t - 1] = name;
                NamePersons.Add("");
                label3.Text = facesDetected[0].Length.ToString();
            }
            t = 0;
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn];
            }
            imageBoxFrameGrabber.Image = currentFrame;
            label4.Text = names;
            names = "";
            NamePersons.Clear();
        }
    }
}