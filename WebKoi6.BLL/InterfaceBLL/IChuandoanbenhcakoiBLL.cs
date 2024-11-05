using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IChuandoanbenhcakoiBLL
    {
        List<Chuandoanbenhcakoi> GetAll();
        bool Insert(Chuandoanbenhcakoi model);
        bool Update(Chuandoanbenhcakoi model);
        bool Delete(int Id);
        Chuandoanbenhcakoi GetById(int Id);
        List<Chuandoanbenhcakoi> GetByLichHen(int lichhenId);
    }
}
