/*
 * Created by Ranorex
 * User: user
 * Date: 20.10.2021
 * Time: 12:35
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace PaintTest
{
    [TestModule("8D15B41F-35BA-4FE9-A952-ED1CAF87CA85", ModuleType.UserCode, 1)]
    public class Draw : ITestModule
    {
    	protected PaintTestRepository repo;
        public Draw(PaintTestRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
        
        public void drawSimpleFigure(int x1,int y1, int x2, int y2)
        {
        	repo.UntitledPaint.Canvas.MoveTo(x1+";"+(y1+100));
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            repo.UntitledPaint.Canvas.MoveTo(x2+";"+(y2+100));
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }
        
        public void drawCurve(int x1,int y1,int x2,int y2,int x3,int y3)
        {
        	repo.UntitledPaint.Canvas.MoveTo(x1+";"+(y1+100));
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            repo.UntitledPaint.Canvas.MoveTo(x2+";"+(y2+100));
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            repo.UntitledPaint.Canvas.MoveTo(x1+";"+(y1+100));
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            repo.UntitledPaint.Canvas.MoveTo(x3+";"+(y3+100));
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }
    }
}
