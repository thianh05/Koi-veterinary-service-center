using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Base;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL.Interface
{
    public interface ITintucRepository : IGenericRepository<Tintuc>
    {
        List<Tintuc> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
    }
}
