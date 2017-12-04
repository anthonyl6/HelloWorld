// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloWorldIOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonAdd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDivide { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonMultiply { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSubtract { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelAnswer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt1stNum { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txt2ndNum { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonAdd != null) {
                buttonAdd.Dispose ();
                buttonAdd = null;
            }

            if (buttonDivide != null) {
                buttonDivide.Dispose ();
                buttonDivide = null;
            }

            if (buttonMultiply != null) {
                buttonMultiply.Dispose ();
                buttonMultiply = null;
            }

            if (buttonSubtract != null) {
                buttonSubtract.Dispose ();
                buttonSubtract = null;
            }

            if (labelAnswer != null) {
                labelAnswer.Dispose ();
                labelAnswer = null;
            }

            if (txt1stNum != null) {
                txt1stNum.Dispose ();
                txt1stNum = null;
            }

            if (txt2ndNum != null) {
                txt2ndNum.Dispose ();
                txt2ndNum = null;
            }
        }
    }
}