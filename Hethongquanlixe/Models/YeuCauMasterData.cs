using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hethongquanlixe.Models
{
    public class YeuCauMasterData
    {
        public int IdYC { get; set; }
        public Nullable<int> Makhachhang { get; set; }
        public Nullable<int> Mahopdong { get; set; }
        public Nullable<System.DateTime> NgayDi { get; set; }
        public Nullable<System.DateTime> NgayVe { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
        public Nullable<int> Madichvu { get; set; }
        public Nullable<int> Manhanvien { get; set; }
        public Nullable<int> Mayeucau { get; set; }
        public Nullable<int> Matrangthai { get; set; }
        public Nullable<int> Maxe { get; set; }
        public string Ghichu { get; set; }
    }
}