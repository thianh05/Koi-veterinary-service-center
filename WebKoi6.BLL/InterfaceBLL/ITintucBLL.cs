using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface ITintucBLL
    {
        List<Tintuc> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10);
        bool Insert(Tintuc model);
        bool Update(Tintuc model);
        bool Delete(int Id);
        Tintuc GetById(int Id);
        List<Tintuc> GetAll();
    }
}
