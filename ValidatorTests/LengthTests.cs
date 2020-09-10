using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validators;
using Validators.LengthRules;

namespace ValidatorTests
{
    [TestClass]
    public class LengthTests
    {
        [TestMethod]
        public void LengthRuleRetrunsTrueIfEqualTarget()
        {
            //arrange
            Validator validator = new Validator();
            validator.AddRule(new LengthRule(8));
            string input = "12345678";

            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthRuleRetrunsTrueIfGreaterThanTarget()
        {
            //arrange
            Validator validator = new Validator();
            validator.AddRule(new LengthRule(8));
            string input = "123456789";

            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthRuleRetrunsFalseIfGreaterThanTarget()
        {
            //arrange
            Validator validator = new Validator();
            validator.AddRule(new LengthRule(8));
            string input = "1234567";

            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsFalse(result);
        }

    }
}
