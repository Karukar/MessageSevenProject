using MessageSevenProject.Model;
using System.Collections.Generic;

namespace MessageSevenProject.Service_Clients.Interface
{
    public interface IMessageSevenService
    {
        IEnumerable<Message> GeAllData();
        IEnumerable<Message> FindData(string attrib, string operat, string value);
    }
}
