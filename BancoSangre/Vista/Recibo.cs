using BancoSangre.Controlador;
using BancoSangre.Modelo;
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

namespace BancoSangre.Vista
{
    public partial class Recibo : Form
    {

        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";

        Datosenviar info;
        //List<Datosenviar> infoSend;
        List<Datosenviar> datosenviars = new List<Datosenviar>();
        public Recibo()
        {
            InitializeComponent();
            //infoSend = new List<Datosenviar>();
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            
            info = new Datosenviar();
            info.Nombres = ReciboNombre.Text;
            info.Apellidos = ReciboApellidos.Text;
            info.Cedula = ReciboCedula.Text;
            info.Nacionalidad = ReciboNacionalidad.Text;
            info.Sexo = ReciboSexo.Text;
            info.CorreoElectronico = ReciboCorreo.Text;
            info.NoTelefono = ReciboTelefono.Text;
            info.Acompañantes = txtAcompañantes.Text;
            info.FechaIngreso = ReciboEntrada.Text;
            info.FechaEgreso = ReciboIr.Text;
            info.Habitacion = ReciboHabitacion.Text;
            info.TotalDolares = ReciboTotal.Text;
            info.TotalCordobas = ReciboTotal2.Text;
            info.fechayhora = DateTime.Now.ToString();


            datosenviars.Add(info);
            Guardar();
            MessageBox.Show("Se ha registrado al Cliente satsifactoriamente!");
            this.Close();
            Registro po = new Registro();
            po.Close();
        }
        public void Guardar()
        {
           
                List<string> output = new List<string>();
                foreach (var item in datosenviars)
                {
                
                    output.Add($"{item.Nombres}°{item.Apellidos}°{item.Cedula}°{item.Acompañantes}°{item.Nacionalidad}°{item.Sexo}°{item.CorreoElectronico}°{item.NoTelefono}°{item.FechaIngreso}°{item.FechaEgreso}°{item.Habitacion}°{item.TotalDolares}°{item.TotalCordobas}°{Datosenviar.NombredelLogin}°{item.fechayhora}");
                }
            File.AppendAllLines(Path.Combine(path, Consulta), output);
            
            
        }

        private void BotonImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
    }
}
