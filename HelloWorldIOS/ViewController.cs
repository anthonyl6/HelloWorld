using System;

using UIKit;

namespace HelloWorldIOS
{
    public partial class ViewController : UIViewController
    {

        float num1;
        float num2;
        float result;
        int option;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.



            buttonAdd.TouchUpInside += ButtonAdd_TouchUpInside;
            buttonSubtract.TouchUpInside += ButtonSubtract_TouchUpInside;
            buttonMultiply.TouchUpInside += ButtonMultiply_TouchUpInside;
            buttonDivide.TouchUpInside += ButtonDivide_TouchUpInside;
        }

        void ButtonAdd_TouchUpInside(object sender, EventArgs e)
        {
			 num1 = float.Parse(txt1stNum.Text);
			 num2 = float.Parse(txt2ndNum.Text);

             result = num1 + num2;

            option = 1;

             labelAnswer.Text = result.ToString();
        }

        void ButtonSubtract_TouchUpInside(object sender, EventArgs e)
        {
			 num1 = float.Parse(txt1stNum.Text);
			 num2 = float.Parse(txt2ndNum.Text);

			 result = num1 - num2;

            option = 2;

			 labelAnswer.Text = result.ToString();
        }

        void ButtonMultiply_TouchUpInside(object sender, EventArgs e)
        {
			 num1 = float.Parse(txt1stNum.Text);
			 num2 = float.Parse(txt2ndNum.Text);

			 result = num1 * num2;

            option = 3;

			 labelAnswer.Text = result.ToString();   
        }

        void ButtonDivide_TouchUpInside(object sender, EventArgs e)
        {
			 num1 = float.Parse(txt1stNum.Text);
			 num2 = float.Parse(txt2ndNum.Text);
           
			 result = num1 / num2;

            option = 4;

			 labelAnswer.Text = result.ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var detailsViewController = segue.DestinationViewController as detailsViewController;

            detailsViewController.num1 = this.num1;
            detailsViewController.num2 = this.num2;
            detailsViewController.option = this.option;
            detailsViewController.result = this.result;
        }
    }
}
