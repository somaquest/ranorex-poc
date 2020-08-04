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
    ///The Navigate_to_Object_identification_tab recording.
    /// </summary>
    [TestModule("da23f796-63bc-4a29-923a-27fe69c90561", ModuleType.Recording, 1)]
    public partial class Navigate_to_Object_identification_tab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TCOS_POC_DEMOAPPRepository repository.
        /// </summary>
        public static TCOS_POC_DEMOAPPRepository repo = TCOS_POC_DEMOAPPRepository.Instance;

        static Navigate_to_Object_identification_tab instance = new Navigate_to_Object_identification_tab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_to_Object_identification_tab()
        {
            ObjectIdentificationHeader = "Object identification test area";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_to_Object_identification_tab Instance
        {
            get { return instance; }
        }

#region Variables

        string _ObjectIdentificationHeader;

        /// <summary>
        /// Gets or sets the value of variable ObjectIdentificationHeader.
        /// </summary>
        [TestVariable("76c1ce29-1c46-4b75-896f-974ac8fadbc1")]
        public string ObjectIdentificationHeader
        {
            get { return _ObjectIdentificationHeader; }
            set { _ObjectIdentificationHeader = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.ObjectIdentification' at 35;6.", repo.RxMainFrame.ObjectIdentificationInfo, new RecordItemIndex(0));
            repo.RxMainFrame.ObjectIdentification.Click("35;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'RxMainFrame.ObjectIdentificationheader'.", repo.RxMainFrame.ObjectIdentificationheaderInfo, new RecordItemIndex(1));
            Validate.Exists(repo.RxMainFrame.ObjectIdentificationheaderInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ObjectIdentificationHeader) on item 'RxMainFrame.ObjectIdentificationheader'.", repo.RxMainFrame.ObjectIdentificationheaderInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.RxMainFrame.ObjectIdentificationheaderInfo, "Text", ObjectIdentificationHeader);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
