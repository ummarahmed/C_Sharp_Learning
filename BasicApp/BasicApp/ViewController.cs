using System;

using AppKit;
using Foundation;

namespace BasicApp
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void pushButton(NSButton sender)
        {
            this.setText("Push Button Pressed");
        }

        partial void resetButton(NSButton sender)
        {
            this.setText("Reset has come");
        }

        private void setText(String text)
        {
            infoLabel.StringValue = text;
        }
    }
}
