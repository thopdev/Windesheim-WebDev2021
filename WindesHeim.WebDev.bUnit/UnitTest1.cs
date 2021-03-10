using Bunit;
using Windesheim.WebDev.Blazor.Pages;
using Xunit;

namespace WindesHeim.WebDev.bUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using var ctx = new TestContext();

            var component = ctx.RenderComponent<TodoListComponent>();

            Assert.Equal(2, component.FindAll("input[type=checkbox]").Count);
        }
    }
}
