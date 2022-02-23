using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace _13336_egzamin_asp.net_2termin.Models
{
    public class TaskModel
    {
        public int IdTask { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Opis")]
        public string Opis { get; set; }
        public string DataUtworzenia { get; set; }
        public string TerminWykonania { get; set; }
        public  bool JobDone { get; set; }
    }
}
