using Microsoft.Extensions.Logging;
using Xunit;

namespace ConsoleLoggerTest
{
    public class UnitTest
    {
        [Fact]
        public void TestConsoleLogger()
        {
            new LoggerFactory().AddConsole().CreateLogger("Test");
        }
    }
}
