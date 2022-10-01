using System.Diagnostics;
using Xunit.Abstractions;

namespace evmc.tests
{
    public class ExampleTester
    {
        private readonly ITestOutputHelper _console;

        public ExampleTester(ITestOutputHelper console)
        {
            _console = console;
        }

        [Fact]
        public void PassesTests()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "evmc-vmtester.exe",
                    Arguments = "example.dll",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };

            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                var output = process.StandardOutput.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(output))
                    _console.WriteLine(output);

                var error = process.StandardError.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(error))
                    _console.WriteLine(error);

                Assert.True(string.IsNullOrWhiteSpace(error));
            }
        }
    }
}
