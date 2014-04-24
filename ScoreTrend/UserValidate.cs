using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ScoreTrend
{
    public class UserValidate
    {
        
        public static bool validate(string password)
        {
            {   //This regex is used to restrict passwords to a length of 8 to 20 aplhanumeric characters and select special characters. The password cannot start with a digit, underscore or special character and must contain at least one digit.
                string passwordPattern = @"^(?=[^\d_].*?\d)\w(\w|[!@#$%]){7,20}";
                string usernamePattern = @"^(?=[^\d_].*?\d)\w(\w|[!@#$%])";
                
                //new Regex object that uses the pattern
                Regex passwordValidation = new Regex(passwordPattern);
                Regex usernameValidation = new Regex(usernamePattern);

                //condition to check for unwanted characters
                if((passwordValidation.IsMatch(password)))
                    {
                        return true;
                    }
                else
                    {
                        return true;
                    }
            }
            
        }
    }
}

