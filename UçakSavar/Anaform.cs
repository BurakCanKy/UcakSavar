using System;
using System.Windows.Forms;
using UçakSavar.Library.Concrete;
using UçakSavar.Library.Enum;

namespace UçakSavar
{
    public partial class SavaşOyunu : Form
    {
        private readonly Oyun _oyun = new Oyun();
        public SavaşOyunu()
        {
            
            InitializeComponent();
        }

        private void SavaşOyunu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UçakHareket(Yön.Sağa);
                    break;
                case Keys.Left:
                    _oyun.UçakHareket(Yön.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }
    }
}
