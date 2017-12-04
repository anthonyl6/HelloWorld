using Foundation;
using System;
using UIKit;

namespace HelloWorldIOS
{
    public partial class detailsViewController : UIViewController
    {

        public float num1 = 10f;
        public float num2 = 20f;

        public int option = 1;
        public float result = 30f;


        public detailsViewController(IntPtr handle) : base(handle)
        {
                
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            switch(option) {
                case 1: 
                    labelDetailsNew.Text = num1.ToString() + " + " + num2.ToString() + " = " + result.ToString();
                    break;
                case 2: 
                    labelDetailsNew.Text = num1.ToString() + " - " + num2.ToString() + " = " + result.ToString();
                    break;
                case 3:
                    labelDetailsNew.Text = num1.ToString() + " * " + num2.ToString() + " = " + result.ToString();
                    break;
                case 4:
                    labelDetailsNew.Text = num1.ToString() + " / " + num2.ToString() + " = " + result.ToString();
                    break;
            }

        }
    }
}