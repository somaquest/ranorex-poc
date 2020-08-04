/*
 * Created by Ranorex
 * User: somas
 * Date: 02-08-2020
 * Time: 01:48
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

namespace Ranorex_Automation_Helpers.Modules
{
    /// <summary>
    /// Description of GetListBoxValues.
    /// </summary>
    [TestModule("C0B5BFE2-2E3F-45A7-A73A-973614223F9C", ModuleType.UserCode, 1)]
    public class GetListBoxValues : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GetListBoxValues()
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
        }
    }
}
