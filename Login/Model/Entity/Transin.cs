using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model.Entity
{
    public class Transin
    {
        public int id_in { get; set; }
        public DateTime tgl_beli { get; set; }
        public int jml_beli { get; set; }
        public int ttl_beli { get; set; }
        public int hrg_beli { get; set; }
        public int id_brg { get; set; }
        public string nama_brg { get; set; }
        public int id_bo { get; set; }
        public string username { get; set; }
        public int id_splr { get; set; }
        public string nama_splr { get; set; }
    }
}
