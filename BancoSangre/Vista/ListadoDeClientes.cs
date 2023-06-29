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
    
    public partial class ListadoDeClientes : Form 
    {
        public string Consulta = "Reservaciones.txt";
        public string path = @"C:\Base de datos Hotel";
        Recibo recibo = new Recibo();
        List<Datosenviar> ojb3;
        public ListadoDeClientes()
        {
            InitializeComponent();
            AddDetail();
        }

        private void AddDetail()
        {
            var existe = Directory.Exists(recibo.path);

            if (existe == true)
            {
                Print();
            }
            else
            {
                MessageBox.Show("No hay reservaciones agendadas!.");
            }
        }
        public void Print()
        {

            List<Datosenviar> datosenviars = new List<Datosenviar>();
            List<string> input = File.ReadAllLines(Path.Combine(recibo.path, recibo.Consulta)).ToList();
            
            foreach (var linea in input)
            {

                string[] registro = linea.Split('°');
                Datosenviar Eje = new Datosenviar();
                datosenviars.Clear();
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
                Eje.TotalDolares = registro[11];
                Eje.TotalCordobas = registro[12];
                Datosenviar.NombredelLogin = registro[13];
                Eje.fechayhora = registro[14];

                datosenviars.Add(Eje);
                

                foreach (var item in datosenviars)
                {
                    
                    int row = Listado.Rows.Add();
                    Listado.Rows[row].Cells[0].Value = item.Nombres;
                    Listado.Rows[row].Cells[1].Value = item.Apellidos;
                    Listado.Rows[row].Cells[2].Value = item.Cedula;
                    Listado.Rows[row].Cells[3].Value = item.Acompañantes;
                    Listado.Rows[row].Cells[4].Value = item.Nacionalidad;
                    Listado.Rows[row].Cells[5].Value = item.Sexo;
                    Listado.Rows[row].Cells[6].Value = item.CorreoElectronico;
                    Listado.Rows[row].Cells[7].Value = item.NoTelefono;
                    Listado.Rows[row].Cells[8].Value = item.FechaIngreso;
                    Listado.Rows[row].Cells[9].Value = item.FechaEgreso;
                    Listado.Rows[row].Cells[10].Value = item.Habitacion;
                    Listado.Rows[row].Cells[11].Value = item.TotalDolares;
                    Listado.Rows[row].Cells[12].Value = item.TotalCordobas;
                    Listado.Rows[row].Cells[13].Value = Datosenviar.NombredelLogin;
                    Listado.Rows[row].Cells[14].Value = item.fechayhora;


                }

            }
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            
            int selectedRow = Listado.CurrentCell.RowIndex;
            Listado.Rows.RemoveAt(selectedRow);
            

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
