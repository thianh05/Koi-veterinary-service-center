using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebKoi6.BLL.ImplementBLL
{
    public class IplTaiKhoanBLL : ITaiKhoanBLL
    {
        private readonly IBaseDAL _baseDAL;
        public IplTaiKhoanBLL(IBaseDAL baseDAL)
        {
            _baseDAL = baseDAL;
        }

        public Taikhoan CheckLogin(string userName, string password)
        {
            return _baseDAL.taikhoanRepository.CheckLogin(userName, password);
        }

        public bool Delete(int Id)
        {
            bool flag = false;
            try
            {
                _baseDAL.taikhoanRepository.Delete(Id);
                _baseDAL.taikhoanRepository.SaveChange();
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return flag;
        }

        public List<Taikhoan> GetTaikhoans(string keyword)
        {
            var data = new List<Taikhoan>();
            try
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    data = _baseDAL.taikhoanRepository.Get(x => x.Username.ToLower().Trim().Contains(keyword.ToLower().Trim()) || x.FullName.Trim().ToLower().Contains(keyword.ToLower().Trim())).ToList();
                }
                else
                {
                    data = _baseDAL.taikhoanRepository.Get().ToList();
                }
            }
            catch (Exception ex)
            {
                
            }
            return data;
        }

        public Taikhoan GeyById(int Id)
        {
            try
            {
                var data = _baseDAL.taikhoanRepository.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Insert(Taikhoan model)
        {
            try
            {
                _baseDAL.taikhoanRepository.Insert(model);
                _baseDAL.bacsiRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Taikhoan model)
        {
            try
            {
                _baseDAL.taikhoanRepository.Update(model);
                _baseDAL.taikhoanRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
