using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclareDAO.DAO;
using DeclareDAO;

namespace DeclareBUS
{
    public class ManagerBUS
    {
        ManagerDAO managerDAO = new ManagerDAO();
        List<Manager> managers;

        public List<Manager> getAll()
        {
            managers = managerDAO.getAll();
            return managers;
        }

        public bool Add(Manager m)
        {
            if (managers.Find(manager => manager.maql == m.maql) == null)
            {
                m.maphong = m.maphong.Trim();
                m.hotenql = m.hotenql.Trim();
                m.gioitinh = m.gioitinh.Trim();
                m.ngaysinh = m.ngaysinh;
                m.sdt = m.sdt.Trim();
                m.diachi = m.diachi.Trim();
                m.email = m.email.Trim();
                managerDAO.Add(m);
                managers.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Edit(Manager m)
        {
            managerDAO.Edit(m);
        }

        public void Delete(Manager m)
        {
            managerDAO.Delete(m);
        }
    }
}
