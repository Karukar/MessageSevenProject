using MessageSevenProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSevenProject.Service_Clients.Interface
{
    public interface IMessageSevenService
    {
        IEnumerable<Message> GeAllData();
        IEnumerable<Message> FindData(string Attrib, string Operat, string value);
    }
}
