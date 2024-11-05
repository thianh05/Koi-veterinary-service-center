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
    public class IplChuandoanbenhcakoiBLL : IChuandoanbenhcakoiBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplChuandoanbenhcakoiBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.chuandoanbenhcakoiRepository.Delete(Id);
                _baseDAL.chuandoanbenhcakoiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Chuandoanbenhcakoi> GetAll()
        {
            return _baseDAL.chuandoanbenhcakoiRepository.Get().ToList();
        }

        public Chuandoanbenhcakoi GetById(int Id)
        {
            try
            {
                var data = _baseDAL.chuandoanbenhcakoiRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Chuandoanbenhcakoi> GetByLichHen(int lichhenId)
        {
            var data = new List<Chuandoanbenhcakoi>();
            try
            {
                data = _baseDAL.chuandoanbenhcakoiRepository.Get(x => x.LichhenId == lichhenId).ToList();
            }
            catch (Exception ex)
            {
            }
            return data;
        }

        public bool Insert(Chuandoanbenhcakoi model)
        {
            try
            {
                _baseDAL.chuandoanbenhcakoiRepository.Insert(model);
                _baseDAL.chuandoanbenhcakoiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Chuandoanbenhcakoi model)
        {
            try
            {
                _baseDAL.chuandoanbenhcakoiRepository.Update(model);
                _baseDAL.chuandoanbenhcakoiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
