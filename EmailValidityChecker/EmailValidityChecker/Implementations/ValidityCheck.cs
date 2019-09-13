using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EmailValidityChecker
{
    public class ValidityCheck : IValidityCheck
    {
        
        public bool EmailCheckerMethod(string input)
        {
            bool answer = true;
            
            if (Regex.IsMatch(input,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")) 
            {
                answer = true;
            }

            else
            {
                answer = false;

            }
            return answer;
        }
    }
}
