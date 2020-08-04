/*
 * Created by Ranorex
 * User: somas
 * Date: 04-08-2020
 * Time: 07:37
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

namespace TCOS_POC_DEMOAPP.Code_modules
{
    /// <summary>
    /// Description of ValidateListItems.
    /// </summary>
    [TestModule("A93298F2-1F90-4B0B-9334-47FD316840E5", ModuleType.UserCode, 1)]
    public class ValidateListItems : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
 
 string _expectedListItems = "";
 [TestVariable("b199bfa9-e0ee-4ba6-8f31-9529dfffa093")]
 public string expectedListItems
 {
 	get { return _expectedListItems; }
 	set { _expectedListItems = value; }
 }
 
        
        public ValidateListItems()
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
            
                    TCOS_POC_DEMOAPPRepository repo = TCOS_POC_DEMOAPPRepository.Instance;
		
					Ranorex.List HDComboBox = repo.RxMainFrame.RxTabUIElements.LstTestBox;
		            
		            HDComboBox.Click(Location.Center);
		
		            IList<Ranorex.ListItem> MyListItems = HDComboBox.FindDescendants<Ranorex.ListItem>();
		            
					string[] actualStrArrItems;
					
					actualStrArrItems = new string[MyListItems.Count];
		
		            foreach (Ranorex.ListItem ThisListItem in MyListItems)
		            {
		                actualStrArrItems[ThisListItem.Index]=ThisListItem.Text.ToString();
		                
		            }
				
		            Validate.AreEqual(string.Join(",", actualStrArrItems),expectedListItems);
        }
    }
}
