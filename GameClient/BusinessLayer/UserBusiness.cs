using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace BusinessLayer
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository userRepository;

        public UserBusiness(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }



        // Method for implementing insert from data layer
        public void InsertUser(User user)
        {
            userRepository.InsertUser(user);
        }


        // Method for checking existence of user in database
        public bool IsUserAlreadyExists(string email)
        {
            List<string> emails = userRepository.GetAllEmails();

            if (emails.Count == 0)
                return false;


            foreach (var item in emails)
            {
                if (item == email)
                    return true;
            }

            return false;
        }


        // Method for Login validation
        public bool LoginValidation(string email, string password)
        {
            string passwordFromDataBase = userRepository.GetUserPasswordByEmail(email);

            if (passwordFromDataBase == password)
                return true;


            return false;
        }


        // Method for email validation
        public bool EmailFormatValidation(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // Method for name and lastname format validation
        public bool NameAndLastNameFormatValidation(string input)
        {
            Regex pattern = new Regex("[A-Z]{1}[a-z]{1,}");
            return pattern.Match(input).Success;
        }

        // Method for phone format validation
        public bool PhoneFormatValidation(string phone)
        {
            Regex pattern = new Regex("^(0{1}[0-9]{2})/([0-9]{3})-([0-9]{3,4})$");
            return pattern.Match(phone).Success;
        }


    }
}
