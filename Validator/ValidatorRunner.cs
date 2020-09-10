using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator.IRules;

namespace Validator
{
    public class ValidatorRunner
    {

        private List<IRule> _rules = new List<IRule>();

        public ValidatorRunner() { }

        public void AddRule(IRule rule)
        {
            this._rules.Add(rule);
        }


        public bool ValidateInput(string input)
        {
            foreach(IRule rule in _rules)
            {
                if (!rule.validate(input))
                {
                    return false;
                }
            }

            return true;
        }



    }
}
