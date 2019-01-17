using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
  public static  class Db
    {
        public static List<Workers> MyWorkers = new List<Workers>()
        {
            new Workers("Fazil","Memmedov","FAzil@com",1600,9,Convert.ToDateTime("12-12-2019")),
             new Workers("akif","Memmedov","Fwil@com",1500,9,Convert.ToDateTime("12-12-2019")),
             new Workers("naiq","Memmedov","FAzl@com",1700,9,Convert.ToDateTime("11-12-2019")),
             new Workers("qasim","Memmedov","Fzil@com",1500,9,Convert.ToDateTime("11-12-2019"))
        };

        public static List<Workers> OtradanYuxari = new List<Workers>();
    }
}
