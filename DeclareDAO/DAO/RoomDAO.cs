using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareDAO.DAO
{
    public class RoomDAO
    {
        KhaiBaoEntities dcontext = new KhaiBaoEntities();

        public List<Room> getAll()
        {
            return dcontext.Rooms.ToList<Room>();
        }

        public void Add(Room r)
        {
            dcontext.Rooms.Add(r);
            dcontext.SaveChanges();
        }

        public void Edit(Room r)
        {
            Room room = dcontext.Rooms.Find(r.maphong);
            if (room != null)
            {
                room.tenphong = r.tenphong;
                room.soluong = r.soluong;
                room.tinhtrang = r.tinhtrang;
            }
            dcontext.SaveChanges();
        }

        public void Delete(Room r)
        {
            Room room = dcontext.Rooms.Find(r.maphong);
            dcontext.Rooms.Remove(room);
            dcontext.SaveChanges();
        }
    }
}
