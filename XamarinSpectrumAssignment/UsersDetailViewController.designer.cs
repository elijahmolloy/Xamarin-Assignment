// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinSpectrumAssignment
{
    [Register ("UsersDetailViewController")]
    partial class UsersDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel userDetail_dateOfBirth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel userDetail_firstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel userDetail_lastName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (userDetail_dateOfBirth != null) {
                userDetail_dateOfBirth.Dispose ();
                userDetail_dateOfBirth = null;
            }

            if (userDetail_firstName != null) {
                userDetail_firstName.Dispose ();
                userDetail_firstName = null;
            }

            if (userDetail_lastName != null) {
                userDetail_lastName.Dispose ();
                userDetail_lastName = null;
            }
        }
    }
}