using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.AppBusiness.DTOs;
using ZodiacSign.ApplicationBusinessTools.UseCaseOutputPorts;
using ZodiacSign.InterfaceAdapters.Presenters.PresenterBase;

namespace ZodiacSign.InterfaceAdapters.Presenters
{
    public class GetSignByBirthdayOutputPort : IGetSignByBirthdayOutputPort, IPresenter<SignDTO>
    {
        private SignDTO signDTO;
        public SignDTO Content { get { return this.signDTO; } }

        public GetSignByBirthdayOutputPort()
        {
            this.signDTO = new SignDTO();
        }

        public Task Handle(SignDTO signDTO)
        {
            this.signDTO = signDTO;
            return Task.CompletedTask;
        }
    }
}
