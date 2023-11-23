using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareDAO.DAO
{
    public class ManagerDAO
    {
        KhaiBaoEntities dcontext = new KhaiBaoEntities();

        public List<Manager> getAll()
        {
            return dcontext.Managers.ToList<Manager>();
        }

        public void Add(Manager m)
        {
            dcontext.Managers.Add(m);
            dcontext.SaveChanges();
        }

        public void Edit(Manager m)
        {
            Manager manager = dcontext.Managers.Find(m.maql);
            if (manager != null)
            {
                manager.maphong = m.maphong;
                manager.hotenql = m.hotenql;
                manager.gioitinh = m.gioitinh;
                manager.diachi = m.diachi;
                manager.ngaysinh = m.ngaysinh;
                manager.sdt = m.sdt;
                manager.email = m.email;
            }
            dcontext.SaveChanges();
        }

        public void Delete(Manager m)
        {
            Manager manager = dcontext.Managers.Find(m.maql);
            dcontext.Managers.Remove(manager);
            dcontext.SaveChanges();
        }
    }
}
