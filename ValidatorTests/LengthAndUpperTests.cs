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
            //arrange
            var validator = new Validator();
            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));
            var input = "ABC45678";

            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LengthUpperFailIfLengthFail()
        {
            //arrange
            var validator = new Validator();
            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));
            var input = "ABC4567";
            
            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthUpperFailIfUpperFail()
        {
            //arrange
            var validator = new Validator();
            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));
            var input = "ABc45678";

            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LengthUpperFailIfBothFail()
        {
            //arrange
            var validator = new Validator();
            validator.AddRule(new LengthRule(8));
            validator.AddRule(new UpperRule(3));
            var input = "ABc4567";

            //act
            bool result = validator.ValidateInput(input);

            //assert
            Assert.IsFalse(result);
        }
    }
}
