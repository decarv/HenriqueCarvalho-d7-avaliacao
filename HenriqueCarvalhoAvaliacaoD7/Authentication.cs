using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueCarvalhoAvaliacaoD7
{
    public class Authentication
    {
        static public bool AuthenticateUser(string username, string password, byte[] storedHashedPassword)
        {
            byte[] hashedPassword = new byte[32];
            hashedPassword = Password.ComputeHash(password);
            return storedHashedPassword.SequenceEqual(hashedPassword);
        }
    }
}
