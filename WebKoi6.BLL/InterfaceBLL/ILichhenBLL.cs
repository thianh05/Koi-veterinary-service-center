using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface ILichhenBLL
    {
        List<LichhenMapping> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
        bool Insert(Lichhen model);
        bool Update(Lichhen model);
        bool Delete(int Id);
        Lichhen GetById(int Id);
        List<Lichhen> GetLichHenByDate(DateTime date);
    }
}
