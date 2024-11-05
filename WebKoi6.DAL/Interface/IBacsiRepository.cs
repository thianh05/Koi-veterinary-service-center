using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Base;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL.Interface
{
    public interface IBacsiRepository : IGenericRepository<Bacsi>
    {
        List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
    }
}
