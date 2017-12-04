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

namespace HelloWorldIOS
{
    [Register ("detailsViewController")]
    partial class detailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDetailsNew { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelDetailsNew != null) {
                labelDetailsNew.Dispose ();
                labelDetailsNew = null;
            }
        }
    }
}