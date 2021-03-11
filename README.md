# Credit Card Transaction using Face Recognition

### Debit Card/Credit Card Transaction by means of face as a password to perform authentication in an ATM system which is simulated to act like an actual ATM.

#

## **Some Info**

* This application proposes a technique by which the features extracted from the image clicked while performing any transaction will be compared to the features of a user's face from the training dataset of the respective user.
* This new method is developed to avoid fraudulent during online as well as offline transactions.

#

## **Technologies Used**

* C#
* Emgu CV (2.2.1)

#

## **Installation**

* Open Visual Studio and select "Open a project or a solution".
* Browse to the directory where the repository is cloned and then select folder V2.
* Then navigate to ATMclassLibrary folder and then select **ATMclassLibrary.sln**.
* Start Debug to generate **ATMclassLibrary.dll** which is used for ATMClienteApp.
* Close Project and "Open a project or a solution".
* Then navigate to ATMClienteApp folder and then select **ATMClienteApp.sln**.
* Check if ATMclassLibrary under References is loaded or not.
* Also Check " Emgu. CV "," Emgu.CV.UI " and " Emgu.Util " are loaded in References or not.
* Start Debug and ATM application will run providing similar experience to an actual ATM with either login using four digit PIN or using his/her face for login.

#

## **Usage**

### **Login Page**

* Before performing any transaction, the user must enter his or her name on an input screen as we want test the system.
* In real ATM the debit card/ credit card inserted will perform this step.
* Since the operation of this input screen should simulate the normal operation of an ATM, the PIN should not appear on the screen.
* If the user is selecting "Recognise Face" then Face Recogniser form will open which will display Name of the Person detected as well as no. of persons detected after the user has granted permission to open camera and start detection.
* If the user is selecting "Add Face Data" option when his/her face is not registered then user must first click "Detect and Recognise" to start camera and then select "Add Face Data" to save his/her image for further use after the system shows that the face is detected.
* On successful validation by PIN or by Face, the ATM Main Page will be opened to perform transactions as per requirement of user.
* In addition to the message which appears after every unsuccessful attempt, if after three tries the PIN matching the name has not been macthed, the application should display a message requesting the user to try using the ATM again later.
* The names and PINs of users must be validated using data contained in the Customers.txt text file having the following structure:

> name (String)

> PIN (String – 4 characters)

#

### **Main ATM Page**

* Once access has been authorized, the main form of the application should allow the user to carry out any one of the following transactions :

> Balance Enquiry

> Cash Withdrawal

> Mini Statement

* Below is the structure of the Accounts.txt sequential file in which account balances are stored in following format : 

> Account type (1 character) 

> Pin (string – 4 characters) 

> Account number (string – 12 characters) 

> Account balance (single Decimal)

#

### **Withdrawal Process**

* For a withdrawal, the user must enter the amount and select the account type to be debited.
* The maximum withdrawal in current account is RS 50,000 per day and the maximum withdrawal in savings account is RS 25,000 per day.
* The maximum amount which can be withdrawed in a single transaction is RS 20,000 for savings account and RS 25,000 for current account.
* There is a daily maximum withdrawal limit limited to 4 transactions for a single account per day.
* The ATM accepts only transactions for which the amount entered is a multiple of RS 100.

#

### **General Rules**

* **Face Recogniser** : The timer is set to 5 seconds before the user is redirected to Main ATM Transaction Page to test various situations. If the user's face is not matched or there are no real persons in frame then the ATM stops the current process after 20 seconds(timer can be increased or decreased as per physical availability in real ATM) and redirects users to startup page. 

* **Check Account Balance** : The application must check the account balance before doing a transaction. Any transaction that would result in a negative balance must be rejected.

* **Update Account Balance** : The balance of the account affected by a transaction should be updated and displayed after each transaction.

* **Print Mini Statement** : The application must print the mini statement slip providing details of last 10 transactions of the user in the prescribed format for 80mm thermal printer page.

* **Multi Transaction** : The user should be able to do as many transactions as he or she would like to do before leaving the ATM.

* **No Money** : A warning message should inform the user that the ATM can no longer carry out withdrawals when there is no money available in the ATM. When a withdrawal transaction event occurs for an amount greater than the balance remaining in the ATM, the ATM should advise the user they can chnrge the transaction amount to the amount still available in the user’s account.

* **Daily Refill** : When the application is initiated at start of each day, the bank’s balance money is automatically refilled with up to RS 15,00,000 for a maximum of RS 40,00,000.

* **Out of Services Page** : If the ATM is in Out of Services mode due to various types of issues then it can be brought back to working state after logging in as an Administrator.

#

### **System Administrator Page**

* The system administrator, as any other user, must enter his or her name and PIN on the same input screen.
* Currently the system administrator can only login by using four digit PIN, the face option for Administrator is not used for security concerns.
* The system administrator should perform only system transactions (he or she has no personal account).
* Once access has been authorized, a special menu is displayed.
* This menu offers the following options:

> Refill the ATM with money

> Take the ATM out of service 

> Print the accounts report

> Display the accounts report

> Turn Off the System if the ATM is not available for 24*7 use

* The system administrator puts in more money in batches of RS 15,00,000.
* There should not be more than RS 40,00,000 available in the ATM at any moment in time.

#