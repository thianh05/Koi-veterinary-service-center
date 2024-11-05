using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplKhachhangBLL : IKhachhangBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplKhachhangBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public Khachhang CheckExistsKhachhang(string keywork, int Id)
        {
            try
            {
                var data = _baseDAL.khachhangRepository.Get(x => (x.SoDienThoai.Trim().Equals(keywork.Trim()) || x.Email.ToLower().Trim().Equals(keywork.ToLower().Trim())) && x.Id != Id).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.khachhangRepository.Delete(Id);
                _baseDAL.khachhangRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Khachhang> GetAll()
        {
            return _baseDAL.khachhangRepository.Get().ToList();
        }

        public Khachhang GetById(int Id)
        {
            return _baseDAL.khachhangRepository.GetById(Id);
        }

        public List<Khachhang> GetListAllPaging(string search, int offset, int limit)
        {
            return _baseDAL.khachhangRepository.GetListAllPaging(search, offset, limit);
        }

        public bool Insert(Khachhang model)
        {
            try
            {
                _baseDAL.khachhangRepository.Insert(model);
                _baseDAL.khachhangRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Khachhang model)
        {
            try
            {
                _baseDAL.khachhangRepository.Update(model);
                _baseDAL.khachhangRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
