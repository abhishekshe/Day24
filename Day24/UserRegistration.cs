using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        //pattern for mail id.
        
        string emailPattern = @"^([a-z0-9A-Z])+([._+-]?[a-z0-9A-Z]+)*[@]{1}[a-z0-9A-Z]+[.]{1}[a-zA-Z]{3}([.]{1}[a-z]{2})?$";
        //pattern for first name and last name
       
        string firstNamePattern = "[A-Z]{1}[A-Za-z]{2,}";

        //pattern for first mobileNo
        string mobileNoPattern = @"\d{2}\s{1}[6-9]{1}\d{9}";
        //pattern for first Password
        string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
       
        public bool FirstAndLastName(string input) => Regex.IsMatch(input, firstNamePattern) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_name, "invalid name");
        
        public bool Email(string input) => Regex.IsMatch(input, emailPattern) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_email, "invalid email");
        public bool MobileNo(string input) => Regex.IsMatch(input, mobileNoPattern) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_phone, "invalid phone");
        public bool Password(string input) => Regex.IsMatch(input, passwordPattern) ? true : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.invalid_password, "invalid password");

    }
}