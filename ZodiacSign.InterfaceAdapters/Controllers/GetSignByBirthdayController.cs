using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.AppBusiness.DTOs;
using ZodiacSign.ApplicationBusinessTools.UseCaseInputPorts;
using ZodiacSign.ApplicationBusinessTools.UseCaseOutputPorts;
using ZodiacSign.InterfaceAdapters.Presenters.PresenterBase;

namespace ZodiacSign.InterfaceAdapters.Controllers
{
    public class GetSignByBirthdayController
    {
        private IPresenter<SignDTO> presenter;
        private IGetSignByBirthdayInputPort getAllsignsInputPort;

        public GetSignByBirthdayController(IPresenter<SignDTO> presenter, IGetAllSignsOutputPort getAllSignsOutputPort, IGetSignByBirthdayInputPort getSignByBirthdayInputPort)
        {
            this.presenter = presenter;
            this.getAllsignsInputPort = getSignByBirthdayInputPort;
        }

        public async Task<SignDTO> GetByBirthday(DateOnly birthday)
        {
            await this.getAllsignsInputPort.Handle(birthday);
            return presenter;
        }
    }
}
