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

namespace UserCodeApplication.Recording_modules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BtnReset recording.
    /// </summary>
    [TestModule("63e72d99-3f12-4191-8fdf-bf34f2f17c2e", ModuleType.Recording, 1)]
    public partial class BtnReset : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::UserCodeApplication.UserCodeApplicationRepository repository.
        /// </summary>
        public static global::UserCodeApplication.UserCodeApplicationRepository repo = global::UserCodeApplication.UserCodeApplicationRepository.Instance;

        static BtnReset instance = new BtnReset();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BtnReset()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BtnReset Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IntroductionPane.BtnReset' at 17;7.", repo.ApplicationUnderTest.IntroductionPane.BtnResetInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.IntroductionPane.BtnReset.Click("17;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
