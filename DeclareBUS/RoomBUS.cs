using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeclareDAO.DAO;
using DeclareDAO;

namespace DeclareBUS
{
    public class RoomBUS
    {
        RoomDAO roomDAO = new RoomDAO();
        List<Room> rooms;

        public List<Room> getAll()
        {
            rooms = roomDAO.getAll();
            return rooms;
        }

        public bool Add(Room r)
        {
            if (rooms.Find(room => room.maphong == r.maphong) == null)
            {
                r.tenphong = r.tenphong.Trim();
                r.soluong = r.soluong;
                r.tinhtrang = r.tinhtrang.Trim();
                roomDAO.Add(r);
                rooms.Add(r);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Edit(Room r)
        {
            roomDAO.Edit(r);
        }

        public void Delete(Room r)
        {
            roomDAO.Delete(r);
        }
    }
}
