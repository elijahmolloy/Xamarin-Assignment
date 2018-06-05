using Foundation;
using System;
using UIKit;

namespace XamarinSpectrumAssignment
{
    public partial class UsersDetailViewController : UITableViewController
    {
        User currentUser;

        public UsersDetailViewController (IntPtr handle) : base (handle)
        {
            
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            userDetail_firstName.Text = currentUser.firstName;
            userDetail_lastName.Text = currentUser.lastName;
            userDetail_dateOfBirth.Text = currentUser.dateOfBirth.ToShortDateString();
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }


        public void SetCurrentUser(User user) {
            currentUser = user;
        }
    }
}