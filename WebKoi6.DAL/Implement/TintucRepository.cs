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
    public class TintucRepository : GenericRepository<Tintuc>, ITintucRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public TintucRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }
        public List<Tintuc> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            try
            {
                var dbTintuc = _dbContext.Tintucs.AsQueryable();
                int totalRow = (from b in dbTintuc
                                where ((string.IsNullOrEmpty(keywork)
                                || b.TieuDe.ToLower().Trim().Contains(keywork.ToLower().Trim())
                                || b.TacGia.ToLower().Trim().ToLower().Contains(keywork.ToLower().Trim())))
                                select b).Count();
                var data = (from b in dbTintuc
                            where ((string.IsNullOrEmpty(keywork)
                            || b.TieuDe.ToLower().Trim().Contains(keywork.ToLower().Trim())
                            || b.TacGia.ToLower().Trim().ToLower().Contains(keywork.ToLower().Trim())))
                            select new Tintuc
                            {
                                MaTinTuc = b.MaTinTuc,
                                TieuDe = b.TieuDe,
                                NoiDung = b.NoiDung,
                                NgayDang = b.NgayDang,
                                TacGia = b.TacGia,
                                Hinhanh = b.Hinhanh,
                                TotalRows = totalRow,
                            }).OrderByDescending(x => x.MaTinTuc).Skip(offset).Take(limit).ToList();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
