using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidityChecker
{
     public interface IValidityCheck
    {
        bool EmailCheckerMethod(string input);
    }
}
