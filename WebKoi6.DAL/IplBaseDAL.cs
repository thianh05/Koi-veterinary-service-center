using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Implement;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;

namespace WebKoi6.DAL
{
    public class IplBaseDAL : IBaseDAL
    {
        private KvscContext _dbContext;
        public IConfiguration _configuration { get; }
        public IplBaseDAL(KvscContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }
        private IBacsiRepository _bacsiRepository;
        public IBacsiRepository bacsiRepository
        {
            get
            {
                return _bacsiRepository ?? (_bacsiRepository = new BacsiRepository(_dbContext, _configuration));
            }
        }
        private ITaikhoanRepository _taikhoanRepository;
        public ITaikhoanRepository taikhoanRepository
        {
            get
            {
                return _taikhoanRepository ?? (_taikhoanRepository = new TaikhoanRepository(_dbContext, _configuration));
            }
        }
        private IDichvuthuy _dichvuthuyRepository;
        public IDichvuthuy dichvuthuyRepository
        {
            get
            {
                return _dichvuthuyRepository ?? (_dichvuthuyRepository = new DichvuthuyRepository(_dbContext, _configuration));
            }
        }
        private IKhachhang _khachhangRepository;
        public IKhachhang khachhangRepository
        {
            get
            {
                return _khachhangRepository ?? (_khachhangRepository = new KhachhangRepository(_dbContext, _configuration));
            }
        }
        private IFeebackRepository _feebackRepository;
        public IFeebackRepository feebackRepository
        {
            get
            {
                return _feebackRepository ?? (_feebackRepository = new FeebackRepository(_dbContext, _configuration));
            }
        }
        private IBanggiaRepository _banggiaRepository;
        public IBanggiaRepository banggiaRepository
        {
            get
            {
                return _banggiaRepository ?? (_banggiaRepository = new BanggiaRepository(_dbContext, _configuration));
            }
        }
        private ICauhoiRepository _cauhoiRepository;
        public ICauhoiRepository cauhoiRepository
        {
            get
            {
                return _cauhoiRepository ?? (_cauhoiRepository = new CauhoiRepository(_dbContext, _configuration));
            }
        }
        private ITrungtamRepository _trungtamRepository;
        public ITrungtamRepository trungtamRepository
        {
            get
            {
                return _trungtamRepository ?? (_trungtamRepository = new TrungtamRepository(_dbContext, _configuration));
            }
        }
        private ILichhenRepository _lichhenRepository;
        public ILichhenRepository lichhenRepository
        {
            get
            {
                return _lichhenRepository ?? (_lichhenRepository = new IplLichhenRepository(_dbContext, _configuration));
            }
        }
        private IChuandoanbenhcakoiRepository _chuandoanbenhcakoiRepository;
        public IChuandoanbenhcakoiRepository chuandoanbenhcakoiRepository
        {
            get
            {
                return _chuandoanbenhcakoiRepository ?? (_chuandoanbenhcakoiRepository = new ChuandoanbenhcakoiRepository(_dbContext, _configuration));
            }
        }
        private IChuandoantinhtrangnuocRepository _chuandoantinhtrangnuocRepository;
        public IChuandoantinhtrangnuocRepository chuandoantinhtrangnuocRepository
        {
            get
            {
                return _chuandoantinhtrangnuocRepository ?? (_chuandoantinhtrangnuocRepository = new ChuandoantinhtrangnuocRepository(_dbContext, _configuration));
            }
        }
        private IDonthuocRepository _donthuocRepository;
        public IDonthuocRepository donthuocRepository
        {
            get
            {
                return _donthuocRepository ?? (_donthuocRepository = new DonthuocRepository(_dbContext, _configuration));
            }
        }
        private ITintucRepository _tintucRepository;
        public ITintucRepository tintucRepository
        {
            get
            {
                return _tintucRepository ?? (_tintucRepository = new TintucRepository(_dbContext, _configuration));
            }
        }
    }
}
