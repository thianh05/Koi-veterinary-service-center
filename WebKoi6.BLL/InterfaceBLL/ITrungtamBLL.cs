using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface ITrungtamBLL
    {
        List<Trungtam> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
        List<Trungtam> GetAll(string search = null);
        Trungtam GetObjTrungTam();
        bool Insert(Trungtam model);
        bool Update(Trungtam model);
        bool Delete(int Id);
        Trungtam GetById(int Id);
    }
}
