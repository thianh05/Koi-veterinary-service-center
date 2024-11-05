using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IDonthuocBLL
    {
        List<Donthuoc> GetAll();
        bool Insert(Donthuoc model);
        bool Update(Donthuoc model);
        bool Delete(int Id);
        Donthuoc GetById(int Id);
        List<Donthuoc> GetByLichHenId(int lichHenId);
    }
}
