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
    public class IplBanggiaBLL : IBanggiaBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplBanggiaBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.banggiaRepository.Delete(Id);
                _baseDAL.banggiaRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Banggia GetBangGiaByDichVuId(int madichvu, int id)
        {
            try
            {
                var data = _baseDAL.banggiaRepository.Get(x => x.MaDichVu == madichvu && x.Id != id).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Banggia GetById(int Id)
        {
            try
            {
                var data = _baseDAL.banggiaRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Banggia> GetListAllPaging(int dichvuId, int offset, int limit)
        {
            return _baseDAL.banggiaRepository.GetListAllPaging(dichvuId, offset, limit);
        }

        public bool Insert(Banggia model)
        {
            try
            {
                _baseDAL.banggiaRepository.Insert(model);
                _baseDAL.banggiaRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Banggia model)
        {
            try
            {
                _baseDAL.banggiaRepository.Update(model);
                _baseDAL.banggiaRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
