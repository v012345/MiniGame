namespace QFramework.TestApp
{
    public class TestIncreaseCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ITestModel>().Count.Value++;
            //this.SendEvent<TestEvent>();
        }
    }
}