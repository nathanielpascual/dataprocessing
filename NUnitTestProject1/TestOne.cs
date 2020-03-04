using NUnit.Framework;
using opg_201910_interview.Models;
using opg_201910_interview.Utility;
namespace Tests
{
	[TestFixture]
	public class TestOne
	{
		private FileIteration _fileIteration;

		public TestOne()
		{
			_fileIteration = new FileIteration();
		}

		[Test]
		public void Test_Client_A()
		{
			ClientSetting clientSetting = new ClientSetting();
		
			_fileIteration = new FileIteration(clientSetting);
			Assert.AreEqual(1001, clientSetting.ClientID);

			Assert.Pass();
		}
	}
}