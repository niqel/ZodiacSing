using ZodiacSign.AppBusiness.UseCases;

namespace ZodiacSign.AppBusinessImplementations
{
    public class Presenter : IPresenter
    {
        private IGetAllSigns getAllSigns;
        private IGetSignByBirthday getSignByBirthday;
        public IGetAllSigns GetAllSigns { get => this.getAllSigns; }
        public IGetSignByBirthday GetSignByBirthday { get => this.getSignByBirthday; }

        public Presenter(IGetAllSigns getAllSigns, IGetSignByBirthday getSignByBirthday)
        {
            this.getAllSigns = getAllSigns;
            this.getSignByBirthday = getSignByBirthday;
        }
    }
}