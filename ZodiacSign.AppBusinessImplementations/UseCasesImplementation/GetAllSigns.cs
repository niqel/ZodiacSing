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
    public class GetAllSigns : IGetAllSigns
    {
        private readonly IUnityOfWork unityOfWork;

        public GetAllSigns(IUnityOfWork unityOfWork)
        {
            this.unityOfWork = unityOfWork;
        }
        public Task<List<SignDTO>> Handle()
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

            return Task.FromResult(signs.ToList());
        }
    }
}
