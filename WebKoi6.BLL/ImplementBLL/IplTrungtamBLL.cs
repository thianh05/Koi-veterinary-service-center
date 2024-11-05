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
    public class IplTrungtamBLL : ITrungtamBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplTrungtamBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.trungtamRepository.Delete(Id);
                _baseDAL.trungtamRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Trungtam> GetAll(string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return _baseDAL.trungtamRepository.Get(x => x.TenTrungTam.ToLower().Trim().Equals(search.ToLower().Trim())).ToList();
            }
            else
            {
                return _baseDAL.trungtamRepository.Get().ToList();

            }
        }

        public Trungtam GetById(int Id)
        {
            try
            {
                var data = _baseDAL.trungtamRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Trungtam> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _baseDAL.trungtamRepository.GetListAllPaging(keywork, offset, limit);
        }

        public Trungtam GetObjTrungTam()
        {
            var data = _baseDAL.trungtamRepository.Get().OrderByDescending(x => x.Id).FirstOrDefault();
            return data;
        }

        public bool Insert(Trungtam model)
        {
            try
            {
                _baseDAL.trungtamRepository.Insert(model);
                _baseDAL.trungtamRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Trungtam model)
        {
            try
            {
                _baseDAL.trungtamRepository.Update(model);
                _baseDAL.trungtamRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
