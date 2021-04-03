using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UçakSavar.Library.Enum;

namespace UçakSavar.Library.Interface
{
    internal interface IOyun
    {
        bool DevamEdiyorMu {get; }
        TimeSpan GecenSüre { get; }
        void Baslat();
        void AtesEt();
        void UçakHareket(Yön yön);
    }
}
