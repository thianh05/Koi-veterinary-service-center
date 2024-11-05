using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IChuandoantinhtrangnuocBLL
    {
        List<Chuandoantinhtrangnuoc> GetAll();
        bool Insert(Chuandoantinhtrangnuoc model);
        bool Update(Chuandoantinhtrangnuoc model);
        bool Delete(int Id);
        Chuandoantinhtrangnuoc GetById(int Id);
        List<Chuandoantinhtrangnuoc> GetByLichHenId(int lichHenId);
    }
}
