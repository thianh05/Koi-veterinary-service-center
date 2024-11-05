using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IFeebackBLL
    {
        List<Feedback> GetFeedbackListAllPaging(string search, int offset, int limit);
        bool Insert(Feedback model);
    }
}
