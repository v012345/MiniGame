
using UnityEngine;
namespace QFramework.TestApp
{
    public interface ITestSystem : ISystem { }
    public class TestSystem : AbstractSystem, ITestSystem
    {
        protected override void OnInit()
        {
            ITestModel counterModel = this.GetModel<ITestModel>();
            counterModel.Count.Register(count =>
            {
                if (count == 10)
                {
                    Debug.Log("10!!!!!!!!!!!!");
                }
                else if (count == 20)
                {
                    Debug.Log("20!!!!!!!!!!!!!");
                }
            });
        }
    }
}