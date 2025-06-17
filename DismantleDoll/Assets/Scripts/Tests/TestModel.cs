
namespace QFramework.TestApp
{
    public interface ITestModel : IModel
    {
        BindableProperty<int> Count { get; }

    }
    public class TestModel : AbstractModel, ITestModel
    {
        public BindableProperty<int> Count { get; } = new BindableProperty<int>(0);
        protected override void OnInit()
        {
            ITestStorage mStorage = this.GetUtility<ITestStorage>();
            Count.Value = mStorage.LoadInt(nameof(Count));
            Count.Register(count => { mStorage.SaveInt(nameof(Count), count); });
        }
    }
}