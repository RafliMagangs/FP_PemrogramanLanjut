using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model.Entity
{
    public class Barang
    {
        public int id_brg { get; set; }
        public string nama_brg { get; set; }
        public string kategori_brg { get; set; }
        public int stock_awal { get; set; }
        public int hrg_beli { get; set; }
        public int hrg_jual { get; set; }
    }
}
