using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators.IRules;

namespace Validators.UpperRules
{
    public class UpperRule : IRule
    {
        private int _target;

        public UpperRule(int target)
        {
            this._target = target;
        }

        bool IRule.validate(string input)
        {
            int counter = 0;

            foreach(char c in input)
            {
                if (Char.IsUpper(c))
                {
                    counter++;
                    if(counter >= _target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
