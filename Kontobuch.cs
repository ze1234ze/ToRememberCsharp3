using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsApp.Classes
{
    internal class Kontobuch
    {
        public string BankName { get; set; }
        public List<Konto> Konten { get; set; }
        public Kontobuch(string bankName) 
        {
            BankName = bankName;
            Konten = new List<Konto>();
        }
        public Konto GetKonto(string kontoNr)
        {
            var konto = Konten.Find(k => k.KontoNr.Equals(kontoNr));
            if (konto != null) return konto;
            throw new Exception();
        }

        public Konto GetKontoInhaber(string kontoNr)
        {
            var konto = Konten.Find(k => k.KontoNr.Equals(kontoNr));
            if (konto != null) return konto;
            throw new Exception();
        }
    }
}
