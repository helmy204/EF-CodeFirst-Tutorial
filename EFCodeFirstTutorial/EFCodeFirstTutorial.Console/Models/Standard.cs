using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstTutorial.Console.Models
{
    public class Standard
    {
        public Standard()
        {

        }

        public int StandardId { get; set; }
        public string StandardName { get; set; }

        // Collection navigation property
        public ICollection<Student> Students { get; set; }
    }
}
