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
    public class TrungtamRepository : GenericRepository<Trungtam>, ITrungtamRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public TrungtamRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Trungtam> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            try
            {
                var dbTrungtam = _dbContext.Trungtams.AsQueryable();
                int totalRow = (from b in dbTrungtam
                                where ((string.IsNullOrEmpty(keywork)
                                || b.TenTrungTam.ToLower().Trim().Contains(keywork.ToLower().Trim())
                                || b.Hotline.Trim().Contains(keywork.Trim())))
                                select b).Count();
                var data = (from b in dbTrungtam
                            where ((string.IsNullOrEmpty(keywork)
                            || b.TenTrungTam.ToLower().Trim().Contains(keywork.ToLower().Trim())
                            || b.Hotline.Trim().Contains(keywork.Trim())))
                            select new Trungtam
                            {
                                Id = b.Id,
                                TenTrungTam = b.TenTrungTam,
                                DiaChi = b.DiaChi,
                                Hotline = b.Hotline,
                                MoTa = b.MoTa,
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
