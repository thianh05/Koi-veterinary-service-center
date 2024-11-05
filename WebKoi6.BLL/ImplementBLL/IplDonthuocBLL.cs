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
    public class IplDonthuocBLL : IDonthuocBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplDonthuocBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.donthuocRepository.Delete(Id);
                _baseDAL.donthuocRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Donthuoc> GetAll()
        {
            return _baseDAL.donthuocRepository.Get().ToList();
        }

        public Donthuoc GetById(int Id)
        {
            try
            {
                var data = _baseDAL.donthuocRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Donthuoc> GetByLichHenId(int lichHenId)
        {
            var data = new List<Donthuoc>();
            try
            {
                data = _baseDAL.donthuocRepository.Get(x => x.LichhenId == lichHenId).ToList();
            }
            catch (Exception ex)
            {

            }
            return data;
        }

        public bool Insert(Donthuoc model)
        {
            try
            {
                _baseDAL.donthuocRepository.Insert(model);
                _baseDAL.donthuocRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Donthuoc model)
        {
            try
            {
                _baseDAL.donthuocRepository.Update(model);
                _baseDAL.donthuocRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
