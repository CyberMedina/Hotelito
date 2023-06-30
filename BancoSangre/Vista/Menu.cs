using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BancoSangre.Vista;
using BancoSangre.Controlador;

namespace BancoSangre
{
    
    public partial class Form1 : Form
    {
        Datosenviar login = new Datosenviar();
        Datosenviar info;
        public Form1()
        {
           
            InitializeComponent();
            MostrarLogin();
            timer1.Enabled = true;

            

        }
        List<Datosenviar> datosenviars = new List<Datosenviar>();
        public void MostrarLogin()
        {
            txtInfo.Text = Datosenviar.NombredelLogin;
        }
        //Se crea instancia para abrir formularios dentro de paneles
        public void Abrirformulario<MiForm>() where MiForm : Form, new()
        {
            // Verificar si el formulario seleccionado es Registro
            if (typeof(MiForm) == typeof(Registro))
            {
                // Verificar si ya hay un formulario Registro abierto
                var formularioRegistro = PanelTodo.Controls.OfType<Registro>().FirstOrDefault();
                if (formularioRegistro != null)
                {
                    // Si hay un formulario Registro abierto, solo se muestra y se trae al frente
                    formularioRegistro.Show();
                    formularioRegistro.BringToFront();
                    return;
                }
            }
            else
            {
                // Ocultar formulario Registro si está abierto
                var formularioRegistro = PanelTodo.Controls.OfType<Registro>().FirstOrDefault();
                if (formularioRegistro != null)
                {
                    formularioRegistro.Hide();
                }

                // Cerrar formulario abierto previamente, si existe y no es Registro
                var formularioAbierto = PanelTodo.Controls.OfType<Form>().FirstOrDefault(f => f != formularioRegistro);
                if (formularioAbierto != null)
                {
                    formularioAbierto.Close();
                    PanelTodo.Controls.Remove(formularioAbierto);
                }
            }

            // Abrir el nuevo formulario
            Form Formulario = new MiForm();
            Formulario.TopLevel = false;
            PanelTodo.Controls.Add(Formulario);
            Formulario.Dock = DockStyle.Fill;
            Formulario.Show();
            Formulario.BringToFront();
        }






        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            BotonSalir botonSalir = new BotonSalir();
            botonSalir.ShowDialog();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void RayitasMenu_Click(object sender, EventArgs e)
        {
            if(SlideBar.Width == 270)
            {
                SlideBar.Visible = false;
                SlideBar.Width = 68;
                Panel2.Width = 90;
                Linea.Width = 52;
                AnimacionSideBar.Show(SlideBar);
            }
            else
            {
                SlideBar.Visible = false;
                SlideBar.Width = 270;
                Panel2.Width = 300;
                Linea.Width = 252;
                AnimacionSliderBarRegreso.Show(SlideBar);
            }
        }

        private void MenuSlide_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //Reservacion boton
            Abrirformulario<Registro>();
        }

        private void HabitacionesClick_Click(object sender, EventArgs e)
        {
            Abrirformulario<Economica>();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Abrirformulario<Archivos>();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
          
            Abrirformulario<ListadoDeClientes>();

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
             Abrirformulario<Economica>();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Abrirformulario<Accesible>();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Abrirformulario<Clase_Alta>();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            BotonSalir botonSalir = new BotonSalir();
            botonSalir.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelFecha.Text = DateTime.Now.ToString();
        }

        private void LabelFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
