namespace iniciar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_edad.Clear();
            txt_genero.Clear();
            txt_Situacion.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            int Edad;
            char genero;
            string situacion;
            Edad = int.Parse(txt_edad.Text);
            genero = char.Parse(txt_genero.Text);
            situacion = txt_Situacion.Text.ToString();

            if (Edad <= 18 && genero == 'h')
            {
                situacion = "Eres hombre entra pagando";
                txt_Situacion.ForeColor = Color.Red;
            }
            else if (Edad <= 18 && genero == 'm')
            {
                situacion = "Eres mujer entra gratis";
                txt_Situacion.ForeColor = Color.Green;
            }

            else
            {
                txt_Situacion.Text="Eres menor de edad";
            }
            txt_Situacion.Text = situacion;


        }
    }
}
