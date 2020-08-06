/*
 * Created by Ranorex
 * User: MRashid
 * Date: 8/6/2020
 * Time: 2:52 PM
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
    /// Description of BtnSubmit.
    /// </summary>
    [TestModule("784D9B71-2034-4043-9D82-99FC0BACFB3A", ModuleType.UserCode, 1)]
    public class BtnSubmit : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BtnSubmit()
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
            
            var myRepo = new UserCodeApplicationRepository();
            
            var ButtonSubmit = myRepo.ApplicationUnderTest.IntroductionPane.BtnSubmit;
            
            ButtonSubmit.Click();
            
            Report.Log(ReportLevel.Info, "Submit button has been clicked");
            
        }
    }
}
