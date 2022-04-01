using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien.Model
{
    class DanhMuc
    {
        public Guid Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public String Decription { get; set; }

        private static List<DanhMuc> _DanhMucs { get; set; }
        /// <summary>
        /// Thêm Danh Mục Vào Danh sách
        /// </summary>
        /// <param name="dm"></param>
        public static void ThemDanhMuc(DanhMuc dm) {
            if (_DanhMucs == null)
                _DanhMucs = new List<DanhMuc>();
            _DanhMucs.Add(dm);
        }
        /// <summary>
        /// Lấy Danh Sách Danh Mục
        /// </summary>
        /// <returns></returns>
        public static List<DanhMuc> GetDanhMuc()
        {
            if (_DanhMucs == null)
                _DanhMucs = new List<DanhMuc>();
            return _DanhMucs;
        }


    }
}
