using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.AppBusiness.DTOs;

namespace ZodiacSign.ApplicationBusinessTools.UseCaseInputPorts
{
    public interface IGetAllsignsInputPort
    {
        Task Handle();
    }
}
