//#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEditor;
using UnityEngine;

namespace QFramework.TestApp {
    public class TestAppWindow : EditorWindow, IController
    {
        [MenuItem("TestApp/window")]
        public static void Open() {
            TestAppWindow app = GetWindow<TestAppWindow>();
            app.Show();
        }
        private ITestModel testModel;

        private void OnEnable()
        {
            testModel = this.GetModel<ITestModel>();
        }

        private void OnDisable()
        {
            testModel = null;
        }
        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                this.SendCommand<TestIncreaseCommand>();
            }
            GUILayout.Label(testModel.Count.Value.ToString());
            if (GUILayout.Button("-"))
            {
                this.SendCommand<TestDecreaseCommand>();
            }
        }

        public IArchitecture GetArchitecture()
        {
            return TestApp.Interface;
        }
    }
}

//#endif