using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Resume_Napawan.Models.ProjectNapawanContext;

namespace Resume_Napawan.Models
{
    public class Project
    {
        private Resume_NapawanContext context;
        public int ID { get; set; }

        public string NameProject { get; set; }

        public string Details { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdate { get; set; }
    }
}
