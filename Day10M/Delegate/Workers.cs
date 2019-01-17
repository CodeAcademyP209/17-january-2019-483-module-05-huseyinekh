using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
   
   public class Workers
    {
        public static int Id = 1;


        public Workers(string name, string surname, string email, int maas, int issSaati,DateTime workingDate)
        {
            WorkerId = Id; 
            Name = name;
            Surname = surname;
            Email = email;
            Maas = maas;
            Saat = issSaati;
            Regdate = DateTime.Now;
            WorkingDate = workingDate;
            Id++;

        }


        public int WorkerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Maas { get; set; }
        public int Saat { get; set; }
        public DateTime Regdate { get; set; }
        public DateTime WorkingDate { get; set; }


    }
}
