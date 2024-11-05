using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IKhachhangBLL
    {
        List<Khachhang> GetListAllPaging(string search, int offset, int limit);
        Khachhang GetById(int Id);
        bool Insert(Khachhang model);
        bool Update(Khachhang model);
        bool Delete(int Id);
        List<Khachhang> GetAll();
        Khachhang CheckExistsKhachhang(string keywork, int Id);
    }
}
