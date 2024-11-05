using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Implement;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplBacsiBLL : IBacsiBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplBacsiBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.bacsiRepository.Delete(Id);
                _baseDAL.bacsiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Bacsi> GetAll(string search = null)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return _baseDAL.bacsiRepository.Get(x => x.Email.ToLower().Trim().Equals(search.ToLower().Trim())).ToList();
            }
            else
            {
                return _baseDAL.bacsiRepository.Get().ToList();

            }
        }

        public Bacsi GetById(int Id)
        {
            try
            {
                var data = _baseDAL.bacsiRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            return _baseDAL.bacsiRepository.GetListAllPaging(keywork, offset, limit);
        }

        public bool Insert(Bacsi bacsi)
        {
            try
            {
                _baseDAL.bacsiRepository.Insert(bacsi);
                _baseDAL.bacsiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Bacsi bacsi)
        {
            try
            {
                _baseDAL.bacsiRepository.Update(bacsi);
                _baseDAL.bacsiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
