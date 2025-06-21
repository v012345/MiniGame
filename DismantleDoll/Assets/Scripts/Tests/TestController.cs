using QFramework.TestApp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;
namespace QFramework.TestApp
{
    public class TestController : MonoBehaviour, IController
    {
        public Button btnAdd;
        public Button btnSub;
        public Text text;
        private ITestModel mModel;
        void Start()
        {
            mModel = this.GetModel<ITestModel>();
            btnAdd.onClick.AddListener(() =>
            {
                this.SendCommand<TestIncreaseCommand>();
            });
            btnSub.onClick.AddListener(() =>
            {
                this.SendCommand<TestDecreaseCommand>();
            });
            //this.RegisterEvent<TestEvent>(e => {
            //    UpdateView();
            //}).UnRegisterWhenGameObjectDestroyed(gameObject);

            ActionKit.Repeat().Delay(2.0f, () =>
            {
                Debug.Log(Time.time);
            }).Start(this);
            mModel.Count.RegisterWithInitValue(count => {
                UpdateView();
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        void UpdateView()
        {
            text.text = mModel.Count.ToString();
        }

        public IArchitecture GetArchitecture()
        {
            return TestApp.Interface;
        }

    }
}
