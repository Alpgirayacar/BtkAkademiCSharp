namespace OdemeFormu
{
    public partial class Form1 : Form
    {
        string secilenOdemeTipi;
        OdemeIslemi odemeIslemi;
        IOdemeTipi odemeTipi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {


            double tutar = Convert.ToDouble(txttutar.Text);
            OdemeIslemiFactory factory = new OdemeIslemiFactory();
            //polimorfik obje artýk elimizde
            odemeTipi = factory.GetInstance(secilenOdemeTipi);
            odemeIslemi = new OdemeIslemi(odemeTipi);
            lblSonuc.Text = odemeIslemi.Ode(tutar);



        }

        private void cmbOdemeTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenOdemeTipi = cmbOdemeTipi.SelectedItem.ToString();
        }
    }
}