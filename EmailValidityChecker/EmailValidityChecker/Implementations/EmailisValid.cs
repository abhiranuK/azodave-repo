using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidityChecker.Interfaces
{
    public class EmailisValid : IEmailisValid
    {
        public string ReturnvalidMessage()
        {
            return "Email is Valid";
        }
    }
}
