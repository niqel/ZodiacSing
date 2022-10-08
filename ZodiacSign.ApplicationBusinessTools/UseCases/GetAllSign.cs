using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.AppBusiness.DTOs;
using ZodiacSign.ApplicationBusinessTools.UseCaseInputPorts;
using ZodiacSign.ApplicationBusinessTools.UseCaseOutputPorts;
using ZodiacSign.Domain.IRepositories;

namespace ZodiacSign.ApplicationBusinessTools.UseCases
{
    public class GetAllSign : IGetAllsignsInputPort
    {
        private readonly IGetAllSignsOutputPort getAllSignsOutputPort;
        private readonly IUnityOfWork unityOfWork;

        public GetAllSign(IGetAllSignsOutputPort getAllSignsOutputPort, IUnityOfWork unityOfWork)
        {
            this.getAllSignsOutputPort = getAllSignsOutputPort;
            this.unityOfWork = unityOfWork;
        }

        public Task Handle()
        {
            var signs = from s in this.unityOfWork.Signs.Read()
                        join e in this.unityOfWork.Elements.Read() on s.ElementId equals e.Id
                        join g in this.unityOfWork.Gems.Read() on s.GemId equals g.Id

                        select new SignDTO
                        {
                            Id = s.Id,
                            Name = s.Name,
                            FromMonth = s.FromMonth,
                            FromDay = s.FromDay,
                            UntilMonth = s.UntilMonth,
                            UntilDay = s.UntilDay,
                            Element = e.Name,
                            Gem = g.Name,
                            Homes = (from item in s.Homes
                                     where item.Id == s.Id
                                     select new HomeDTO()
                                     {
                                         Name = item.Name,
                                     }).ToList()
                        };
            this.getAllSignsOutputPort.Handle(signs);
            return Task.CompletedTask;
        }
    }
}
