using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface ITaiKhoanBLL
    {
        Taikhoan CheckLogin(string userName, string password);
        bool Insert(Taikhoan model);
        List<Taikhoan> GetTaikhoans(string keyword);
        bool Update(Taikhoan model);
        bool Delete(int Id);
        Taikhoan GeyById(int Id);
    }
}
