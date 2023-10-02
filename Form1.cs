using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=ASUS;Initial Catalog=Empresa;integrated Security=true; TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "INSERT INTO EMPLEADO VALUES" + "("+ txtid.Text + "','" + txtnombre.Text + "','" + txtapellido + "','"+ txtdireccion.Text + "')";

            SqlCommand comando = new SqlCommand(consulta, conexion);



            
        }
    }
}
