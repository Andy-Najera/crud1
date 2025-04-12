namespace WindowsFormsApp1
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
            this.cnet = new System.Windows.Forms.Label();
            this.btonsaludar = new System.Windows.Forms.Button();
            this.Nmbre = new System.Windows.Forms.Label();
            this.Crreo = new System.Windows.Forms.Label();
            this.Sccion = new System.Windows.Forms.Label();
            this.textBoxCnet = new System.Windows.Forms.TextBox();
            this.textBoxNmbre = new System.Windows.Forms.TextBox();
            this.textBoxCrreo = new System.Windows.Forms.TextBox();
            this.buttonbscar = new System.Windows.Forms.Button();
            this.buttonRgistrar = new System.Windows.Forms.Button();
            this.comboBoxSccion = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cnet
            // 
            this.cnet.AutoSize = true;
            this.cnet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cnet.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnet.ForeColor = System.Drawing.Color.Red;
            this.cnet.Location = new System.Drawing.Point(155, 26);
            this.cnet.Name = "cnet";
            this.cnet.Size = new System.Drawing.Size(47, 15);
            this.cnet.TabIndex = 0;
            this.cnet.Text = "Carnet ";
            this.cnet.Click += new System.EventHandler(this.cnet_Click);
            // 
            // btonsaludar
            // 
            this.btonsaludar.Location = new System.Drawing.Point(693, 335);
            this.btonsaludar.Name = "btonsaludar";
            this.btonsaludar.Size = new System.Drawing.Size(69, 27);
            this.btonsaludar.TabIndex = 2;
            this.btonsaludar.Text = "Tocame";
            this.btonsaludar.UseVisualStyleBackColor = true;
            this.btonsaludar.Click += new System.EventHandler(this.btonsaludar_Click);
            // 
            // Nmbre
            // 
            this.Nmbre.AutoSize = true;
            this.Nmbre.BackColor = System.Drawing.Color.Black;
            this.Nmbre.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nmbre.Location = new System.Drawing.Point(155, 86);
            this.Nmbre.Name = "Nmbre";
            this.Nmbre.Size = new System.Drawing.Size(73, 17);
            this.Nmbre.TabIndex = 3;
            this.Nmbre.Text = "Nombre ";
            // 
            // Crreo
            // 
            this.Crreo.AutoSize = true;
            this.Crreo.Location = new System.Drawing.Point(155, 145);
            this.Crreo.Name = "Crreo";
            this.Crreo.Size = new System.Drawing.Size(51, 16);
            this.Crreo.TabIndex = 4;
            this.Crreo.Text = "Correo ";
            // 
            // Sccion
            // 
            this.Sccion.AutoSize = true;
            this.Sccion.Location = new System.Drawing.Point(155, 216);
            this.Sccion.Name = "Sccion";
            this.Sccion.Size = new System.Drawing.Size(59, 16);
            this.Sccion.TabIndex = 5;
            this.Sccion.Text = "Seccion ";
            // 
            // textBoxCnet
            // 
            this.textBoxCnet.Location = new System.Drawing.Point(269, 26);
            this.textBoxCnet.Name = "textBoxCnet";
            this.textBoxCnet.Size = new System.Drawing.Size(143, 22);
            this.textBoxCnet.TabIndex = 6;
            // 
            // textBoxNmbre
            // 
            this.textBoxNmbre.Location = new System.Drawing.Point(269, 86);
            this.textBoxNmbre.Name = "textBoxNmbre";
            this.textBoxNmbre.Size = new System.Drawing.Size(284, 22);
            this.textBoxNmbre.TabIndex = 7;
            // 
            // textBoxCrreo
            // 
            this.textBoxCrreo.Location = new System.Drawing.Point(269, 139);
            this.textBoxCrreo.Name = "textBoxCrreo";
            this.textBoxCrreo.Size = new System.Drawing.Size(143, 22);
            this.textBoxCrreo.TabIndex = 8;
            // 
            // buttonbscar
            // 
            this.buttonbscar.Font = new System.Drawing.Font("Modern No. 20", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbscar.Location = new System.Drawing.Point(463, 26);
            this.buttonbscar.Name = "buttonbscar";
            this.buttonbscar.Size = new System.Drawing.Size(131, 22);
            this.buttonbscar.TabIndex = 10;
            this.buttonbscar.Text = "Buscar ";
            this.buttonbscar.UseVisualStyleBackColor = true;
            this.buttonbscar.Click += new System.EventHandler(this.buttonbscar_Click);
            // 
            // buttonRgistrar
            // 
            this.buttonRgistrar.BackColor = System.Drawing.Color.Blue;
            this.buttonRgistrar.Font = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRgistrar.ForeColor = System.Drawing.Color.Yellow;
            this.buttonRgistrar.Location = new System.Drawing.Point(490, 216);
            this.buttonRgistrar.Name = "buttonRgistrar";
            this.buttonRgistrar.Size = new System.Drawing.Size(131, 45);
            this.buttonRgistrar.TabIndex = 11;
            this.buttonRgistrar.Text = "Crear Registro ";
            this.buttonRgistrar.UseVisualStyleBackColor = false;
            this.buttonRgistrar.Click += new System.EventHandler(this.buttonRgistrar_Click);
            // 
            // comboBoxSccion
            // 
            this.comboBoxSccion.FormattingEnabled = true;
            this.comboBoxSccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxSccion.Location = new System.Drawing.Point(269, 208);
            this.comboBoxSccion.Name = "comboBoxSccion";
            this.comboBoxSccion.Size = new System.Drawing.Size(71, 24);
            this.comboBoxSccion.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.fondo_imagen;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(774, 374);
            this.Controls.Add(this.comboBoxSccion);
            this.Controls.Add(this.buttonRgistrar);
            this.Controls.Add(this.buttonbscar);
            this.Controls.Add(this.textBoxCrreo);
            this.Controls.Add(this.textBoxNmbre);
            this.Controls.Add(this.textBoxCnet);
            this.Controls.Add(this.Sccion);
            this.Controls.Add(this.Crreo);
            this.Controls.Add(this.Nmbre);
            this.Controls.Add(this.btonsaludar);
            this.Controls.Add(this.cnet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cnet;
        private System.Windows.Forms.Button btonsaludar;
        private System.Windows.Forms.Label Nmbre;
        private System.Windows.Forms.Label Crreo;
        private System.Windows.Forms.Label Sccion;
        private System.Windows.Forms.TextBox textBoxCnet;
        private System.Windows.Forms.TextBox textBoxNmbre;
        private System.Windows.Forms.TextBox textBoxCrreo;
        private System.Windows.Forms.Button buttonbscar;
        private System.Windows.Forms.Button buttonRgistrar;
        private System.Windows.Forms.ComboBox comboBoxSccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

