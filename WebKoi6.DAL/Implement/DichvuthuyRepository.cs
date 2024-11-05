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
    public class DichvuthuyRepository : GenericRepository<Dichvuthuy>, IDichvuthuy
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public DichvuthuyRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Dichvuthuy> GetLisAllPaging(string search, int offset, int limit)
        {
            try
            {
                var dbDichvu = _dbContext.Dichvuthuys.AsQueryable();
                int totalRow = (from b in dbDichvu
                                where ((string.IsNullOrEmpty(search)
                                || b.TenDichVu.ToLower().Trim().Contains(search.ToLower().Trim())))
                                select b).Count();
                var data = (from b in dbDichvu
                            where ((string.IsNullOrEmpty(search)
                            || b.TenDichVu.ToLower().Trim().Contains(search.ToLower().Trim())))
                            select new Dichvuthuy
                            {
                                MaDichVu = b.MaDichVu,
                                TenDichVu = b.TenDichVu,
                                MoTa = b.MoTa,
                                TotalRows = totalRow,
                            }).OrderByDescending(x => x.MaDichVu).Skip(offset).Take(limit).ToList();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
