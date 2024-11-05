using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IDichvuthuyBLL
    {
        List<Dichvuthuy> GetDichvuthuyListAll(string search, int offset, int limit);
        Dichvuthuy GetById(int Id);
        bool Insert(Dichvuthuy model);
        bool Update(Dichvuthuy model);
        bool Delete(int Id);
        Dichvuthuy CheckExistsDichVu(string keyword, int Id);
        List<Dichvuthuy> GetAll();
    }
}
