using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace QFramework.TestApp {
    public class TestApp : Architecture<TestApp>
    {
        protected override void Init() {
            this.RegisterModel<ITestModel>(new TestModel());
            this.RegisterUtility<ITestStorage>(new TestStorage());
            this.RegisterSystem<ITestSystem>(new TestSystem());
        }
        //protected override void ExecuteCommand(ICommand command)
        //{
        //    Debug.Log("before");
        //    base.ExecuteCommand(command);   
        //    Debug.Log("after");
        //}
    }

}


