using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingGameScoring;

namespace bowlingGameScoringTest
{
    /// <summary>
    /// UnitTest1 的摘要说明
    /// </summary>
    [TestClass]
    public class ScoringTest
    {
        private Scoring scoring;
        public ScoringTest()
        {
            scoring = new Scoring();
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
        public void TestRoundAddDownPins()
        {
            int[] data = new int[4];
            data[0] = 4;
            data[1] = 5;
            data[2] = 6;
            data[3] = 1;
            scoring.AddRoundData(data); 

            Assert.AreEqual(9, scoring.GetScoringInRound(1));
            Assert.AreEqual(16, scoring.GetScoringInRound(2));
        }

        [TestMethod]
        public void TestSpare()
        {
            int[] data = new int[4];
            data[0] = 4;
            data[1] = 6;
            data[2] = 2;
            data[3] = 3;

            scoring.AddRoundData(data);
            Assert.AreEqual(12, scoring.GetScoringInRound(1));
            Assert.AreEqual(17, scoring.GetScoringInRound(2));
        }

        [TestMethod]
        public void TestStrike()
        {
            int[] data = new int[7];
            data[0] = 10;
            data[1] = 0;
            data[2] = 6;
            data[3] = 2;
            data[4] = 5;
            data[5] = 5;
            data[6] = 1;

            scoring.AddRoundData(data);
            Assert.AreEqual(18, scoring.GetScoringInRound(1));
            Assert.AreEqual(26, scoring.GetScoringInRound(2));
            Assert.AreEqual(37, scoring.GetScoringInRound(3));
        }

        [TestMethod]
        public void ScoringIntegrationTest()
        {
            int[] data = new int[21];

            data[0] = 1;
            data[1] = 4;

            data[2] = 4;
            data[3] = 5;

            data[4] = 6;
            data[5] = 4;

            data[6] = 5;
            data[7] = 5;

            data[8] = 10;
            data[9] = 0;

            data[10] = 0;
            data[11] = 1;

            data[12] = 7;
            data[13] = 3;

            data[14] = 6;
            data[15] = 4;

            data[16] = 10;
            data[17] = 0;

            data[18] = 2;
            data[19] = 8;
            data[20] = 6;

            scoring.AddRoundData(data);
            Assert.AreEqual(5, scoring.GetScoringInRound(1));
            Assert.AreEqual(14, scoring.GetScoringInRound(2));
            Assert.AreEqual(29, scoring.GetScoringInRound(3));
            Assert.AreEqual(49, scoring.GetScoringInRound(4));
            Assert.AreEqual(60, scoring.GetScoringInRound(5));
            Assert.AreEqual(61, scoring.GetScoringInRound(6));
            Assert.AreEqual(77, scoring.GetScoringInRound(7));
            Assert.AreEqual(97, scoring.GetScoringInRound(8));
            Assert.AreEqual(117, scoring.GetScoringInRound(9));
            Assert.AreEqual(133, scoring.GetScoringInRound(10));
        }
    }
}
