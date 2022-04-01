using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Model
{
    class NhanVien
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime BOD { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public NhanVien()
        {
            
        }

        private static List<NhanVien> _DSNhanVien { get; set; }
        public static NhanVien CurrentUser { get;set; }

        public static NhanVien TimNhanVien(string taiKhoan, string matKhau)
        {
            List<NhanVien> dsNhanVien = DSNhanVien();
            foreach (var nv in dsNhanVien)
            {
                if (nv.Username == taiKhoan && nv.Password == matKhau)
                {
                    return nv;
                }
            }
            return new NhanVien();
        }

        internal static void DSNhanVien(NhanVien nv)
        {
            if (_DSNhanVien == null)
                _DSNhanVien = new List<NhanVien>();
            _DSNhanVien.Add(nv);
        }

        internal static List<NhanVien> DSNhanVien()
        {
            if (_DSNhanVien == null)
                _DSNhanVien = new List<NhanVien>();
            return _DSNhanVien;
        }
    }
}
