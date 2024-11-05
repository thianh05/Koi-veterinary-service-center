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
    public class TaikhoanRepository : GenericRepository<Taikhoan>, ITaikhoanRepository
    {
        public IConfiguration _configuration { get; }
        internal string _cnnString = string.Empty;
        public KvscContext _dbContext;
        public TaikhoanRepository(KvscContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _cnnString = _configuration.GetConnectionString("DefaultConnection");
        }

        public Taikhoan CheckLogin(string username, string password)
        {
            try
            {
                var data = _dbContext.Taikhoans.Where(x => x.Username.ToLower().Trim().Equals(username.ToLower().Trim()) && x.Password.Trim().Equals(password.Trim())).FirstOrDefault();
                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
