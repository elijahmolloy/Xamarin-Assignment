using Foundation;
using System;
using UIKit;
using System.Collections.Generic;


namespace XamarinSpectrumAssignment
{
    public partial class UsersTableViewController : UITableViewController
    {
        // Users List that is displayed
        private List<User> UsersList;


        public UsersTableViewController (IntPtr handle) : base (handle)
        {

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UsersList = new List<User> 
            {
                new User {firstName = "Elijah", lastName = "Molloy", password = "donthackm3", dateOfBirth = new DateTime(1994, 8, 21)}
            };
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            // Update the List that is displayed on the Table View
            UpdateTableSource(UsersList);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }


        // To send the selected User's information to the UsersDetails Page
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "toUserDetail")
            {
                var navigationController = segue.DestinationViewController as UsersDetailViewController;

                if (navigationController != null)
                {
                    var source = TableView.Source as UsersTableSource;
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var item = source.GetItem(rowPath.Row);

                    navigationController.SetCurrentUser(item);
                }
            }
        }


        // Update List that is displayed in the table
        private void UpdateTableSource(List<User> usersList) 
        {
            TableView.Source = new UsersTableSource(usersList);
        }


        // To accept new users from the CreateNewUserViewController
        public void AddNewUserToTable(User newUser) {
            UsersList.Add(newUser);

            UpdateTableSource(UsersList);
        }
    }
}