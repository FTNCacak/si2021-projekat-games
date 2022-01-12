using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
namespace Shared.Interfaces
{
    public interface IUserRepository
    {
        void InsertUser(User user);
        List<string> GetAllEmails();
        string GetUserPasswordByEmail(string email);
        User GetUserData(string email);

        void UpdateUserPassword(int UserID, string newPassword);

        void UpdateUserWallet(int UserID, decimal wallet);

    }
}
