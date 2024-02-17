namespace PaintPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxPapel = new System.Windows.Forms.PictureBox();
            this.btnBorrador = new System.Windows.Forms.Button();
            this.btnPincel = new System.Windows.Forms.Button();
            this.trackTamañoPincel = new System.Windows.Forms.TrackBar();
            this.picBoxNegro = new System.Windows.Forms.PictureBox();
            this.picBoxColor = new System.Windows.Forms.PictureBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTamaPincel = new System.Windows.Forms.Label();
            this.Circulo = new System.Windows.Forms.Button();
            this.Cuadrado = new System.Windows.Forms.Button();
            this.Triangulo = new System.Windows.Forms.Button();
            this.btnCargarFondo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTamañoPincel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNegro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPapel
            // 
            this.picBoxPapel.BackColor = System.Drawing.Color.White;
            this.picBoxPapel.Location = new System.Drawing.Point(262, 12);
            this.picBoxPapel.Name = "picBoxPapel";
            this.picBoxPapel.Size = new System.Drawing.Size(858, 628);
            this.picBoxPapel.TabIndex = 0;
            this.picBoxPapel.TabStop = false;
            this.picBoxPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseDown);
            this.picBoxPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseMove);
            this.picBoxPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxPapel_MouseUp);
            // 
            // btnBorrador
            // 
            this.btnBorrador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrador.BackgroundImage")));
            this.btnBorrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrador.Location = new System.Drawing.Point(59, 146);
            this.btnBorrador.Name = "btnBorrador";
            this.btnBorrador.Size = new System.Drawing.Size(50, 50);
            this.btnBorrador.TabIndex = 1;
            this.btnBorrador.UseVisualStyleBackColor = false;
            this.btnBorrador.Click += new System.EventHandler(this.btnBorrador_Click);
            // 
            // btnPincel
            // 
            this.btnPincel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPincel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPincel.BackgroundImage")));
            this.btnPincel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPincel.Location = new System.Drawing.Point(59, 88);
            this.btnPincel.Name = "btnPincel";
            this.btnPincel.Size = new System.Drawing.Size(50, 50);
            this.btnPincel.TabIndex = 2;
            this.btnPincel.UseVisualStyleBackColor = false;
            this.btnPincel.Click += new System.EventHandler(this.btnPincel_Click);
            // 
            // trackTamañoPincel
            // 
            this.trackTamañoPincel.BackColor = System.Drawing.SystemColors.Control;
            this.trackTamañoPincel.Location = new System.Drawing.Point(59, 197);
            this.trackTamañoPincel.Maximum = 20;
            this.trackTamañoPincel.Minimum = 1;
            this.trackTamañoPincel.Name = "trackTamañoPincel";
            this.trackTamañoPincel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackTamañoPincel.Size = new System.Drawing.Size(56, 130);
            this.trackTamañoPincel.TabIndex = 3;
            this.trackTamañoPincel.Value = 3;
            this.trackTamañoPincel.Scroll += new System.EventHandler(this.trackTamañoPincel_Scroll);
            // 
            // picBoxNegro
            // 
            this.picBoxNegro.BackColor = System.Drawing.Color.Black;
            this.picBoxNegro.Location = new System.Drawing.Point(58, 438);
            this.picBoxNegro.Name = "picBoxNegro";
            this.picBoxNegro.Size = new System.Drawing.Size(41, 41);
            this.picBoxNegro.TabIndex = 4;
            this.picBoxNegro.TabStop = false;
            this.picBoxNegro.Click += new System.EventHandler(this.picBoxNegro_Click);
            // 
            // picBoxColor
            // 
            this.picBoxColor.BackColor = System.Drawing.Color.Gray;
            this.picBoxColor.Location = new System.Drawing.Point(58, 370);
            this.picBoxColor.Name = "picBoxColor";
            this.picBoxColor.Size = new System.Drawing.Size(41, 41);
            this.picBoxColor.TabIndex = 5;
            this.picBoxColor.TabStop = false;
            this.picBoxColor.Click += new System.EventHandler(this.picBoxColor_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblR.Location = new System.Drawing.Point(122, 364);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(18, 20);
            this.lblR.TabIndex = 6;
            this.lblR.Text = "R";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblG.Location = new System.Drawing.Point(122, 416);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(18, 20);
            this.lblG.TabIndex = 7;
            this.lblG.Text = "G";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblB.Location = new System.Drawing.Point(122, 467);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 20);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "B";
            this.lblB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblB_MouseDown);
            this.lblB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblB_MouseUp);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(163, 361);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(53, 27);
            this.txtR.TabIndex = 9;
            this.txtR.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(163, 464);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(53, 27);
            this.txtB.TabIndex = 10;
            this.txtB.Text = "0";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(163, 409);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(53, 27);
            this.txtG.TabIndex = 11;
            this.txtG.Text = "0";
            // 
            // lblTamaPincel
            // 
            this.lblTamaPincel.AutoSize = true;
            this.lblTamaPincel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamaPincel.Location = new System.Drawing.Point(65, 327);
            this.lblTamaPincel.Name = "lblTamaPincel";
            this.lblTamaPincel.Size = new System.Drawing.Size(18, 20);
            this.lblTamaPincel.TabIndex = 0;
            this.lblTamaPincel.Text = "3";
            // 
            // Circulo
            // 
            this.Circulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Circulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Circulo.BackgroundImage")));
            this.Circulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Circulo.Location = new System.Drawing.Point(126, 88);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(50, 50);
            this.Circulo.TabIndex = 12;
            this.Circulo.UseVisualStyleBackColor = false;
            this.Circulo.Click += new System.EventHandler(this.Circulo_Click);
            // 
            // Cuadrado
            // 
            this.Cuadrado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cuadrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cuadrado.BackgroundImage")));
            this.Cuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cuadrado.Location = new System.Drawing.Point(126, 146);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(50, 50);
            this.Cuadrado.TabIndex = 13;
            this.Cuadrado.UseVisualStyleBackColor = false;
            this.Cuadrado.Click += new System.EventHandler(this.Cuadrado_Click);
            // 
            // Triangulo
            // 
            this.Triangulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Triangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Triangulo.BackgroundImage")));
            this.Triangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Triangulo.Location = new System.Drawing.Point(126, 210);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(50, 50);
            this.Triangulo.TabIndex = 14;
            this.Triangulo.UseVisualStyleBackColor = false;
            this.Triangulo.Click += new System.EventHandler(this.Triangulo_Click);
            // 
            // btnCargarFondo
            // 
            this.btnCargarFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarFondo.BackgroundImage")));
            this.btnCargarFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCargarFondo.Location = new System.Drawing.Point(148, 569);
            this.btnCargarFondo.Name = "btnCargarFondo";
            this.btnCargarFondo.Size = new System.Drawing.Size(50, 50);
            this.btnCargarFondo.TabIndex = 15;
            this.btnCargarFondo.UseVisualStyleBackColor = true;
            this.btnCargarFondo.Click += new System.EventHandler(this.btnCargarFondo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Location = new System.Drawing.Point(79, 569);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 46);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Paint";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargarFondo);
            this.Controls.Add(this.Triangulo);
            this.Controls.Add(this.Cuadrado);
            this.Controls.Add(this.Circulo);
            this.Controls.Add(this.lblTamaPincel);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.picBoxColor);
            this.Controls.Add(this.picBoxNegro);
            this.Controls.Add(this.trackTamañoPincel);
            this.Controls.Add(this.btnPincel);
            this.Controls.Add(this.btnBorrador);
            this.Controls.Add(this.picBoxPapel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTamañoPincel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNegro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxPapel;
        private Button btnBorrador;
        private Button btnPincel;
        private TrackBar trackTamañoPincel;
        private PictureBox picBoxNegro;
        private PictureBox picBoxColor;
        private Label lblR;
        private Label lblG;
        private Label lblB;
        private TextBox txtR;
        private TextBox txtB;
        private TextBox txtG;
        private ColorDialog colorDialog1;
        private Label lblTamaPincel;
        private Button Circulo;
        private Button Cuadrado;
        private Button Triangulo;
        private Button btnCargarFondo;
        private Button btnGuardar;
        private PictureBox pictureBox1;
        private Label label1;
    }
}