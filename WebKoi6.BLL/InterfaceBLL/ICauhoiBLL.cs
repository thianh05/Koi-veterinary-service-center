using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface ICauhoiBLL
    {
        List<Faq> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
        List<Faq> GetAll(string search = null);
        bool Insert(Faq model);
        bool Update(Faq model);
        bool Delete(int Id);
        Faq GetById(int Id);
    }
}
