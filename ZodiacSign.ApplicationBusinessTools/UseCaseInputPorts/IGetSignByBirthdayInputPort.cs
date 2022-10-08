using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.ApplicationBusinessTools.UseCaseInputPorts
{
    public interface IGetSignByBirthdayInputPort
    {
        Task Handle(DateOnly birthday);
    }
}
