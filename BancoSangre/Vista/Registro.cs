
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.IO;
using BancoSangre.Controlador;
using BancoSangre.Modelo;
namespace BancoSangre.Vista
{
    public partial class Registro : Form
    {
        public Form FormularioPadre { get; set; }

        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";
        public Registro()
        {

            InitializeComponent();
            TimerIngreso.MinDate = DateTime.Now;
            TimerSalida.MinDate = DateTime.Now;
            TimerSalida.MaxDate = DateTime.Now.AddDays(5);
            Renta();
            
        }
        List<Datos> objD = new List<Datos>();
        double subtotal;
        double Dolar;
        
        public void Renta()
        {
            objD.Add(new Datos {ID = 0, Nombre = "",});
            objD.Add(new Datos {ID = 1, Nombre = "Habitacion # 1 Economica", Precio = 190});
            objD.Add(new Datos {ID = 2, Nombre = "Habitacion # 2 Economica", Precio = 190});
            objD.Add(new Datos {ID = 3, Nombre = "Habitacion # 3 Economica", Precio = 190});
            objD.Add(new Datos {ID = 4, Nombre = "Habitacion # 4 Economica", Precio = 190});
            objD.Add(new Datos{ID = 5, Nombre = "Habitacion # 5 Accecible", Precio = 240});
            objD.Add(new Datos{ID = 6, Nombre = "Habitacion # 6 Accecible", Precio = 240});
            objD.Add(new Datos{ID = 7, Nombre = "Habitacion # 7 Accecible", Precio = 240});
            objD.Add(new Datos{ID = 8, Nombre = "Habitacion # 8 Clase Alta",Precio = 320});
            objD.Add(new Datos{ID = 9, Nombre = "Habitacion # 9 Clase Alta", Precio = 320});
            objD.Add(new Datos{ID = 10, Nombre = "Habitacion # 10 Clase Alta", Precio = 320});

            

            this.comboBoxHabtiacion.DataSource = objD;
            this.comboBoxHabtiacion.DisplayMember = "Nombre";
            this.comboBoxHabtiacion.ValueMember = "ID";
            
        }
        public void Buscador()
        {
           
        }
       
        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
     
        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
        public void Validaciondecombobox()
        {
            Compras();
            List<Datosenviar> datosenviars = new List<Datosenviar>();
            var directExist = Directory.Exists(path);

            if (directExist == true)
            {
                List<string> input = File.ReadAllLines(Path.Combine(path, Consulta)).ToList();

                foreach (var linea in input)
                {
                    string[] registro = linea.Split('°');

                    Datosenviar Eje = new Datosenviar();
                    Eje.Nombres = registro[0];
                    Eje.Apellidos = registro[1];
                    Eje.Cedula = registro[2];
                    Eje.Acompañantes = registro[3];
                    Eje.Nacionalidad = registro[4];
                    Eje.Sexo = registro[5];
                    Eje.CorreoElectronico = registro[6];
                    Eje.NoTelefono = registro[7];
                    Eje.FechaIngreso = registro[8];
                    Eje.FechaEgreso = registro[9];
                    Eje.Habitacion = registro[10];

                    datosenviars.Add(Eje);

                }

                
                var data = datosenviars.Where(x => x.Habitacion.Equals(comboBoxHabtiacion.Text)).FirstOrDefault();
                if (data != null)
                {
                    Error.SetError(comboBoxHabtiacion, "Esta habitacion ya está reservada");
                    comboBoxHabtiacion.Focus();
                    
                }
               else 
                {
                    RecibMostrar();
                }
               


            }
        }
        public void Compras()
        {
           
                var renta = objD.Where(x => x.ID == int.Parse(comboBoxHabtiacion.SelectedValue.ToString())).FirstOrDefault();

                subtotal = renta.Precio;
                Dolar = renta.Precio * 36;
            
           
        }


