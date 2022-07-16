namespace HackCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBMunicaoInfinitaCheckedChanged(object sender, EventArgs e)
        {
            Program.MunicaoInfinita = cbMunicaoInfinita.Checked;
        }

        private void CBVidaInfinitaCheckedChanged(object sender, EventArgs e)
        {
            Program.VidaInfinita = cbVidaInfinita.Checked;
        }

        private void CBVColeteInfinitaCheckedChanged(object sender, EventArgs e)
        {
            Program.ColeteInfinito = cbColeteInfinito.Checked;
        }

        private void CBVNoRecoilCheckedChanged(object sender, EventArgs e)
        {
            Program.NoRecoil = cbNoRecoil.Checked;
        }
    }
}