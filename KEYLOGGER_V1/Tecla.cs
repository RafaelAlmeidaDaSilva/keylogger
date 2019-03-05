using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEYLOGGER_V1
{
    class Tecla
    {
        public string  naotraduizada { get; set; }
        public string  traduzida { get; set; }
        public string  editada { get; set; }


        public Tecla(string n, string t, string e)
        {
            this.naotraduizada = n;
            this.traduzida = t;
            this.editada = e;

        }
    }
}
