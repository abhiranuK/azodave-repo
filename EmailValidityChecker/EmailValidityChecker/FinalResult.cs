using EmailValidityChecker.Interfaces;

namespace EmailValidityChecker
{
    public class FinalResult : IFinalResult
    {
      
       
        public string ReturnFinalResult(string input)
        {
             bool Value = true;
             string result = string.Empty;

            IValidityCheck Check = new ValidityCheck();
            Value = Check.EmailCheckerMethod(input);

            if (Value == true)
            {
                IEmailisValid _answer = new EmailisValid();
                result = _answer.ReturnvalidMessage();
            }

            else
            {
                IEmailisNotValid _answer = new EmailisNotValid();
                result = _answer.ReturnInvalidMessage();
            }
            return result;
        }



    }
}
    