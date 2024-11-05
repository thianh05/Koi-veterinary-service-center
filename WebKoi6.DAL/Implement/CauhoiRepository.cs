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
    public class CauhoiRepository : GenericRepository<Faq>, ICauhoiRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public CauhoiRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Faq> GetAllPaging(string search, int offset, int limit)
        {
            try
            {
                var dbCauhoi = _dbContext.Faqs.AsQueryable();
                int totalRow = (from b in dbCauhoi
                                where ((string.IsNullOrEmpty(search)
                                || b.CauHoi.ToLower().Trim().Contains(search.ToLower().Trim()))
                                || b.CauTraLoi.ToLower().Trim().Contains(search.ToLower().Trim()))
                                select b).Count();
                var data = (from b in dbCauhoi
                            where ((string.IsNullOrEmpty(search)
                               || b.CauHoi.ToLower().Trim().Contains(search.ToLower().Trim()))
                               || b.CauTraLoi.ToLower().Trim().Contains(search.ToLower().Trim()))
                            select new Faq
                            {
                                Faqid = b.Faqid,
                                CauTraLoi = b.CauTraLoi,
                                CauHoi = b.CauHoi,
                                TotalRows = totalRow,
                            }).OrderByDescending(x => x.Faqid).Skip(offset).Take(limit).ToList();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
