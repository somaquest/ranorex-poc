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
    ///The Navigate_to_Test_database_tab recording.
    /// </summary>
    [TestModule("6bc4a34c-9acf-4fd4-93ef-a6c298a2cbad", ModuleType.Recording, 1)]
    public partial class Navigate_to_Test_database_tab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TCOS_POC_DEMOAPPRepository repository.
        /// </summary>
        public static TCOS_POC_DEMOAPPRepository repo = TCOS_POC_DEMOAPPRepository.Instance;

        static Navigate_to_Test_database_tab instance = new Navigate_to_Test_database_tab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_to_Test_database_tab()
        {
            TestDatabaseHeader = "Test database";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_to_Test_database_tab Instance
        {
            get { return instance; }
        }

#region Variables

        string _TestDatabaseHeader;

        /// <summary>
        /// Gets or sets the value of variable TestDatabaseHeader.
        /// </summary>
        [TestVariable("cf0cc489-888d-41e5-b439-004fba79900e")]
        public string TestDatabaseHeader
        {
            get { return _TestDatabaseHeader; }
            set { _TestDatabaseHeader = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at 45;7.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(0));
            repo.RxMainFrame.TestDatabase.Click("45;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RxMainFrame.RxTabStandard.TestdatabaseHeader'.", repo.RxMainFrame.RxTabStandard.TestdatabaseHeaderInfo, new RecordItemIndex(1));
            Validate.Exists(repo.RxMainFrame.RxTabStandard.TestdatabaseHeaderInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$TestDatabaseHeader) on item 'RxMainFrame.RxTabStandard.TestdatabaseHeader'.", repo.RxMainFrame.RxTabStandard.TestdatabaseHeaderInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.RxMainFrame.RxTabStandard.TestdatabaseHeaderInfo, "Text", TestDatabaseHeader);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
