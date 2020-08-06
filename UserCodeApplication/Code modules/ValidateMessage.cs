/*
 * Created by Ranorex
 * User: MRashid
 * Date: 8/6/2020
 * Time: 3:21 PM
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
    /// Description of ValidateMessage.
    /// </summary>
    [TestModule("2828803B-1B0A-4442-8BDC-3CF8E6D1426E", ModuleType.UserCode, 1)]
    public class ValidateMessage : ITestModule
    {
    	
    	
    	
    	//Definition of reference value
    	string _varMatchName = "";
    	[TestVariable("30c33001-9206-4e9e-8d47-5cbac6f82a20")]
    	public string varMatchName
    	{
    		get { return _varMatchName; }
    		set { _varMatchName = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateMessage()
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
            var myRepo = UserCodeApplicationRepository.Instance;
            var lblWelcomeMsg = myRepo.ApplicationUnderTest.IntroductionPane.LblWelcomeMsg;

            //User code based validation
            
            if(Validate.Equals(myRepo.ApplicationUnderTest.IntroductionPane.LblWelcomeMsg.TextValue, "Welcome, " + varMatchName + "!")){
            	Report.Success("Validation", "Welcome message correctly changed to  'welcome, " + varMatchName + "!'");
            } else {
            	Report.Warn("Validation", "Wrong welcome messge change!");
            }

        }
    }
}
