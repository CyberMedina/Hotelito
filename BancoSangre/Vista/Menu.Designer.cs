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
            this.txtInfo = new System.Windows.Forms.Label();
            this.Labio = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.PanelTodo = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AnimacionSideBar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSliderBarRegreso = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverPrograma = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RadioPanelTotal = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SlideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.HabitacionesClick = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReservacionButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.MenuSlide = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.RayitasMenu = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.PanelTodo.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SlideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RayitasMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Panel1.Controls.Add(this.txtInfo);
            this.Panel1.Controls.Add(this.pictureBox2);
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
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1378, 80);
            this.Panel1.TabIndex = 0;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.AnimacionSideBar.SetDecoration(this.txtInfo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.txtInfo, BunifuAnimatorNS.DecorationType.None);
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point(198, 33);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(0, 20);
            this.txtInfo.TabIndex = 4;
            // 
            // Labio
            // 
            this.Labio.AutoSize = true;
            this.AnimacionSideBar.SetDecoration(this.Labio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Labio, BunifuAnimatorNS.DecorationType.None);
            this.Labio.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labio.ForeColor = System.Drawing.Color.White;
            this.Labio.Location = new System.Drawing.Point(48, 19);
            this.Labio.Name = "Labio";
            this.Labio.Size = new System.Drawing.Size(71, 22);
            this.Labio.TabIndex = 0;
            this.Labio.Text = "Hotelito";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel2.Controls.Add(this.LabelFecha);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.SlideBar);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Panel2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.Panel2, BunifuAnimatorNS.DecorationType.None);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel2.Location = new System.Drawing.Point(0, 80);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 700);
            this.Panel2.TabIndex = 1;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.AnimacionSideBar.SetDecoration(this.LabelFecha, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.LabelFecha, BunifuAnimatorNS.DecorationType.None);
            this.LabelFecha.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFecha.ForeColor = System.Drawing.Color.White;
            this.LabelFecha.Location = new System.Drawing.Point(100, 2);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(50, 20);
            this.LabelFecha.TabIndex = 5;
            this.LabelFecha.Text = "label2";
            this.LabelFecha.Click += new System.EventHandler(this.LabelFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.AnimacionSideBar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha y Hora: ";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Panel3.Controls.Add(this.PanelTodo);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Panel3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.Panel3, BunifuAnimatorNS.DecorationType.None);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(300, 80);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1078, 700);
            this.Panel3.TabIndex = 2;
            // 
            // PanelTodo
            // 
            this.PanelTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelTodo.Controls.Add(this.panel5);
            this.AnimacionSliderBarRegreso.SetDecoration(this.PanelTodo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.PanelTodo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTodo.Location = new System.Drawing.Point(19, 25);
            this.PanelTodo.Name = "PanelTodo";
            this.PanelTodo.Size = new System.Drawing.Size(1048, 663);
            this.PanelTodo.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.AnimacionSliderBarRegreso.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(450, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 243);
            this.panel5.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(86, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotelito";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSideBar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::BancoSangre.Properties.Resources.Hotel_Blanco;
            this.pictureBox1.Location = new System.Drawing.Point(41, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SlideBar
            // 
            this.SlideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlideBar.BackgroundImage")));
            this.SlideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideBar.Controls.Add(this.bunifuFlatButton5);
            this.SlideBar.Controls.Add(this.bunifuFlatButton4);
            this.SlideBar.Controls.Add(this.bunifuFlatButton3);
            this.SlideBar.Controls.Add(this.bunifuFlatButton2);
            this.SlideBar.Controls.Add(this.panel4);
            this.SlideBar.Controls.Add(this.bunifuFlatButton1);
            this.SlideBar.Controls.Add(this.HabitacionesClick);
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
            this.SlideBar.Location = new System.Drawing.Point(12, 25);
            this.SlideBar.Name = "SlideBar";
            this.SlideBar.Quality = 10;
            this.SlideBar.Size = new System.Drawing.Size(270, 776);
            this.SlideBar.TabIndex = 3;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "    Salir";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::BancoSangre.Properties.Resources.cerrar_sesion;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(10, 587);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(179, 38);
            this.bunifuFlatButton5.TabIndex = 10;
            this.bunifuFlatButton5.Text = "    Salir";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.SystemColors.Window;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Goldenrod;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "   Clase Alta";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::BancoSangre.Properties.Resources.ClaseAlta;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(10, 373);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(179, 48);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.Text = "   Clase Alta";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.MediumAquamarine;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "   Accesibles";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::BancoSangre.Properties.Resources.Clasemedia;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(9, 301);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(179, 48);
            this.bunifuFlatButton3.TabIndex = 8;
            this.bunifuFlatButton3.Text = "   Accesibles";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "   Economica";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::BancoSangre.Properties.Resources.Clasebaja2;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(10, 237);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(179, 48);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "   Economica";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.AnimacionSliderBarRegreso.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(25, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 175);
            this.panel4.TabIndex = 2;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Reservas";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSideBar.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::BancoSangre.Properties.Resources.grupo;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 120D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 444);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(251, 60);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "   Reservas";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
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
            this.HabitacionesClick.DisabledColor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.Enabled = false;
            this.HabitacionesClick.Iconcolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.Iconimage = global::BancoSangre.Properties.Resources.cama__1_;
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
            this.HabitacionesClick.Location = new System.Drawing.Point(9, 183);
            this.HabitacionesClick.Name = "HabitacionesClick";
            this.HabitacionesClick.Normalcolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.OnHovercolor = System.Drawing.Color.Transparent;
            this.HabitacionesClick.OnHoverTextColor = System.Drawing.Color.White;
            this.HabitacionesClick.selected = false;
            this.HabitacionesClick.Size = new System.Drawing.Size(252, 48);
            this.HabitacionesClick.TabIndex = 4;
            this.HabitacionesClick.Text = "   Habitaciones";
            this.HabitacionesClick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HabitacionesClick.Textcolor = System.Drawing.Color.LightGray;
            this.HabitacionesClick.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ReservacionButton.Iconimage = global::BancoSangre.Properties.Resources.usuario;
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
            this.ReservacionButton.Location = new System.Drawing.Point(9, 120);
            this.ReservacionButton.Name = "ReservacionButton";
            this.ReservacionButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ReservacionButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.ReservacionButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ReservacionButton.selected = false;
            this.ReservacionButton.Size = new System.Drawing.Size(252, 48);
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
            this.Linea.Location = new System.Drawing.Point(9, 80);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(252, 1);
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
            this.MenuSlide.Location = new System.Drawing.Point(75, 32);
            this.MenuSlide.Name = "MenuSlide";
            this.MenuSlide.Size = new System.Drawing.Size(54, 22);
            this.MenuSlide.TabIndex = 3;
            this.MenuSlide.Text = "Menú";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSideBar.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::BancoSangre.Properties.Resources.Hotel_Blanco;
            this.Logo.Location = new System.Drawing.Point(5, 10);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 57);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.AnimacionSideBar.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::BancoSangre.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(137, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSideBar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1300, 19);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
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
            this.Minimizar.Location = new System.Drawing.Point(1264, 19);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
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
            this.Maximizar.Location = new System.Drawing.Point(1300, 19);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
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
            this.Salir.Location = new System.Drawing.Point(1336, 19);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 1;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // RayitasMenu
            // 
            this.AnimacionSideBar.SetDecoration(this.RayitasMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSliderBarRegreso.SetDecoration(this.RayitasMenu, BunifuAnimatorNS.DecorationType.None);
            this.RayitasMenu.Image = ((System.Drawing.Image)(resources.GetObject("RayitasMenu.Image")));
            this.RayitasMenu.Location = new System.Drawing.Point(12, 12);
            this.RayitasMenu.Name = "RayitasMenu";
            this.RayitasMenu.Size = new System.Drawing.Size(30, 30);
            this.RayitasMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RayitasMenu.TabIndex = 0;
            this.RayitasMenu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.AnimacionSliderBarRegreso.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSideBar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.PanelTodo.ResumeLayout(false);
            this.PanelTodo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SlideBar.ResumeLayout(false);
            this.SlideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RayitasMenu)).EndInit();
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
        private Bunifu.Framework.UI.BunifuDragControl MoverPrograma;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelTotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtInfo;
        public System.Windows.Forms.Panel PanelTodo;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
    }
}

