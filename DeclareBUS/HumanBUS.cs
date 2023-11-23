using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclareDAO.DAO;
using DeclareDAO;

namespace DeclareBUS
{
    public class HumanBUS
    {
        HumanDAO humanDAO = new HumanDAO();
        List<Human> humen;

        public List<Human> getAll()
        {
            humen = humanDAO.getAll();
            return humen;
        }

        public bool Add(Human h)
        {
            if (humen.Find(human => human.CMT == h.CMT) == null)
            {
                h.maphong = h.maphong.Trim();
                h.hoten = h.hoten.Trim();
                h.gioitinh = h.gioitinh.Trim();
                h.ngaysinh = h.ngaysinh;
                h.sdt = h.sdt.Trim();
                h.diachi = h.diachi.Trim();
                h.email = h.email.Trim();
                h.tiem_Vaccin = h.tiem_Vaccin;
                h.ngaykhaibao = h.ngaykhaibao;
                humanDAO.Add(h);
                humen.Add(h);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Edit(Human h)
        {
            humanDAO.Edit(h);
        }

        public void Delete(Human h)
        {
            humanDAO.Delete(h);
        }
    }
}
