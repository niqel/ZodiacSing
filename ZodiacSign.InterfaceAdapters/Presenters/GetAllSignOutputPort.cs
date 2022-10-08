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
    public class GetAllSignOutputPort : IGetAllSignsOutputPort, IPresenter<IEnumerable<SignDTO>>
    {
        private IEnumerable<SignDTO> signDTOs;
        public IEnumerable<SignDTO> Content { get { return this.signDTOs; } }

        public GetAllSignOutputPort()
        {
            this.signDTOs = new List<SignDTO>();
        }

        public Task Handle(IEnumerable<SignDTO> signDTOs)
        {
            this.signDTOs = signDTOs;
            return Task.CompletedTask;
        }
    }
}
