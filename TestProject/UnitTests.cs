using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TyPoGrApH;

namespace TestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Replace_PlusMinus_Into_Char()
        {
            //Arrange
            string str = "Absurd message (+,-)";
            string expected = "Absurd message ±";

            //Act
            Methods.ReplacePlusMinus(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_TwoSpaces_Into_OneSpace()
        {
            //Arrange
            string str = "Absurd  message";
            string expected = "Absurd message";

            //Act
            Methods.ReplaceToOneSpace(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_ThreeDots_To_Char()
        {
            //Arrange
            string str = "Absurd message...";
            string expected = "Absurd message…";

            //Act
            Methods.ReplaceDots(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_SpacePoint_To_Point()
        {
            //Arrange
            string str = "Absurd message .";
            string expected = "Absurd message.";

            //Act
            Methods.WorkWithCharsAndSpaces(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_Dash_To_SpaceDashSpace()
        {
            //Arrange
            string str = "Absurd—message";
            string expected = "Absurd — message";

            //Act
            Methods.WorkWithCharsAndSpaces(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_BracketSpace_To_Bracket()
        {
            //Arrange
            string str = "Absurd ( message )";
            string expected = "Absurd (message)";

            //Act
            Methods.WorkWithCharsAndSpaces(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_Hashtag_To_Sharp()
        {
            //Arrange
            string str = "Absurd message is хештег";
            string expected = "Absurd message is шарп";

            //Act
            Methods.ReplaceHashtage(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_SoftSign_To_b()
        {
            //Arrange
            string str = "Завтра опять рано просыпаться";
            string expected = "Завтра опятб рано просыпатбся";

            //Act
            Methods.ReplaceToNearChar(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_Replace_EverySecondChar_To_Upper()
        {
            //Arrange
            string str = "Absurd message";
            string expected = "AbSuRd mEsSaGe";

            //Act
            Methods.MakeAbsurd(str);

            //Accert
            Assert.AreEqual(expected, str);
        }

        [TestMethod]
        public void Test_ThreeMethods()
        {
            //Arrange
            string str = "Absurd message :  smt...";
            string expected = "Absurd message: smt…";

            //Act
            Methods.ReplaceToOneSpace(str);
            Methods.WorkWithCharsAndSpaces(str);
            Methods.ReplaceDots(str);

            //Accert
            Assert.AreEqual(expected, str);
        }
    }
}
