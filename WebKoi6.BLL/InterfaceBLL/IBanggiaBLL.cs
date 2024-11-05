using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.DAL.Models;

namespace WebKoi6.BLL.InterfaceBLL
{
    public interface IBanggiaBLL
    {
        List<Banggia> GetListAllPaging(int dichvuId, int offset, int limit);
        bool Insert(Banggia model);
        bool Update(Banggia model);
        bool Delete(int Id);
        Banggia GetById(int Id);
        Banggia GetBangGiaByDichVuId(int madichvu, int id);
    }
}
