using FluentAssertions;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;

namespace ApiTest
{
    [TestFixture]
    public class Tests
    {
        // Test Web API Host
        private readonly TestServer Server;

        // 主要用來呼叫 TestServer 時使用
        private readonly HttpClient Client;

        // 提供 Web API 使用的組態設定，可使用測試用組態設定
        private readonly IConfiguration Configuration;
        [SetUp]
        public void Setup()
        {
            //多筆測試時統一初始化的地方
        }

        [Test]
        public void PlayerTest()
        {
            //Arrange
            string url = "https://localhost:7122/PlayerVerification";

            //Act

            //Assert
        }
        [TestCase(1,2)]
        public void Test1(int a,int b )
        {
            //Arrange

            // Act

            //Assert
            int actual_1 = Add(1, 2);
            int actual_2 = Add(2, 4);
            int expected_1 = 3;
            int expected_2 = 6;

            Assert.AreEqual(expected_1, actual_1);
            Assert.AreEqual(expected_2, actual_2);

            Assert.AreNotEqual(expected_1, actual_2);
            Assert.AreNotEqual(expected_2, actual_1);
            //Assert.Pass();

        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        [TearDown]
        public void TearDown()
        {
            //銷毀測試後的資料，回歸初始值
        }
    }
}