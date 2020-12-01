using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV2doParcial
{
    public partial class Crear : Form
    {
        string localI;
        string localB;
        string port;
        string address;
        string password;
        string redundancia;
        string options;

        public Crear()
        {
            InitializeComponent();
            cbxRedundancia.Items.Add("High");
            cbxRedundancia.Items.Add("Normal");
            cbxRedundancia.Items.Add("Low");

            cbxOption.Text = "Full";
            cbxOption.Items.Add("Part");
            cbxOption.Items.Add("Min");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            leerDatos();
        }

        private void leerDatos()
        {
            if (string.IsNullOrEmpty(txtLInventario.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO DE INVENTARIO");
            }
            else if (string.IsNullOrEmpty(txtLBase.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO DE BASE");
            }
            else if (string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO DE PORT");
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO DE ADDRESS");
            }
            else if (string.IsNullOrEmpty(txtPasword.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO DE PASSWORD");
            }
            else if (string.IsNullOrEmpty(cbxRedundancia.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO DE REDUNDANCIA");
            }
            else
            {
                localI = txtLInventario.Text;
                localB = txtLBase.Text;
                port = txtPort.Text;
                address = txtAddress.Text;
                password = txtPasword.Text;
                redundancia = cbxRedundancia.Text;
                options = cbxOption.Text;


                listCArchivo.Items.Add("LOCALIDINVENTARIO: " + localI);
                listCArchivo.Items.Add("LOCALIDADBASE: " + localB);
                listCArchivo.Items.Add("install.port: " + port);
                listCArchivo.Items.Add("install.address: " + address);
                listCArchivo.Items.Add("install.password: " + password);
                listCArchivo.Items.Add("install.redundancia: " + redundancia);
                listCArchivo.Items.Add("install.option: " + options);

                MessageBox.Show("SE HAN GUARDADO CON EXITO LOS DATOS");
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            TextWriter archivo;
            archivo = new StreamWriter("examen.txt");
            archivo.WriteLine("LOCALIDADINVENTARIO: " + localI);
            archivo.WriteLine("LOCALIDADBASE: " + localB);
            archivo.WriteLine("install.port: " + port);
            archivo.WriteLine("install.address: " + address);
            archivo.WriteLine("install.password: " + password);
            archivo.WriteLine("install.redundancia: " + redundancia);
            archivo.WriteLine("install.option: " + options);
            archivo.Close();

            MessageBox.Show("Tu archivo se ha creado con exito");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 formBase = new Form1();
            formBase.Show();
        }
    }
}
