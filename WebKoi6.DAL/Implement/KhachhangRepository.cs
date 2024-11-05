using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Base;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL.Implement
{
    public class KhachhangRepository : GenericRepository<Khachhang>, IKhachhang
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public KhachhangRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Khachhang> GetListAllPaging(string search, int offset, int limit)
        {
            try
            {
                var dbKhachhang = _dbContext.Khachhangs.AsQueryable();
                int totalRow = (from b in dbKhachhang
                                where ((string.IsNullOrEmpty(search)
                                || b.TenKhachHang.ToLower().Trim().Contains(search.ToLower().Trim())
                                || b.SoDienThoai.ToLower().Trim().Contains(search.ToLower().Trim())
                                || b.Email.ToLower().Trim().Contains(search.ToLower().Trim())))
                                select b).Count();
                var data = (from b in dbKhachhang
                            where ((string.IsNullOrEmpty(search)
                                || b.TenKhachHang.ToLower().Trim().Contains(search.ToLower().Trim())
                                || b.SoDienThoai.ToLower().Trim().Contains(search.ToLower().Trim())
                                || b.Email.ToLower().Trim().Contains(search.ToLower().Trim())))
                            select new Khachhang
                            {
                                Id = b.Id,
                                TenKhachHang = b.TenKhachHang,
                                SoDienThoai = b.SoDienThoai,
                                Email = b.Email,
                                TotalRows = totalRow,
                            }).OrderByDescending(x => x.Id).Skip(offset).Take(limit).ToList();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
