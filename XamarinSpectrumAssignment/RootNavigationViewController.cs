using Foundation;
using System;
using UIKit;

namespace XamarinSpectrumAssignment
{
    public partial class RootNavigationViewController : UINavigationController
    {
        public RootNavigationViewController (IntPtr handle) : base (handle)
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
    }
}