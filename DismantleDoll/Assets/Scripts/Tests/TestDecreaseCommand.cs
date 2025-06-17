namespace QFramework.TestApp
{
    public class TestDecreaseCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ITestModel>().Count.Value--;
            //this.SendEvent<TestEvent>();
        }
    }
}