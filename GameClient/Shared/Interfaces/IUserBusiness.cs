using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IUserBusiness
    {

        void InsertUser(User user);
        bool IsUserAlreadyExists(string email);
        bool LoginValidation(string email, string password);
        bool EmailFormatValidation(string email);
        bool NameAndLastNameFormatValidation(string input);
        bool PhoneFormatValidation(string phone);
    }
}
