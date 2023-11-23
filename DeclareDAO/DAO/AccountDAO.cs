using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareDAO.DAO
{
    public class AccountDAO
    {
        KhaiBaoEntities dcontext = new KhaiBaoEntities();

        public Account getAccount(string un, string pw)
        {
            Account user = (from u in dcontext.Accounts
                            where u.usernames == un && u.passwords == pw
                            select u).FirstOrDefault<Account>();
            return user;
        }
    }
}
