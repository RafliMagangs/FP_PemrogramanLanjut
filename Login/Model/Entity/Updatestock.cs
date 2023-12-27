using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model.Entity
{
    public class Updatestock
    {
        public int id_upstock { get; set; }
        public DateTime tgl_update { get; set; }
        public int jml_update { get; set; }
        public int id_brg { get; set; }
        public string nama_brg { get; set; }
    }
}
