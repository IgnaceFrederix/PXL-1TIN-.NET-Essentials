using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footballlibrary.Domainclass
{
    class team
        
    {
        [Key]
        public int TeamID { get; set; }
        public string Name { get; set; }

        public virtual List<Class1> Player  { get; set; }

       


    }

   
}
