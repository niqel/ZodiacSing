using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.AppBusiness.DTOs;
using ZodiacSign.AppBusiness.UseCases;
using ZodiacSign.Domain.IRepositories;

namespace ZodiacSign.AppBusinessImplementations.UseCasesImplementation
{
    public class GetSignByBirthday : IGetSignByBirthday
    {
        private readonly IUnityOfWork unityOfWork;

        public GetSignByBirthday(IUnityOfWork unityOfWork)
        {
            this.unityOfWork = unityOfWork;
        }

        public Task<SignDTO> Handle(DateOnly birthday)
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
            return Task.FromResult(sign);
        }
    }
}
