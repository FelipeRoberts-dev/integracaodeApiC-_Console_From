using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumidor02.api
{
    public class Trabalho
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}
