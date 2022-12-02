using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenriqueCarvalhoAvaliacaoD7
{
    internal class Handlers
    {
        internal static bool LoginHandler(Database db, string username, string password)
        {
            byte[]? passwordHashPlusSalt = db.ReadHashedPasswordPlusSalt(username);
            return Authentication.AuthenticateUser(username, password, passwordHashPlusSalt);
        }
    }
}
