using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclareDAO.DAO;
using DeclareDAO;

namespace DeclareBUS
{
    public class AccountBUS
    {
        AccountDAO accountDAO = new AccountDAO();
        public Account getAccount(string un, string pw)
        {
            return accountDAO.getAccount(un, pw);
        }
    }
}
