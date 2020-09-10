using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators.IRules;

namespace Validators.LengthRules
{
    public class LengthRule : IRule
    {
        private int _target;

        public LengthRule(int target)
        {
            this._target = target;
        }

        bool IRule.validate(string input)
        {
            return input.Length >= _target;
        }
    }
}