        public void RecibMostrar()
        {

            Recibo f = new Recibo();
            f.ReciboNombre.Text = txtNombres.Text;
            f.ReciboApellidos.Text = txtApellido.Text;
            f.ReciboCedula.Text = txtCedula.Text;
            f.ReciboTelefono.Text = TxtNumero.Text;
            f.ReciboCorreo.Text = TxtCorreoElectronico.Text;
            f.txtAcompañantes.Text = Comboboxacompañantes.Text;
            f.ReciboNacionalidad.Text = ComboboxNacionalidad.Text;
            f.ReciboSexo.Text = ComboBoxSexo.Text;
            f.ReciboEntrada.Text = TimerIngreso.Text;
            f.ReciboIr.Text = TimerSalida.Text;
            f.ReciboHabitacion.Text = comboBoxHabtiacion.Text;
            f.ReciboTotal.Text = "$ " + this.subtotal.ToString();
            f.ReciboTotal2.Text = "C$ " + this.Dolar.ToString();
            f.ReciboCrearNombre.Text = Datosenviar.NombredelLogin;
            f.ReciboFechayhora.Text = DateTime.Now.ToString();


            // Acá se suscribe al evento guardar clic del showdialog
            f.GuardarClicked += (s, args) =>
            {
                borrar_paneles();
            };

            f.ShowDialog();

        }
        public void ValidacionDeTodoRegistro()
        {

            if (txtNombres.Text.Trim() == "")
            {
                Error.SetError(txtNombres, "Debe de llenar todos los campos para continuar");
                txtNombres.Focus();
            }

            else if (txtApellido.Text.Trim() == "")
            {
                Error.SetError(txtApellido, "Debe de llenar todos los campos para continuar");
                txtApellido.Focus();
            }

            else if (txtCedula.Text.Trim() == "")
            {
                Error.SetError(txtCedula, "Debe de llenar todos los campos para continuar");
                txtCedula.Focus();
            }

            else if (TxtNumero.Text.Trim() == "")
            {
                Error.SetError(TxtNumero, "Debe de llenar todos los campos para continuar");
                TxtNumero.Focus();
            }

            else if (TxtCorreoElectronico.Text.Trim() == "")
            {
                Error.SetError(TxtCorreoElectronico, "Debe de llenar todos los campos para continuar");
                TxtCorreoElectronico.Focus();
            }

            else if (Comboboxacompañantes.Text.Trim() == "")
            {
                Error.SetError(Comboboxacompañantes, "Debe de llenar todos los campos para continuar");
                Comboboxacompañantes.Focus();
            }

            else if (ComboboxNacionalidad.Text.Trim() == "")
            {
                Error.SetError(ComboboxNacionalidad, "Debe de llenar todos los campos para continuar");
                ComboboxNacionalidad.Focus();
            }

            else if (ComboBoxSexo.Text.Trim() == "")
            {
                Error.SetError(ComboBoxSexo, "Debe de llenar todos los campos para continuar");
                ComboBoxSexo.Focus();
            }

            else if (comboBoxHabtiacion.Text.Trim() == "")
            {
                Error.SetError(comboBoxHabtiacion, "Debe de llenar todos los campos para continuar");
                comboBoxHabtiacion.Focus();
            }

            else
            {
                Error.Clear();
                Validaciondecombobox();
            }
        }
        public void buttonIniciar_Click(object sender, EventArgs e)
        {
           
            ValidacionDeTodoRegistro();
            

        }
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            HotelitoControlador.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            HotelitoControlador.SoloLetras(e);
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            HotelitoControlador.SoloNumeros(e);
        }

        private void comboBoxHabtiacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxHabtiacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ComboboxNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotelitoControlador hotelitoControlador = new HotelitoControlador();
            hotelitoControlador.BorrarCampos(this);
        }

        private void TimerIngreso_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TimerSalida_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Comboboxacompañantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comboboxacompañantes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonIniciar_Click_1(object sender, EventArgs e)
        {
            ValidacionDeTodoRegistro();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            borrar_paneles();
        }

        public void borrar_paneles()
        {
            HotelitoControlador hotelitoControlador = new HotelitoControlador();
            hotelitoControlador.BorrarCampos(panel4);  // Reemplaza "panelRegistro" con el nombre de tu panel
        }

        private void Registro_Load(object sender, EventArgs e)
        {


        }




    }
}

