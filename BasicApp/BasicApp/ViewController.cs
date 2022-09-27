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
            Console.WriteLine("Button Pushed");
        }

        partial void resetButton(NSButton sender)
        {
            Console.WriteLine("Reset Button pressed");
        }
    }
}
