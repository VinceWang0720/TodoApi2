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

        // �D�n�ΨөI�s TestServer �ɨϥ�
        private readonly HttpClient Client;

        // ���� Web API �ϥΪ��պA�]�w�A�i�ϥδ��եβպA�]�w
        private readonly IConfiguration Configuration;
        [SetUp]
        public void Setup()
        {
            //�h�����ծɲΤ@��l�ƪ��a��
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
            //�P�����ի᪺��ơA�^�k��l��
        }
    }
}