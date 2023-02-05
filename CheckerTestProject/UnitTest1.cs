using AngleSharp.Dom;
using Bunit;
using CheckersGame;
using CheckersGame.Data;
using System.Drawing;
using Xunit.Abstractions;

namespace CheckerTestProject
{
	public class UnitTest1 : TestContext
	{
		private readonly ITestOutputHelper _testOutputHelper;
		public UnitTest1(ITestOutputHelper testOutputHelper)
		{
			_testOutputHelper = testOutputHelper;
		}
		[Fact]
		public void mintest()
		{
			List<Checker> checkers = new List<Checker>();
			Checker testChecker= new Checker();
			testChecker.Color = "black";
			Assert.IsType<Checker>(testChecker);
		
		}
        [Fact]
        public void mintest1()
        {
            var cut1 = RenderComponent<Checkersboard>();

            var cut1Result = cut1.Find("button");
            var cut2 = cut1.Find("span");
			cut2.MarkupMatches("<span class=\"blackSpelare\">0</span>");
			cut1Result.Click();
            cut2.MarkupMatches("<span class=\"blackSpelare\">0</span>");
			_testOutputHelper.WriteLine(cut1Result.ToString());
			Checkersboard.ReferenceEquals(cut1, cut1Result);
			
			
		}
        [Fact]
        public void winnerTest()
        {
            var cut1 = RenderComponent<Checkersboard>(parameters => parameters.Add(p => p.winnerT, "black"));

            var cut1Result = cut1.Find("button");
            var cut2 = cut1.Find("h2");
			cut1Result.Click();
			cut2.MarkupMatches("<h2 class=\"winner-str\">black</h2>");
		}
        [Fact]
        public void scoreTest()
        {
            var cut1 = RenderComponent<Checkersboard>(parameters => parameters.Add(p => p.score, 12));

			var cut1Result = cut1.Find("button");
			var cut2 = cut1.Find("span");
			cut2.MarkupMatches("<span class=\"blackSpelare\">12</span>");
			
        }
        [Fact]
		public void CounterShoudIncrementClicked()
		{
			
			var cut = RenderComponent<Checkersboard>();
			var cutResult = cut.Find("div").GetElementsByClassName(".checker");
			_testOutputHelper.WriteLine(cutResult.ToString());

		}

	}
}