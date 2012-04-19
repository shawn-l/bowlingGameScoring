using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingGameScoring;

namespace bowlingGameScoringTest
{
    /// <summary>
    /// GameTest 的摘要说明
    /// </summary>
    [TestClass]
    public class GameTest
    {
        private BowlingGame game;
        public GameTest()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
           game = new BowlingGame();
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestGameScore()
        {
            game.AddOneRollData(5);
            game.AddOneRollData(1);
            game.CalculateScoring();
            Assert.AreEqual(6, game.GetScoringInRound(1));
        }
       
          [TestMethod]
        public void GameIntegrationTest()
        {
            game.AddOneRollData(1);
            game.AddOneRollData(4);

            game.AddOneRollData(4);
            game.AddOneRollData(5);

            game.AddOneRollData(6);
            game.AddOneRollData(4);

            game.AddOneRollData(5);
            game.AddOneRollData(5);

            game.AddOneRollData(10);

            game.AddOneRollData(0);
            game.AddOneRollData(1);

            game.AddOneRollData(7);
            game.AddOneRollData(3);

            game.AddOneRollData(6);
            game.AddOneRollData(4);

            game.AddOneRollData(10);

            game.AddOneRollData(2);
            game.AddOneRollData(8);
            game.AddOneRollData(6);

            game.CalculateScoring();

            Assert.AreEqual(5, game.GetScoringInRound(1));
            Assert.AreEqual(14, game.GetScoringInRound(2));
            Assert.AreEqual(29, game.GetScoringInRound(3));
            Assert.AreEqual(49, game.GetScoringInRound(4));
            Assert.AreEqual(60, game.GetScoringInRound(5));
            Assert.AreEqual( 61,game.GetScoringInRound(6));
            Assert.AreEqual(77, game.GetScoringInRound(7));
            Assert.AreEqual(97, game.GetScoringInRound(8));
            Assert.AreEqual(117, game.GetScoringInRound(9));
            Assert.AreEqual(133, game.GetScoringInRound(10));
          }
    }
}
