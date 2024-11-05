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
    public class BacsiRepository : GenericRepository<Bacsi>, IBacsiRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public BacsiRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Bacsi> GetListAllPaging(string keywork = null, int offset = 0, int limit = 10)
        {
            try
            {
                var dbBacsi = _dbContext.Bacsis.AsQueryable();
                int totalRow = (from b in dbBacsi
                                where ((string.IsNullOrEmpty(keywork)
                                || b.TenBacSi.ToLower().Trim().Contains(keywork.ToLower().Trim())))
                                select b).Count();
                var data = (from b in dbBacsi
                           where((string.IsNullOrEmpty(keywork) 
                           || b.TenBacSi.ToLower().Trim().Contains(keywork.ToLower().Trim())))
                           select new Bacsi
                           {
                                Id = b.Id,
                                TenBacSi = b.TenBacSi,
                                KinhNghiem = b.KinhNghiem,
                                Email = b.Email,
                                Availability = b.Availability,
                                TotalRows = totalRow,
                                Noidung = b.Noidung,
                                Sodienthoai = b.Sodienthoai,
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
