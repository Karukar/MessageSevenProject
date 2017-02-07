using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSevenProject.Service_Clients.Interface
{
    public interface IReportWriter
    {
        void ExportToExcel(string path);
    }
}
