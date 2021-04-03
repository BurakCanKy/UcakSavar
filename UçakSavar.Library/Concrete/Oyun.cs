using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UçakSavar.Library.Enum;
using UçakSavar.Library.Interface;

namespace UçakSavar.Library.Concrete
{
    public class Oyun : IOyun
    {
        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSüre { get;}

        public void AtesEt()
        {
            throw new NotImplementedException();
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;
            DevamEdiyorMu = true;   
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
        }
        public void UçakHareket(Yön yön)
        {
            throw new NotImplementedException();
        }
    }
}
