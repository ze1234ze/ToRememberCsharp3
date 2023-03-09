using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyFormsApp.Classes
{
    internal class WriteToFile
    {
        public void WriteFile()
        {
            string data;
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader("C:\\Workspace\\Projects\\MyFormsApp\\MyFormsApp\\Konto.txt");
                writer = new StreamWriter("C:\\Workspace\\Projects\\MyFormsApp\\MyFormsApp\\Konto.txt");
                data = reader.ReadLine();

                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }
                reader.Close();
                writer.WriteLine(@"Hallo there!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                writer.Close();
            }
        }


        //private void SaveAndReadFileButtonClick(object sender, EventArgs e)
        //{
        //    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Login\\" + etwas.Text + " " + vent.Text + ".txt");
        //    sw.WriteLine(lblwas.Text + " " + FirstNameTb.Text);

        //    StreamReader sr = new StreamReader(Application.StartupPath + "\\Login\\" + etwas.Text + " " + vent.Text + ".txt");
        //    textFileld.Text = sr.ReadToEnd() + "From text file";

        //    sr.Close();
        //}
    }
}
