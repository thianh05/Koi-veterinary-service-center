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
    public class FeebackRepository : GenericRepository<Feedback>, IFeebackRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public FeebackRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Feedback> GetFeebackListAllPaging(string search, int offset, int limit)
        {
            try
            {
                var dbFeeback = _dbContext.Feedbacks.AsQueryable();
                int total = (from f in dbFeeback
                             where(string.IsNullOrEmpty(search)
                             || (f.TenKhachHang != null ? f.TenKhachHang.ToLower().Trim().Contains(search.ToLower().Trim()) : (1 == 1))
                             || (f.DanhGia != null ? f.DanhGia.ToLower().Trim().Contains(search.ToLower().Trim()) : (1 == 1))
                             || (f.Email != null ? f.Email.ToLower().Trim().Contains(search.ToLower().Trim()) : (1 == 1)))
                             select f).Count();
                var data = (from f in dbFeeback
                            where (string.IsNullOrEmpty(search)
                            || (f.TenKhachHang != null ? f.TenKhachHang.ToLower().Trim().Contains(search.ToLower().Trim()) : (1 == 1))
                            || (f.DanhGia != null ? f.DanhGia.ToLower().Trim().Contains(search.ToLower().Trim()) : (1 == 1))
                            || (f.Email != null ? f.Email.ToLower().Trim().Contains(search.ToLower().Trim()) : (1 == 1)))
                            select new Feedback
                            {
                                FeedbackId = f.FeedbackId,
                                TenKhachHang = f.TenKhachHang,
                                Email = f.Email,
                                DanhGia = f.DanhGia,
                                BinhLuan = f.BinhLuan,
                                NgayPhanHoi = f.NgayPhanHoi,
                                TotalRows = f.TotalRows,
                            }).OrderBy(x => x.FeedbackId).Skip(offset).Take(limit).ToList();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
