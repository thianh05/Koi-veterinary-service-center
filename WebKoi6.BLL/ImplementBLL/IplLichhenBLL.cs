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
    public class IplLichhenBLL : ILichhenBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplLichhenBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }
        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.lichhenRepository.Delete(Id);
                _baseDAL.lichhenRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Lichhen GetById(int Id)
        {
            try
            {
                var data = _baseDAL.lichhenRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Lichhen> GetLichHenByDate(DateTime date)
        {
            var data = new List<Lichhen>();
            try
            {
                var dbLichhen = _baseDAL.lichhenRepository.Get(x => x.Ngayhen.Value.Date == date.Date).ToList();
                return dbLichhen;
            }
            catch (Exception ex)
            {
               
            }
            return data;
        }

        public List<LichhenMapping> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _baseDAL.lichhenRepository.GetListAllPaging(keywork, offset, limit);
        }

        public bool Insert(Lichhen model)
        {
            try
            {
                _baseDAL.lichhenRepository.Insert(model);
                _baseDAL.lichhenRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Lichhen model)
        {
            try
            {
                _baseDAL.lichhenRepository.Update(model);
                _baseDAL.lichhenRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
