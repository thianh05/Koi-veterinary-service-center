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
    public class IplLichhenRepository : GenericRepository<Lichhen>, ILichhenRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public IplLichhenRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }
        public List<LichhenMapping> GetListAllPaging(string keywork, int offset, int limit)
        {
            try
            {
                var dbLichhen = _dbContext.Lichhens.AsQueryable();
                var dbKhachhang = _dbContext.Khachhangs.AsQueryable();
                var dbBacsi = _dbContext.Bacsis.AsQueryable();
                var dbDichvu = _dbContext.Dichvuthuys.AsQueryable();
                int totalRows = (from l in dbLichhen
                                 join k in dbKhachhang on l.KhachhangId equals k.Id
                                 join b in dbBacsi on l.BacsiId equals b.Id into joinBacsi
                                 from b in joinBacsi.DefaultIfEmpty()
                                 join d in dbDichvu on l.DichVuId equals d.MaDichVu
                                 where (string.IsNullOrEmpty(keywork)
                                 || (k.TenKhachHang.ToLower().Trim().Contains(keywork.ToLower().Trim()))
                                 || (k.SoDienThoai.Trim().Contains(keywork.ToLower().Trim()))
                                 || (b.TenBacSi.Trim().ToLower().Contains(keywork.ToLower().Trim()))
                                 || d.TenDichVu.ToLower().Trim().Contains(keywork.ToLower().Trim()))
                                 select l).Count();
                var data = (from l in dbLichhen
                            join k in dbKhachhang on l.KhachhangId equals k.Id
                            join b in dbBacsi on l.BacsiId equals b.Id into joinBacsi
                            from b in joinBacsi.DefaultIfEmpty()
                            join d in dbDichvu on l.DichVuId equals d.MaDichVu
                            where (string.IsNullOrEmpty(keywork)
                            || (k.TenKhachHang.ToLower().Trim().Contains(keywork.ToLower().Trim()))
                            || (k.SoDienThoai.Trim().Contains(keywork.ToLower().Trim()))
                            || (b.TenBacSi.Trim().ToLower().Contains(keywork.ToLower().Trim()))
                            || d.TenDichVu.ToLower().Trim().Contains(keywork.ToLower().Trim()))
                            select new LichhenMapping
                            {
                                Id = l.Id,
                                KhachhangId = l.KhachhangId,
                                DichVuId = l.DichVuId,
                                BacsiId = l.BacsiId,
                                Ngayhen = l.Ngayhen,
                                Trangthai = l.Trangthai,
                                TenKhachHang = k.TenKhachHang,
                                Sodienthoai = k.SoDienThoai,
                                Email = k.Email,
                                TenBacSi = b.TenBacSi,
                                TenDichVu = d.TenDichVu,
                                TotalRows = totalRows,
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
