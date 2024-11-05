using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebKoi6.BLL.InterfaceBLL;

namespace WebKoi6.BLL
{
    public interface IBaseBLL
    {
        IBacsiBLL bacsiBLLRepo { get; }
        ITaiKhoanBLL taiKhoanBLL { get; }
        IDichvuthuyBLL dichvuthuyBLL { get; }
        IKhachhangBLL khachhangBLL { get; }
        IFeebackBLL feebackBLL { get; }
        IBanggiaBLL banggiaBLL { get; }
        ICauhoiBLL cauhoiBLL { get; }
        ITrungtamBLL trungtamBLL { get; }
        ILichhenBLL lichhenBLL { get; }
        IChuandoantinhtrangnuocBLL chuandoantinhtrangnuocBLL { get; }
        IChuandoanbenhcakoiBLL chuandoanbenhcakoiBLL { get; }
        IDonthuocBLL donthuocBLL { get; }
        ITintucBLL tintucBLL { get; }
    }
}
