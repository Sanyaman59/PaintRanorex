﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PaintTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CatDrawing recording.
    /// </summary>
    [TestModule("58f5228c-3853-42d9-8256-7f4c644f1842", ModuleType.Recording, 1)]
    public partial class CatDrawing : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PaintTestRepository repository.
        /// </summary>
        public static PaintTestRepository repo = PaintTestRepository.Instance;

        static CatDrawing instance = new CatDrawing();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CatDrawing()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CatDrawing Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            DrawCat();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'UntitledPaint.Canvas' at 238;72.", repo.UntitledPaint.CanvasInfo, new RecordItemIndex(1));
            //repo.UntitledPaint.Canvas.MoveTo("238;72");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'UntitledPaint.Canvas' at 719;391.", repo.UntitledPaint.CanvasInfo, new RecordItemIndex(2));
            //repo.UntitledPaint.Canvas.MoveTo("719;391");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}