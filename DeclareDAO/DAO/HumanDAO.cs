using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareDAO.DAO
{
    public class HumanDAO
    {
        KhaiBaoEntities dcontext = new KhaiBaoEntities();

        public List<Human> getAll()
        {
            return dcontext.Humen.ToList<Human>();
        }

        public void Add(Human h)
        {
            dcontext.Humen.Add(h);
            dcontext.SaveChanges();
        }

        public void Edit(Human h)
        {
            Human human = dcontext.Humen.Find(h.CMT);
            if (human != null)
            {
                human.maphong = h.maphong;
                human.hoten = h.hoten;
                human.gioitinh = h.gioitinh;
                human.ngaysinh = h.ngaysinh;
                human.sdt = h.sdt;
                human.email = h.email;
                human.diachi = h.diachi;
                human.tiem_Vaccin = h.tiem_Vaccin;
                human.ngaykhaibao = h.ngaykhaibao;
            }
            dcontext.SaveChanges();
        }

        public void Delete(Human h)
        {
            Human human = dcontext.Humen.Find(h.CMT);
            dcontext.Humen.Remove(human);
            dcontext.SaveChanges();
        }
    }
}
