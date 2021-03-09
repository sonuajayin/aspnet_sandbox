using System;
using Xunit;
using aspnet_sandbox.web;

namespace aspnet_sandbox.Tests
{
    public class UnitTest1
    {
        [Fact(DisplayName="Check if the AppName Mathes with the expected")]
        public void testForAppName()
        {
            var expectedAppName="AzurePipelines";
            var appNameService=new AppNameService();
            var actualAppName=appNameService.get();
            Assert.Equal(expectedAppName,actualAppName);
        }
    }
}
