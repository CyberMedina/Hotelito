namespace BancoSangre.Vista
{
    partial class BotonSalir
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Está seguro que desea salír?";
            // 
            // buttonsi
            // 
            this.buttonsi.BackColor = System.Drawing.Color.Red;
            this.buttonsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsi.ForeColor = System.Drawing.Color.White;
            this.buttonsi.Location = new System.Drawing.Point(101, 53);
            this.buttonsi.Name = "buttonsi";
            this.buttonsi.Size = new System.Drawing.Size(63, 33);
            this.buttonsi.TabIndex = 1;
            this.buttonsi.Text = "Sí";
            this.buttonsi.UseVisualStyleBackColor = false;
            this.buttonsi.Click += new System.EventHandler(this.buttonsi_Click);
            // 
            // BotonSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(274, 110);
            this.Controls.Add(this.buttonsi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotonSalir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonsi;
    }
}