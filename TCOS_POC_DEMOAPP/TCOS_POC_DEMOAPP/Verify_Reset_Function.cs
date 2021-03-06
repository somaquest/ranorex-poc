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

namespace TCOS_POC_DEMOAPP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verify_Reset_Function recording.
    /// </summary>
    [TestModule("58c6ebec-967d-4f36-b9ba-898bea9d8390", ModuleType.Recording, 1)]
    public partial class Verify_Reset_Function : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TCOS_POC_DEMOAPPRepository repository.
        /// </summary>
        public static TCOS_POC_DEMOAPPRepository repo = TCOS_POC_DEMOAPPRepository.Instance;

        static Verify_Reset_Function instance = new Verify_Reset_Function();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Reset_Function()
        {
            WelcomeTxtDefault = "Welcome!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Reset_Function Instance
        {
            get { return instance; }
        }

#region Variables

        string _WelcomeTxtDefault;

        /// <summary>
        /// Gets or sets the value of variable WelcomeTxtDefault.
        /// </summary>
        [TestVariable("6e37282b-845a-4967-b2ad-353cd79b90d2")]
        public string WelcomeTxtDefault
        {
            get { return _WelcomeTxtDefault; }
            set { _WelcomeTxtDefault = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.Reset' at 25;9.", repo.RxMainFrame.RxTabIntroduction.ResetInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabIntroduction.Reset.Click("25;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$WelcomeTxtDefault) on item 'RxMainFrame.RxTabIntroduction.LblWelcomeMessage'.", repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, "Text", WelcomeTxtDefault);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
