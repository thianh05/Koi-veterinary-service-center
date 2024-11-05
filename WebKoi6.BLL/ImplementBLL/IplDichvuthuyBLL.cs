using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplDichvuthuyBLL : IDichvuthuyBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplDichvuthuyBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public Dichvuthuy CheckExistsDichVu(string keyword, int Id)
        {
            try
            {
                var data = _baseDAL.dichvuthuyRepository.Get(x => x.TenDichVu.ToLower().Trim().Equals(keyword.ToLower().Trim()) && x.MaDichVu != Id).FirstOrDefault();
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
                _baseDAL.dichvuthuyRepository.Delete(Id);
                _baseDAL.dichvuthuyRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Dichvuthuy> GetAll()
        {
            return _baseDAL.dichvuthuyRepository.Get().ToList();
        }

        public Dichvuthuy GetById(int Id)
        {
            try
            {
                var data = _baseDAL.dichvuthuyRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Dichvuthuy> GetDichvuthuyListAll(string search, int offset, int limit)
        {
            return _baseDAL.dichvuthuyRepository.GetLisAllPaging(search, offset, limit);
        }

        public bool Insert(Dichvuthuy model)
        {
            try
            {
                _baseDAL.dichvuthuyRepository.Insert(model);
                _baseDAL.dichvuthuyRepository.SaveChange();
                return true;    
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Dichvuthuy model)
        {
            try
            {
                _baseDAL.dichvuthuyRepository.Update(model);
                _baseDAL.dichvuthuyRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
