using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model.Entity
{
    public class Transout
    {
        public int id_out { get; set; }
        public DateTime tgl_jual { get; set; }
        public int jml_jual { get; set; }
        public int ttl_jual { get; set; }
        public int hrg_jual { get; set; }
        public int id_brg { get; set; }
        public string nama_brg { get; set; }
        public int id_bo { get; set; }
        public string username { get; set; }
        public int id_distributor { get; set; }
        public string nama_distributor { get; set; }
    }
}
