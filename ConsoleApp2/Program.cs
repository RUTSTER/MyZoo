using System;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        private static MainForm mainForm = new MainForm();
        private static Zoo zoo = new Zoo();

        static void Main(string[] args)
        {
            mainForm.SetReference(zoo);
            zoo.SetReference(mainForm);       

            Application.Run(mainForm);            
        }
    }
}
