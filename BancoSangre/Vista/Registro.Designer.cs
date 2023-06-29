namespace BancoSangre.Vista
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEgreso = new System.Windows.Forms.TextBox();
            this.TimerSalida = new System.Windows.Forms.DateTimePicker();
            this.TimerIngreso = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxHabtiacion = new System.Windows.Forms.ComboBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComboBoxSexo = new System.Windows.Forms.ComboBox();
            this.ComboboxNacionalidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Comboboxacompañantes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservaciones";
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClose.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelClose.Location = new System.Drawing.Point(1022, 9);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(14, 15);
            this.LabelClose.TabIndex = 8;
            this.LabelClose.Text = "X";
            this.LabelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(377, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(719, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cedula";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.Location = new System.Drawing.Point(390, 492);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(250, 43);
            this.buttonIniciar.TabIndex = 12;
            this.buttonIniciar.Text = "Guardar";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(84, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 12;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtNombres.HideSelection = false;
            this.txtNombres.Location = new System.Drawing.Point(114, 139);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(220, 18);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtApellido.HideSelection = false;
            this.txtApellido.Location = new System.Drawing.Point(476, 139);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 18);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(446, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 12;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtCedula.HideSelection = false;
            this.txtCedula.Location = new System.Drawing.Point(818, 140);
            this.txtCedula.MaxLength = 16;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(178, 18);
            this.txtCedula.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(788, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 1);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nacionalidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(299, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Correo Ectronico";
            // 
            // TxtCorreoElectronico
            // 
            this.TxtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TxtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCorreoElectronico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoElectronico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.TxtCorreoElectronico.HideSelection = false;
            this.TxtCorreoElectronico.Location = new System.Drawing.Point(454, 210);
            this.TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            this.TxtCorreoElectronico.Size = new System.Drawing.Size(208, 18);
            this.TxtCorreoElectronico.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(424, 236);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 1);
            this.panel6.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "No. Telefono";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNumero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.TxtNumero.HideSelection = false;
            this.TxtNumero.Location = new System.Drawing.Point(134, 212);
            this.TxtNumero.MaxLength = 8;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(142, 18);
            this.TxtNumero.TabIndex = 4;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Location = new System.Drawing.Point(104, 238);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 1);
            this.panel7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de Entrada";
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TxtIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIngreso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.TxtIngreso.HideSelection = false;
            this.TxtIngreso.Location = new System.Drawing.Point(148, 361);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(142, 18);
            this.TxtIngreso.TabIndex = 7;
            this.TxtIngreso.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha de Salida";
            // 
            // TxtEgreso
            // 
            this.TxtEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TxtEgreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEgreso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.TxtEgreso.HideSelection = false;
            this.TxtEgreso.Location = new System.Drawing.Point(135, 412);
            this.TxtEgreso.Name = "TxtEgreso";
            this.TxtEgreso.Size = new System.Drawing.Size(142, 18);
            this.TxtEgreso.TabIndex = 8;
            this.TxtEgreso.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // TimerSalida
            // 
            this.TimerSalida.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TimerSalida.Location = new System.Drawing.Point(142, 410);
            this.TimerSalida.Name = "TimerSalida";
            this.TimerSalida.Size = new System.Drawing.Size(200, 20);
            this.TimerSalida.TabIndex = 11;
            this.TimerSalida.ValueChanged += new System.EventHandler(this.TimerSalida_ValueChanged);
            // 
            // TimerIngreso
            // 
            this.TimerIngreso.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TimerIngreso.Enabled = false;
            this.TimerIngreso.Location = new System.Drawing.Point(142, 361);
            this.TimerIngreso.Name = "TimerIngreso";
            this.TimerIngreso.Size = new System.Drawing.Size(197, 20);
            this.TimerIngreso.TabIndex = 10;
            this.TimerIngreso.ValueChanged += new System.EventHandler(this.TimerIngreso_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(348, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sexo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(633, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "No. Habitación";
            // 
            // comboBoxHabtiacion
            // 
            this.comboBoxHabtiacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.comboBoxHabtiacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHabtiacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.comboBoxHabtiacion.FormattingEnabled = true;
            this.comboBoxHabtiacion.Items.AddRange(new object[] {
            "Habitación No. 1: Económica",
            "Habitación No. 2: Económica",
            "Habitación No. 3: Económica",
            "Habitación No. 4: Económica",
            "Habitación No. 5: Accesible",
            "Habitación No. 6: Accesible",
            "Habitación No. 7: Acessible",
            "Habitación No. 8: Clase Alta",
            "Habitación No. 9: Clase Alta",
            "Habitación No. 10: Clase Alta"});
            this.comboBoxHabtiacion.Location = new System.Drawing.Point(741, 292);
            this.comboBoxHabtiacion.Name = "comboBoxHabtiacion";
            this.comboBoxHabtiacion.Size = new System.Drawing.Size(268, 26);
            this.comboBoxHabtiacion.TabIndex = 9;
            this.comboBoxHabtiacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxHabtiacion_SelectedIndexChanged);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // ComboBoxSexo
            // 
            this.ComboBoxSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ComboBoxSexo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ComboBoxSexo.FormattingEnabled = true;
            this.ComboBoxSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino",
            "Otros (Jajsaj Toston)"});
            this.ComboBoxSexo.Location = new System.Drawing.Point(395, 291);
            this.ComboBoxSexo.Name = "ComboBoxSexo";
            this.ComboBoxSexo.Size = new System.Drawing.Size(190, 26);
            this.ComboBoxSexo.TabIndex = 8;
            this.ComboBoxSexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // ComboboxNacionalidad
            // 
            this.ComboboxNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ComboboxNacionalidad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ComboboxNacionalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ComboboxNacionalidad.FormattingEnabled = true;
            this.ComboboxNacionalidad.Items.AddRange(new object[] {
            "",
            "Afganistán",
            "Akrotiri",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Anguila",
            "Antártida",
            "Antigua y Barbuda",
            "Arabia Saudí",
            "Arctic Ocean",
            "Argelia",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bahráin",
            "Bangladesh",
            "Barbados",
            "Bélgica",
            "Belice",
            "Benín",
            "Bermudas",
            "Bielorrusia",
            "Birmania; Myanmar",
            "Bolivia",
            "Bosnia y Hercegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colombia",
            "Comoras",
            "Congo",
            "Coral Sea Islands",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Curacao",
            "Dhekelia",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "El Vaticano",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Gaza Strip",
            "Georgia",
            "Ghana",
            "Gibraltar",
            "Granada",
            "Grecia",
            "Groenlandia",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea Ecuatorial",
            "Guinea-Bissau",
            "Guyana",
            "Haití",
            "Honduras",
            "Hong Kong",
            "Hungría",
            "India",
            "Indian Ocean",
            "Indonesia",
            "Irán",
            "Iraq",
            "Irlanda",
            "Isla Bouvet",
            "Isla Christmas",
            "Isla Norfolk",
            "Islandia",
            "Islas Caimán",
            "Islas Cocos",
            "Islas Cook",
            "Islas Feroe",
            "Islas Georgia del Sur y Sandwich del Sur",
            "Islas Heard y McDonald",
            "Islas Malvinas",
            "Islas Marianas del Norte",
            "Islas Marshall",
            "Islas Pitcairn",
            "Islas Salomón",
            "Islas Turcas y Caicos",
            "Islas Vírgenes Americanas",
            "Islas Vírgenes Británicas",
            "Israel",
            "Italia",
            "Jamaica",
            "Jan Mayen",
            "Japón",
            "Jersey",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguizistán",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macao",
            "Macedonia",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Man, Isle of",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Mozambique",
            "Mundo",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Niue",
            "Noruega",
            "Nueva Caledonia",
            "Nueva Zelanda",
            "Omán",
            "Pacific Ocean",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa-Nueva Guinea",
            "Paracel Islands",
            "Paraguay",
            "Perú",
            "Polinesia Francesa",
            "Polonia",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reino Unido",
            "República Centroafricana",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Sáhara Occidental",
            "Samoa",
            "Samoa Americana",
            "San Bartolomé",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Martín",
            "San Pedro y Miquelón",
            "San Vicente y las Granadinas",
            "Santa Helena",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Sint Maarten",
            "Siria",
            "Somalia",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Svalbard y Jan Mayen",
            "Tailandia",
            "Taiwán",
            "Tanzania",
            "Tayikistán",
            "Territorio Británico del Océano Indico",
            "Territorios Australes Franceses",
            "Timor Oriental",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Unión Europea",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Wake Island",
            "Wallis y Futuna",
            "West Bank",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.ComboboxNacionalidad.Location = new System.Drawing.Point(121, 291);
            this.ComboboxNacionalidad.Name = "ComboboxNacionalidad";
            this.ComboboxNacionalidad.Size = new System.Drawing.Size(190, 26);
            this.ComboboxNacionalidad.TabIndex = 7;
            this.ComboboxNacionalidad.SelectedIndexChanged += new System.EventHandler(this.ComboboxNacionalidad_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(914, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(698, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Acompañantes";
            // 
            // Comboboxacompañantes
            // 
            this.Comboboxacompañantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Comboboxacompañantes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Comboboxacompañantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Comboboxacompañantes.FormattingEnabled = true;
            this.Comboboxacompañantes.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Comboboxacompañantes.Location = new System.Drawing.Point(821, 210);
            this.Comboboxacompañantes.Name = "Comboboxacompañantes";
            this.Comboboxacompañantes.Size = new System.Drawing.Size(190, 26);
            this.Comboboxacompañantes.TabIndex = 6;
            this.Comboboxacompañantes.SelectedIndexChanged += new System.EventHandler(this.Comboboxacompañantes_SelectedIndexChanged);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1048, 671);
            this.Controls.Add(this.Comboboxacompañantes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboboxNacionalidad);
            this.Controls.Add(this.ComboBoxSexo);
            this.Controls.Add(this.comboBoxHabtiacion);
            this.Controls.Add(this.TimerSalida);
            this.Controls.Add(this.TimerIngreso);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtEgreso);
            this.Controls.Add(this.TxtIngreso);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtCorreoElectronico);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.LabelClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCorreoElectronico;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEgreso;
        private System.Windows.Forms.DateTimePicker TimerSalida;
        private System.Windows.Forms.DateTimePicker TimerIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxHabtiacion;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.ComboBox ComboBoxSexo;
        private System.Windows.Forms.ComboBox ComboboxNacionalidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Comboboxacompañantes;
        private System.Windows.Forms.Label label12;
    }
}