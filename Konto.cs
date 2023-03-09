using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsApp.Classes
{
    internal class Konto
    {
        public string id {  get; set; }
        public string KontoInhaber { get; set; }
        public string KontoNr { get; set; }
        public int Kontostand { get; set; }

        public Konto(string kontoNr) 
        {
            KontoNr = kontoNr;
            Kontostand = 0;
        }

        public Konto(string kontoInhaber, string kontoNr,int kontoStand)
        {
            KontoNr = kontoNr;
            Kontostand = kontoStand;
            KontoInhaber = kontoInhaber;
        }
        public Konto()
        {
            
        }

        public DataTable ShowAllKontaktdaten()
        {
            DataTable dt = DataBankZugriff.ExecuteDataTable("spKonten",
                new SqlParameter("@auswahl", "viewAllKonten"));
            return dt;
        }

        public DataTable ShowRecord(string id)
        {
            DataTable dt = DataBankZugriff.ExecuteDataTable("spKonten",
                new SqlParameter("@auswahl", "viewOnePerson"),
                new SqlParameter("@id", id));
            return dt;
        }
    }
}
