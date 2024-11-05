
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
    public class IplChuandoantinhtrangnuocBLL : IChuandoantinhtrangnuocBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplChuandoantinhtrangnuocBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public bool Delete(int Id)
        {
            try
            {
                _baseDAL.chuandoantinhtrangnuocRepository.Delete(Id);
                _baseDAL.chuandoantinhtrangnuocRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Chuandoantinhtrangnuoc> GetAll()
        {
            return _baseDAL.chuandoantinhtrangnuocRepository.Get().ToList();
        }

        public Chuandoantinhtrangnuoc GetById(int Id)
        {
            try
            {
                var data = _baseDAL.chuandoantinhtrangnuocRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Chuandoantinhtrangnuoc> GetByLichHenId(int lichHenId)
        {
            var data = new List<Chuandoantinhtrangnuoc>();
            try
            {
                data = _baseDAL.chuandoantinhtrangnuocRepository.Get(x => x.LichhenId == lichHenId).ToList();
            }
            catch (Exception)
            {
            }
            return data;
        }

        public bool Insert(Chuandoantinhtrangnuoc model)
        {
            try
            {
                _baseDAL.chuandoantinhtrangnuocRepository.Insert(model);
                _baseDAL.chuandoantinhtrangnuocRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Chuandoantinhtrangnuoc model)
        {
            try
            {
                _baseDAL.chuandoantinhtrangnuocRepository.Update(model);
                _baseDAL.chuandoantinhtrangnuocRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
