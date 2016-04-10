namespace Application.Resistance.Testing
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class TestFrameworkShould
	{
		[TestMethod]
		public void PassOnAssertTrue()
		{
			Assert.IsTrue(true);
		}
	}
}