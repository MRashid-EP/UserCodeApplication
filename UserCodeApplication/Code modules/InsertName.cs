/*
 * Created by Ranorex
 * User: MRashid
 * Date: 8/6/2020
 * Time: 2:21 PM
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
    /// Description of InsertName.
    /// </summary>
    [TestModule("66B0B93E-8D33-4F72-A671-E9A3A98A8BC2", ModuleType.UserCode, 1)]
    public class InsertName : ITestModule
    {
    	
    	//Define a module variable
    	
    	string _varName = "";
    	[TestVariable("eb38a230-290f-4971-8e0b-4264218be7ef")]
    	public string varName
    	{
    		get { return _varName; }
    		set { _varName = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertName()
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
            
            UserCodeApplicationRepository myRepo = new UserCodeApplicationRepository();
            
            myRepo.ApplicationUnderTest.IntroductionPane.TxtFieldName.TextValue = varName;
            
            Report.Log(ReportLevel.Info, "Inserted '" + varName + "' into the text filed");
            Delay.Seconds(3);
        }
    }
}
