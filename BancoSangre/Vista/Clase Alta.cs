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
    public partial class Clase_Alta : Form
    {
        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";
        public Clase_Alta()
        {
            InitializeComponent();
            Disponibilidad9();
            Disponibilidad8();
            Disponibilidad10();
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Disponibilidad8()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 8 Clase Alta")).FirstOrDefault();
                if (data != null)
                {
                    Disponible8.Visible = false;
                    Nodisponible8.Visible = true;

                }
                else
                {
                    Disponible8.Visible = true;
                    Nodisponible8.Visible = false;
                }


            }
        }
        public void Disponibilidad9()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 9 Clase Alta")).FirstOrDefault();
                if (data != null)
                {
                    Disponible9.Visible = false;
                    Nodisponible9.Visible = true;

                }
                else
                {
                    Disponible9.Visible = true;
                    Nodisponible9.Visible = false;
                }


            }
        }
        public void Disponibilidad10()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 10 Clase Alta")).FirstOrDefault();
                if (data != null)
                {
                    Disponible10.Visible = false;
                    Nodisponible10.Visible = true;

                }
                else
                {
                    Disponible10.Visible = true;
                    Nodisponible10.Visible = false;
                }


            }
        }
    }
    
}
