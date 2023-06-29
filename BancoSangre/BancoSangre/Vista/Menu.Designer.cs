namespace BancoSangre

{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Labio = new System.Windows.Forms.Label();
            this.RayitasMenu = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.SlideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HabitacionesClick = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReservacionButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.MenuSlide = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.PanelTodo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnimacionSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSliderBarRegreso = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverPrograma = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RadioPanelTotal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RayitasMenu)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SlideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panel3.SuspendLayout();
            this.PanelTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Panel1.Controls.Add(this.Restaurar);
            this.Panel1.Controls.Add(this.Minimizar);
            this.Panel1.Controls.Add(this.Maximizar);
            this.Panel1.Controls.Add(this.Salir);
            this.Panel1.Controls.Add(this.Labio);
            this.Panel1.Controls.Add(this.RayitasMenu);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1462, 98);
            this.Panel1.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSideBar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1358, 23);
            this.Restaurar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(40, 37);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 2;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSideBar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1310, 23);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 37);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSideBar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1358, 23);
            this.Maximizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(40, 37);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 2;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSideBar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1406, 23);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(40, 37);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 1;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Labio
            // 
            this.Labio.AutoSize = true;
            this.AnimacionSideBar.SetDecoration(this.Labio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Labio, BunifuAnimatorNS.DecorationType.None);
            this.Labio.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labio.ForeColor = System.Drawing.Color.White;
            this.Labio.Location = new System.Drawing.Point(64, 23);
            this.Labio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labio.Name = "Labio";
            this.Labio.Size = new System.Drawing.Size(91, 30);
            this.Labio.TabIndex = 0;
            this.Labio.Text = "Hotelito";
            // 
            // RayitasMenu
            // 
            this.AnimacionSideBar.SetDecoration(this.RayitasMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.RayitasMenu, BunifuAnimatorNS.DecorationType.None);
            this.RayitasMenu.Image = ((System.Drawing.Image)(resources.GetObject("RayitasMenu.Image")));
            this.RayitasMenu.Location = new System.Drawing.Point(16, 15);
            this.RayitasMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RayitasMenu.Name = "RayitasMenu";
            this.RayitasMenu.Size = new System.Drawing.Size(40, 37);
            this.RayitasMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RayitasMenu.TabIndex = 0;
            this.RayitasMenu.TabStop = false;
            this.RayitasMenu.Click += new System.EventHandler(this.RayitasMenu_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel2.Controls.Add(this.SlideBar);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Panel2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.Panel2, BunifuAnimatorNS.DecorationType.None);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 98);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 824);
            this.Panel2.TabIndex = 1;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // SlideBar
            // 
            this.SlideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlideBar.BackgroundImage")));
            this.SlideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideBar.Controls.Add(this.bunifuFlatButton2);
            this.SlideBar.Controls.Add(this.HabitacionesClick);
            this.SlideBar.Controls.Add(this.bunifuFlatButton1);
            this.SlideBar.Controls.Add(this.ReservacionButton);
            this.SlideBar.Controls.Add(this.Linea);
            this.SlideBar.Controls.Add(this.MenuSlide);
            this.SlideBar.Controls.Add(this.Logo);
            this.AnimacionSliderBarRegreso.SetDecoration(this.SlideBar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.SlideBar, BunifuAnimatorNS.DecorationType.None);
            this.SlideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SlideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SlideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.SlideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SlideBar.Location = new System.Drawing.Point(16, 21);
            this.SlideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SlideBar.Name = "SlideBar";
            this.SlideBar.Quality = 10;
            this.SlideBar.Size = new System.Drawing.Size(360, 965);
            this.SlideBar.TabIndex = 3;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(12, 453);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(321, 59);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "bunifuFlatButton2";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // HabitacionesClick
            // 
            this.HabitacionesClick.Activecolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.BackColor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HabitacionesClick.BorderRadius = 0;
            this.HabitacionesClick.ButtonText = "   Habitaciones";
            this.HabitacionesClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.HabitacionesClick, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.HabitacionesClick, BunifuAnimatorNS.DecorationType.None);
            this.HabitacionesClick.DisabledColor = System.Drawing.Color.Gray;
            this.HabitacionesClick.Iconcolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.Iconimage = global::BancoSangre.Properties.Resources.habitacion__1_;
            this.HabitacionesClick.Iconimage_right = null;
            this.HabitacionesClick.Iconimage_right_Selected = null;
            this.HabitacionesClick.Iconimage_Selected = null;
            this.HabitacionesClick.IconMarginLeft = 0;
            this.HabitacionesClick.IconMarginRight = 0;
            this.HabitacionesClick.IconRightVisible = true;
            this.HabitacionesClick.IconRightZoom = 0D;
            this.HabitacionesClick.IconVisible = true;
            this.HabitacionesClick.IconZoom = 90D;
            this.HabitacionesClick.IsTab = false;
            this.HabitacionesClick.Location = new System.Drawing.Point(12, 336);
            this.HabitacionesClick.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.HabitacionesClick.Name = "HabitacionesClick";
            this.HabitacionesClick.Normalcolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.OnHovercolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.OnHoverTextColor = System.Drawing.Color.White;
            this.HabitacionesClick.selected = false;
            this.HabitacionesClick.Size = new System.Drawing.Size(336, 59);
            this.HabitacionesClick.TabIndex = 4;
            this.HabitacionesClick.Text = "   Habitaciones";
            this.HabitacionesClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HabitacionesClick.Textcolor = System.Drawing.Color.LightGray;
            this.HabitacionesClick.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HabitacionesClick.Click += new System.EventHandler(this.HabitacionesClick_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Listado de clientes";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::BancoSangre.Properties.Resources.User_Groups_48px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 244);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(336, 59);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "   Listado de clientes";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // ReservacionButton
            // 
            this.ReservacionButton.Activecolor = System.Drawing.Color.Transparent;
            this.ReservacionButton.BackColor = System.Drawing.Color.Transparent;
            this.ReservacionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReservacionButton.BorderRadius = 0;
            this.ReservacionButton.ButtonText = "   Reservaciones";
            this.ReservacionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.ReservacionButton, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.ReservacionButton, BunifuAnimatorNS.DecorationType.None);
            this.ReservacionButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReservacionButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReservacionButton.Iconimage = global::BancoSangre.Properties.Resources.UsuarioBlanco;
            this.ReservacionButton.Iconimage_right = null;
            this.ReservacionButton.Iconimage_right_Selected = null;
            this.ReservacionButton.Iconimage_Selected = null;
            this.ReservacionButton.IconMarginLeft = 0;
            this.ReservacionButton.IconMarginRight = 0;
            this.ReservacionButton.IconRightVisible = true;
            this.ReservacionButton.IconRightZoom = 0D;
            this.ReservacionButton.IconVisible = true;
            this.ReservacionButton.IconZoom = 90D;
            this.ReservacionButton.IsTab = false;
            this.ReservacionButton.Location = new System.Drawing.Point(12, 148);
            this.ReservacionButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ReservacionButton.Name = "ReservacionButton";
            this.ReservacionButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ReservacionButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ReservacionButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ReservacionButton.selected = false;
            this.ReservacionButton.Size = new System.Drawing.Size(336, 59);
            this.ReservacionButton.TabIndex = 4;
            this.ReservacionButton.Text = "   Reservaciones";
            this.ReservacionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReservacionButton.Textcolor = System.Drawing.Color.LightGray;
            this.ReservacionButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservacionButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Linea
            // 
            this.Linea.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSliderBarRegreso.SetDecoration(this.Linea, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.Linea, BunifuAnimatorNS.DecorationType.None);
            this.Linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Linea.LineThickness = 1;
            this.Linea.Location = new System.Drawing.Point(12, 98);
            this.Linea.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(336, 1);
            this.Linea.TabIndex = 0;
            this.Linea.Transparency = 255;
            this.Linea.Vertical = false;
            // 
            // MenuSlide
            // 
            this.MenuSlide.AutoSize = true;
            this.MenuSlide.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSideBar.SetDecoration(this.MenuSlide, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.MenuSlide, BunifuAnimatorNS.DecorationType.None);
            this.MenuSlide.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSlide.ForeColor = System.Drawing.Color.White;
            this.MenuSlide.Location = new System.Drawing.Point(100, 39);
            this.MenuSlide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MenuSlide.Name = "MenuSlide";
            this.MenuSlide.Size = new System.Drawing.Size(69, 30);
            this.MenuSlide.TabIndex = 3;
            this.MenuSlide.Text = "Menù";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSideBar.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::BancoSangre.Properties.Resources.Hotel_Blanco;
            this.Logo.Location = new System.Drawing.Point(7, 12);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 70);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.RayitasMenu_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Panel3.Controls.Add(this.PanelTodo);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Panel3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.Panel3, BunifuAnimatorNS.DecorationType.None);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(400, 98);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1062, 824);
            this.Panel3.TabIndex = 2;
            // 
            // PanelTodo
            // 
            this.PanelTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelTodo.Controls.Add(this.label1);
            this.PanelTodo.Controls.Add(this.pictureBox1);
            this.AnimacionSliderBarRegreso.SetDecoration(this.PanelTodo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.PanelTodo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTodo.Location = new System.Drawing.Point(25, 21);
            this.PanelTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelTodo.Name = "PanelTodo";
            this.PanelTodo.Size = new System.Drawing.Size(1022, 788);
            this.PanelTodo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.AnimacionSideBar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(712, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotelito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSideBar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::BancoSangre.Properties.Resources.Hotel_Blanco;
            this.pictureBox1.Location = new System.Drawing.Point(685, 310);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AnimacionSideBar
            // 
            this.AnimacionSideBar.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacionSideBar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.AnimacionSideBar.DefaultAnimation = animation1;
            // 
            // AnimacionSliderBarRegreso
            // 
            this.AnimacionSliderBarRegreso.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionSliderBarRegreso.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSliderBarRegreso.DefaultAnimation = animation2;
            // 
            // MoverPrograma
            // 
            this.MoverPrograma.Fixed = true;
            this.MoverPrograma.Horizontal = true;
            this.MoverPrograma.TargetControl = this.Panel1;
            this.MoverPrograma.Vertical = true;
            // 
            // RadioPanelTotal
            // 
            this.RadioPanelTotal.ElipseRadius = 7;
            this.RadioPanelTotal.TargetControl = this.PanelTodo;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 922);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.AnimacionSliderBarRegreso.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RayitasMenu)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.SlideBar.ResumeLayout(false);
            this.SlideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.PanelTodo.ResumeLayout(false);
            this.PanelTodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label Labio;
        private System.Windows.Forms.PictureBox RayitasMenu;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private Bunifu.Framework.UI.BunifuGradientPanel SlideBar;
        private Bunifu.Framework.UI.BunifuSeparator Linea;
        private System.Windows.Forms.Label MenuSlide;
        private Bunifu.Framework.UI.BunifuFlatButton ReservacionButton;
        private Bunifu.Framework.UI.BunifuFlatButton HabitacionesClick;
        private System.Windows.Forms.PictureBox Logo;
        private BunifuAnimatorNS.BunifuTransition AnimacionSideBar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSliderBarRegreso;
        private System.Windows.Forms.Panel PanelTodo;
        private Bunifu.Framework.UI.BunifuDragControl MoverPrograma;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelTotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

