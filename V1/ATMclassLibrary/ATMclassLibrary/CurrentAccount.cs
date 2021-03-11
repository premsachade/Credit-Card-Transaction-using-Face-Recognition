using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMclassLibrary
{
    public class CurrentAccount : CollectionBase
    {
        public void AddCurrent(Current Chck)
        {
            List.Add(Chck);
        }
        public Current this[int i]
        {
            get
            {
                return (Current)List[i];
            }
            set
            {
                List[i] = value;
            }
        }
    }
}
