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
    public class IplTintucBLL : ITintucBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplTintucBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }
        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.tintucRepository.Delete(Id);
                _baseDAL.tintucRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Tintuc> GetAll()
        {
            return _baseDAL.tintucRepository.Get().ToList();
        }

        public Tintuc GetById(int Id)
        {
            try
            {
                var data = _baseDAL.tintucRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Tintuc> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _baseDAL.tintucRepository.GetListAllPaging(keywork, offset, limit);
        }

        public bool Insert(Tintuc model)
        {
            try
            {
                _baseDAL.tintucRepository.Insert(model);
                _baseDAL.tintucRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Tintuc model)
        {
            try
            {
                _baseDAL.tintucRepository.Update(model);
                _baseDAL.tintucRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
