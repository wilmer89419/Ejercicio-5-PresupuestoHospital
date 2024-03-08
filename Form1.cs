namespace PresupuestoHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            double Presupuesto, Emergencia, Cirugia, Suministros, Administracion, Laboratorio, ImagenesDiagnosticas;

            Presupuesto = int.Parse(txtPresupuesto.Text);




            Emergencia = Presupuesto * 0.30;
            Cirugia = Presupuesto * 0.15;
            Suministros = Presupuesto * 0.25;
            Administracion = Presupuesto * 0.18;
            Laboratorio = Presupuesto * 0.05;
            ImagenesDiagnosticas = Presupuesto * 0.07;


            lblPresupuestoResultado.Text = Presupuesto.ToString();
            lblResultadoEmergencia.Text = Emergencia.ToString();
            lblResultadoCirugia.Text = Cirugia.ToString();
            lblResultadoSuministros.Text = Suministros.ToString();
            lblResultadoAdministracion.Text = Administracion.ToString();
            lblResultadoLaboratorio.Text = Laboratorio.ToString();
            lblResultadoImagenes.Text = ImagenesDiagnosticas.ToString();
        }

        private void lblPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDepartamento_Click(object sender, EventArgs e)
        {
        }

        private void lblPorcentaje_Click(object sender, EventArgs e)
        {
        }

        private void lblPresupuesto_Click_1(object sender, EventArgs e)
        {
        }

        private void lblPresupuestoHospital_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultadoEmergencia.Text = String.Empty;
            lblResultadoCirugia.Text = String.Empty;
            lblResultadoImagenes.Text = String.Empty;
            lblResultadoAdministracion.Text = String.Empty;
            lblPresupuestoResultado.Text = String.Empty;
            lblResultadoLaboratorio.Text = String.Empty;
            lblResultadoSuministros.Text = String.Empty;
        }
    }
}