using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.TsmArchiver;

namespace Web
{
    public class TsmService
    {
        private string startDate;
        private TSMarchiverClient cl;

        public TsmService()
        {
            cl = new TSMarchiverClient();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            dt = dt.AddHours(-6);
            startDate = dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string Retrieve(int projectId)
        {             
            try
            {
                cl.doRetreiveProject(projectId, startDate, 1);
                return "Sumbmitted ok!";
            }
            catch (Exception)
            {
                return "Unable to submit. Please contact your Minion admin :( ";                
            }            
        }

        public string Archive(int projectId)
        {
            try
            {
                cl.doArchiveProject(projectId, startDate, 1, true);
                return "Sumbmitted ok!";
            }
            catch (Exception)
            {
                return "Unable to submit. Please contact your Minion admin :( ";
            }
        }
    }
}