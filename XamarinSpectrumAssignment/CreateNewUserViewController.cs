using Foundation;
using System;
using UIKit;

namespace XamarinSpectrumAssignment
{
    public partial class CreateNewUserViewController : UIViewController
    {
        private string firstName;
        private string lastName;
        private string password;
        private DateTime dateOfBirth;

        public User newUser;


        public CreateNewUserViewController (IntPtr handle) : base (handle)
        {

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }


        // When CreateUserButton is clicked
        partial void CreateUserButton_TouchUpInside(UIButton sender)
        {
            // Store all data from the view
            firstName = firstNameField.Text;
            lastName = lastNameField.Text;
            password = passwordField.Text;
            dateOfBirth = (System.DateTime) dateOfBirthField.Date;

            // Check the validity of the Password
            if (PasswordIsValid(password)) 
            {
                newUser = new User
                {
                    firstName = firstName,
                    lastName = lastName,
                    password = password,
                    dateOfBirth = dateOfBirth
                };

                var initialViewController = (UsersTableViewController) this.NavigationController.ViewControllers[this.NavigationController.ViewControllers.Length - 2];
                initialViewController.AddNewUserToTable(newUser);

                NavigationController.PopViewController(true);
            }
        }


        // Runs through the various requirements for the passsword string
        private bool PasswordIsValid(string password)
        {
            // Check for Length of Password
            if (!PasswordLengthIsValid(password)) {
                DisplayErrorMessage("Password is not the correct length. Please ensure the password is between 5 and 12 characters only.");

                return false;
            }

            char[] passwordArray = password.ToCharArray();

            if (!PasswordComplexityIsValid_1(passwordArray)) {
                DisplayErrorMessage("Password is not complex enough. Please ensure to user both characters and numbers.");

                return false;
            }

            if (!PasswordComplexityIsValid_2(password)) {
                DisplayErrorMessage("Password is not complex enough. Please ensure not to repeat any strings of length 2 or greater directly after one another.");
            }

            return true;
        }


        // Checks to ensure the password is between 5 and 12 characters
        private bool PasswordLengthIsValid(string password) 
        {
            if (password.Length >= 5 && password.Length <= 12) {
                return true;
            } else {
                return false;
            }
        }


        // Checks to ensure that the password contains letters and numbers
        private bool PasswordComplexityIsValid_1(char[] password)
        {
            bool containsLetter = false;
            bool containsNumber = false;

            foreach (char letter in password) {
                if (char.IsLetter(letter)) {
                    containsLetter = true;
                }

                if (char.IsNumber(letter)) {
                    containsNumber = true;
                }
            }

            if (containsLetter && containsNumber) {
                return true;
            } else {
                return false;
            }
        }


        // Checks to ensure that the password does not repeat substrings of lenth 2 or greater
        private bool PasswordComplexityIsValid_2(string password)
        {
            for (int i = 2; i <= password.Length / 2; i++)
            {
                for (int j = 0; j < password.Length - (i * 2) + 1; j++)
                {
                    string part_one = password.Substring(j, i);
                    string part_two = password.Substring(j + i, i);

                    if (part_one.Equals(part_two))
                    {                        
                        return false;
                    }
                }
            }

            return true;
        }


        // Diplay Error Message
        private void DisplayErrorMessage(string message) 
        {
            UIAlertView alert = new UIAlertView() {
                Title = "Invalid Password",
                Message = message
            };

            alert.AddButton("OK");
            alert.Show();
        }
    }
}