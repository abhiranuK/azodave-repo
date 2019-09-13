using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidityChecker.Interfaces
{
    public class EmailisNotValid : IEmailisNotValid
    {
        public string ReturnInvalidMessage()
        {
            return "Email is InValid";
        }
    }
}
