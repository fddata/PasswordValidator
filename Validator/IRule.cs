using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator.IRules
{
    internal interface IRule
    {
        bool validate(string input);
    }
}
