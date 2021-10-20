﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace PaintTest
{
    public partial class CloseAUT
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void SaveFile()
        {
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;
        	repo.Paint.ButtonSave.Click();
        	repo.SaveAs.Self.EnsureVisible();
            Keyboard.Press(@"%TEMP%Test picture");
        	repo.SaveAs.ButtonSave.Click();
        	try {
            	repo.ConfirmSaveAs.ButtonYes.Click();
//           		paintSession.findElementByName("Save").click();
//            	paintSession.findElementByName("Confirm Save As").findElement(By.name("Yes")).click();
        	}
        	catch (Exception e)
        	{}
        }
    }
}
