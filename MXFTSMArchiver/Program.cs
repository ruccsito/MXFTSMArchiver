using MXFTSMArchiver.TSMArchiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXFTSMArchiver
{
    class Program
    {
        static void Main(string[] args)
        {
            TSMarchiverClient cl = new TSMarchiverClient();

            try
            {
                cl.doRetreiveProject(32871, "2017-10-25 01:00:00", 1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}