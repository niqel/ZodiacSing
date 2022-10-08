using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.AppBusiness.UseCases
{
    public interface IPresenter
    {
        IGetAllSigns GetAllSigns { get; }
        IGetSignByBirthday GetSignByBirthday { get; }
    }
}
