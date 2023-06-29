using BancoSangre.Controlador;
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
    public partial class Accesible : Form
    {
        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";
        public Accesible()
        {
            InitializeComponent();
            Disponibilidad5();
            Disponibilidad6();
            Disponibilidad7();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Disponibilidad5()
        {
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 5 Accecible")).FirstOrDefault();
                if (data != null)
                {
                    Disponible5.Visible = false;
                    Nodisponible5.Visible = true;

                }
                else
                {
                    Disponible5.Visible = true;
                    Nodisponible5.Visible = false;
                }


            }
        }
        public void Disponibilidad6()
        {
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


    var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 6 Accecible")).FirstOrDefault();
                if (data != null)
                {
                    Disponible6.Visible = false;
                    Nodisponible6.Visible = true;

                }
                else
                {
                    Disponible6.Visible = true;
                    Nodisponible6.Visible = false;
                }


            }
        }
        public void Disponibilidad7()
        {
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 7 Accecible")).FirstOrDefault();
                if (data != null)
                {
                    Disponible7.Visible = false;
                    Nodisponible7.Visible = true;

                }
                else
                {
                    Disponible7.Visible = true;
                    Nodisponible7.Visible = false;
                }


            }
        }
    }
}
