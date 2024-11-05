using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class BanggiaRepository : GenericRepository<Banggia>, IBanggiaRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public BanggiaRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public List<Banggia> GetListAllPaging(int dichVuId, int offset, int limit)
        {
            try
            {
                var dbBanggia = _dbContext.Banggias.AsQueryable();
                var dbDichvu = _dbContext.Dichvuthuys.AsQueryable();
                int total = (from b in dbBanggia
                             join d in dbDichvu on b.MaDichVu equals d.MaDichVu
                             where (dichVuId == 0 || b.MaDichVu == dichVuId)
                             select b).Count();
                var data = (from b in dbBanggia
                            join d in dbDichvu on b.MaDichVu equals d.MaDichVu
                            where (dichVuId == 0 || b.MaDichVu == dichVuId)
                            select new Banggia
                            {
                                Id = b.Id,
                                MaDichVu = b.MaDichVu,
                                Gia = b.Gia,
                                TenDichVu = d.TenDichVu,
                                TotalRows = total,
                                Phidichuyen = b.Phidichuyen,
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
