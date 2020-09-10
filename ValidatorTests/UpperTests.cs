using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validators;
using Validators.UpperRules;

namespace ValidatorTests.UpperTests
{
    [TestClass]
    public class UpperTests
    {

        [TestMethod]
        public void UpperRuleReturnsTrueIfGreaterThanTarget()
        {
            Validator validator = new Validator();
            validator.AddRule(new UpperRule(3));
            string input = "ABCDefgh";

            bool result = validator.ValidateInput(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpperRuleReturnsTrueIfEqualTarget()
        {
            Validator validator = new Validator();
            validator.AddRule(new UpperRule(3));
            string input = "ABCdefgh";

            bool result = validator.ValidateInput(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UpperRuleReturnsFalseIfLessThanTarget()
        {
            Validator validator = new Validator();
            validator.AddRule(new UpperRule(3));
            string input = "ABcdefgh";

            bool result = validator.ValidateInput(input);

            Assert.IsFalse(result);
        }


    }
}
