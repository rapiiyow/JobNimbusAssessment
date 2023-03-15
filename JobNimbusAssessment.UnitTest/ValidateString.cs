using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobNimbusAssessment.UnitTest
{
    [TestClass]
    public class ValidateString
    {
        [TestMethod]
        public void CheckTrueIfEmpty()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckTrueIfCorrectBracket()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("{}");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckFalseCloseFirst()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("}{");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckFalseNotClosed()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("{{}");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckTrueIfEmptyString()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckTrueIfCorrectBracket2()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("{abc...xyz}");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckTrueIfCorrectBracket3()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("{{a}{bc}...xyz}");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckFalseIfIncorrectBracket4()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("{{a}{bc}...x}yz}");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckFalseIfIncorrectBracket5()
        {
            var bs = new BracketInString();

            var result = bs.isValidBracket("{{a}{bc}...{x}y{z}");

            Assert.IsFalse(result);
        }
    }
}
