/*
 * Created by Ranorex
 * User: MRashid
 * Date: 8/6/2020
 * Time: 3:01 PM
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

namespace UserCodeApplication.Code_modules
{
    /// <summary>
    /// Description of ButtonReset.
    /// </summary>
    [TestModule("6248CA83-BD2F-4B6C-917A-7295BAA3A6F5", ModuleType.UserCode, 1)]
    public class ButtonReset : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ButtonReset()
        {
            // Do not delete - a parameterless constructor is required!
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
            
            var repo = UserCodeApplicationRepository.Instance;
            var btnReset = repo.ApplicationUnderTest.IntroductionPane.BtnReset;
            
            btnReset.Click();
        }
    }
}
