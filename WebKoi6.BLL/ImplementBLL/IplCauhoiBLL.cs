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
    public class IplCauhoiBLL : ICauhoiBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplCauhoiBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.cauhoiRepository.Delete(Id);
                _baseDAL.cauhoiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Faq> GetAll(string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return _baseDAL.cauhoiRepository.Get(x => x.CauHoi.ToLower().Trim().Equals(search.ToLower().Trim())).ToList();
            }
            else
            {
                return _baseDAL.cauhoiRepository.Get().ToList();

            }
        }

        public Faq GetById(int Id)
        {
            try
            {
                var data = _baseDAL.cauhoiRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Faq> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _baseDAL.cauhoiRepository.GetAllPaging(keywork, offset, limit);
        }

        public bool Insert(Faq model)
        {
            try
            {
                _baseDAL.cauhoiRepository.Insert(model);
                _baseDAL.cauhoiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Faq model)
        {
            try
            {
                _baseDAL.cauhoiRepository.Update(model);
                _baseDAL.cauhoiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
