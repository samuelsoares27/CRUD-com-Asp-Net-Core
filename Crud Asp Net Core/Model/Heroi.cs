using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Asp_Net_Core.Model
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}
