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
        
        public static bool validate(string username,string password)
        {
            {   //This regex is used to restrict passwords to a length of 8 to 20 aplhanumeric characters and select special characters. The password cannot start with a digit, underscore or special character and must contain at least one digit.
                string usernamePattern = @"^(?=[^\d_].*?\d)\w(\w|[!@#$%]){7,20}";
                string passwordPattern = @"^(?=[^\d_].*?\d)\w(\w|[!@#$%]){7,20}";

                //new Regex object that uses the pattern
                Regex usernameValidation = new Regex(usernamePattern);
                Regex passwordValidation = new Regex(passwordPattern);

                //condition to check for unwanted characters
                if(usernameValidation.IsMatch(username) && passwordValidation.IsMatch(password))
                    {
                        return true;
                    }
                else
                    {
                        return false;
                    }
            }
            
        }
    }
}

