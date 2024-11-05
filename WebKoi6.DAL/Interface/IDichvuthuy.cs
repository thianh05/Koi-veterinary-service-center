using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Base;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL.Interface
{
    public interface IDichvuthuy : IGenericRepository<Dichvuthuy>
    {
        List<Dichvuthuy> GetLisAllPaging(string search, int offset, int limit);
    }
}
