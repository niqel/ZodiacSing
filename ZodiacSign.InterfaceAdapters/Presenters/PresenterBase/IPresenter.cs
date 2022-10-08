using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacSign.InterfaceAdapters.Presenters.PresenterBase
{
    public interface IPresenter<FormatType>
    {
        public FormatType Content { get; }
    }
}
