using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validators;
using Validators.UpperRules;
using Validators.LengthRules;

namespace ValidatorTests
{
    [TestClass]
    public class LengthAndUpperTests
    {
        [TestMethod]
        public void LengthUpperPassIfBothOK()
        {
            var validator = new Validator();

            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));

            var input = "ABC45678";
            bool result = validator.ValidateInput(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthUpperFailIfLengthFail()
        {
            var validator = new Validator();

            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));

            var input = "ABC4567";
            bool result = validator.ValidateInput(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthUpperFailIfUpperFail()
        {
            var validator = new Validator();

            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));

            var input = "ABc45678";
            bool result = validator.ValidateInput(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthUpperFailIfBothFail()
        {
            var validator = new Validator();

            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));

            var input = "ABc4567";
            bool result = validator.ValidateInput(input);

            Assert.IsFalse(result);
        }
    }
}
