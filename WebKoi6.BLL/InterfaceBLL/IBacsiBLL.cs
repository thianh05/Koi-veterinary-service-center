using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IBacsiBLL
    {
        List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
        List<Bacsi> GetAll(string search = null);
        bool Insert(Bacsi bacsi);
        bool Update(Bacsi bacsi); 
        bool Delete(int Id);
        Bacsi GetById(int Id);
    }
}
