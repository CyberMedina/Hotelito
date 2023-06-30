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
    public partial class Economica : Form
    {
        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";
        public Economica()
        {
            InitializeComponent();
            Disponibilidad1();
            Disponibilidad2();
            Disponibilidad3();
            Disponibilidad4();
        }



        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

            

        }

        private void Economica_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
                
            
            
        }

        private void LabelNodisponible1_Click(object sender, EventArgs e)
        {

        }

        public void Disponibilidad1()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 1 Economica")).FirstOrDefault();
                if (data != null)
                {
                    Disponible1.Visible = false;
                    Nodisponible1.Visible = true;

                }
                else
                {
                    Disponible1.Visible = true;
                    Nodisponible1.Visible = false;
                }


            }
        }
        public void Disponibilidad2()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 2 Economica")).FirstOrDefault();
                if (data != null)
                {
                    Disponible2.Visible = false;
                    Nodisponible2.Visible = true;

                }
                else
                {
                    Disponible2.Visible = true;
                    Nodisponible2.Visible = false;
                }


            }
        }
        public void Disponibilidad3()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 3 Economica")).FirstOrDefault();
                if (data != null)
                {
                    Disponible3.Visible = false;
                    Nodisponible3.Visible = true;

                }
                else
                {
                    Disponible3.Visible = true;
                    Nodisponible3.Visible = false;
                }


            }
        }
        public void Disponibilidad4()
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


                var data = datosenviars.Where(x => x.Habitacion.Equals("Habitacion # 4 Economica")).FirstOrDefault();
                if (data != null)
                {
                    Disponible4.Visible = false;
                    Nodisponible4.Visible = true;

                }
                else
                {
                    Disponible4.Visible = true;
                    Nodisponible4.Visible = false;
                }


            }
        }

        private void LabelClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
