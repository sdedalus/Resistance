namespace Application.Resistance.Testing
{
	using NUnit.Framework;

	public class ResistanceCommandHandlerShould
	{
		[TestCase("red", "red", "red", "gold")]
		public void CalculateResistanceForValidColorChoices(string bandA, string bandB, string bandC, string bandD, int expected)
		{
			Assert.IsTrue(true);
		}
	}
}