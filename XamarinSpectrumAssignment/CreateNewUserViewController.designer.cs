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
    [Register ("CreateNewUserViewController")]
    partial class CreateNewUserViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton createUserButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker dateOfBirthField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField firstNameField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField lastNameField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordField { get; set; }

        [Action ("CreateUserButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CreateUserButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (createUserButton != null) {
                createUserButton.Dispose ();
                createUserButton = null;
            }

            if (dateOfBirthField != null) {
                dateOfBirthField.Dispose ();
                dateOfBirthField = null;
            }

            if (firstNameField != null) {
                firstNameField.Dispose ();
                firstNameField = null;
            }

            if (lastNameField != null) {
                lastNameField.Dispose ();
                lastNameField = null;
            }

            if (passwordField != null) {
                passwordField.Dispose ();
                passwordField = null;
            }
        }
    }
}