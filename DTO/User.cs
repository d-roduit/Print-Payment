using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int UID { get; set; }
        public string Username { get; set; }
        public decimal Credit { get; set; }
        public int NbSheets { get; set; }
    }
}
