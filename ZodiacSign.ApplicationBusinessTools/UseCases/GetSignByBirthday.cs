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
    public class GetSignByBirthday : IGetSignByBirthdayInputPort
    {
        private readonly IGetSignByBirthdayOutputPort getSignByBirthdayOutputPort;
        private readonly IUnityOfWork unityOfWork;

        public GetSignByBirthday(IGetSignByBirthdayOutputPort getSignByBirthdayOutputPort, IUnityOfWork unityOfWork)
        {
            this.getSignByBirthdayOutputPort = getSignByBirthdayOutputPort;
            this.unityOfWork = unityOfWork;
        }

        public Task Handle(DateOnly birthday)
        {
            var sign = (from s in this.unityOfWork.Signs.Read()
                        where s.FromMonth == birthday.Month && birthday.Day >= s.FromDay ||
                              s.UntilMonth == birthday.Month && birthday.Day <= s.UntilDay
                        join g in this.unityOfWork.Gems.Read() on s.GemId equals g.Id
                        join e in this.unityOfWork.Elements.Read() on s.ElementId equals e.Id
                        select new SignDTO
                        {
                            Id = s.Id,
                            Name = s.Name,
                            FromDay = s.FromDay,
                            FromMonth = s.FromMonth,
                            UntilDay = s.UntilDay,
                            UntilMonth = s.UntilMonth,
                            Gem = g.Name,
                            Element = e.Name,
                            Homes = (from item in s.Homes
                                     where item.Id == s.Id
                                     select new HomeDTO()
                                     {
                                         Name = item.Name,
                                     }).ToList()
                        }).First();
            this.getSignByBirthdayOutputPort.Handle(sign);
            return Task.CompletedTask;
        }
    }
}
