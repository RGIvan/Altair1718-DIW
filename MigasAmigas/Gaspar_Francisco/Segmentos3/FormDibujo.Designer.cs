namespace Segmentos3
{
    partial class FormDibujo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFinal = new System.Windows.Forms.RadioButton();
            this.txbYF = new System.Windows.Forms.TextBox();
            this.lbY1 = new System.Windows.Forms.Label();
            this.txbXF = new System.Windows.Forms.TextBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.rbOrigen = new System.Windows.Forms.RadioButton();
            this.btnConectaAnterior = new System.Windows.Forms.Button();
            this.lbColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGrosor = new System.Windows.Forms.NumericUpDown();
            this.txbY0 = new System.Windows.Forms.TextBox();
            this.lbY0 = new System.Windows.Forms.Label();
            this.txbX0 = new System.Windows.Forms.TextBox();
            this.lbX0 = new System.Windows.Forms.Label();
            this.tracX = new System.Windows.Forms.TrackBar();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.tracY = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConectaPtos = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbColorFondo = new System.Windows.Forms.GroupBox();
            this.chbAzul = new System.Windows.Forms.CheckBox();
            this.chbVerde = new System.Windows.Forms.CheckBox();
            this.chbRojo = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracY)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grbColorFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rbFinal);
            this.groupBox1.Controls.Add(this.txbYF);
            this.groupBox1.Controls.Add(this.lbY1);
            this.groupBox1.Controls.Add(this.txbXF);
            this.groupBox1.Controls.Add(this.lbX1);
            this.groupBox1.Controls.Add(this.rbOrigen);
            this.groupBox1.Controls.Add(this.btnConectaAnterior);
            this.groupBox1.Controls.Add(this.lbColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudGrosor);
            this.groupBox1.Controls.Add(this.txbY0);
            this.groupBox1.Controls.Add(this.lbY0);
            this.groupBox1.Controls.Add(this.txbX0);
            this.groupBox1.Controls.Add(this.lbX0);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(523, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 265);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propiedades del Segmento";
            // 
            // rbFinal
            // 
            this.rbFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFinal.ForeColor = System.Drawing.Color.White;
            this.rbFinal.Location = new System.Drawing.Point(156, 82);
            this.rbFinal.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.rbFinal.Name = "rbFinal";
            this.rbFinal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbFinal.Size = new System.Drawing.Size(116, 25);
            this.rbFinal.TabIndex = 44;
            this.rbFinal.Text = "Pto. Final";
            this.rbFinal.UseVisualStyleBackColor = false;
            // 
            // txbYF
            // 
            this.txbYF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txbYF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbYF.ForeColor = System.Drawing.Color.White;
            this.txbYF.Location = new System.Drawing.Point(219, 47);
            this.txbYF.MaxLength = 3;
            this.txbYF.Name = "txbYF";
            this.txbYF.Size = new System.Drawing.Size(57, 29);
            this.txbYF.TabIndex = 43;
            this.txbYF.Text = "0";
            this.txbYF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbY1
            // 
            this.lbY1.AutoSize = true;
            this.lbY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY1.ForeColor = System.Drawing.Color.White;
            this.lbY1.Location = new System.Drawing.Point(240, 31);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(17, 17);
            this.lbY1.TabIndex = 42;
            this.lbY1.Text = "Y";
            // 
            // txbXF
            // 
            this.txbXF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txbXF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbXF.ForeColor = System.Drawing.Color.White;
            this.txbXF.Location = new System.Drawing.Point(156, 47);
            this.txbXF.MaxLength = 3;
            this.txbXF.Name = "txbXF";
            this.txbXF.Size = new System.Drawing.Size(57, 29);
            this.txbXF.TabIndex = 41;
            this.txbXF.Text = "0";
            this.txbXF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX1.ForeColor = System.Drawing.Color.White;
            this.lbX1.Location = new System.Drawing.Point(177, 31);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(17, 17);
            this.lbX1.TabIndex = 40;
            this.lbX1.Text = "X";
            // 
            // rbOrigen
            // 
            this.rbOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbOrigen.Checked = true;
            this.rbOrigen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrigen.ForeColor = System.Drawing.Color.White;
            this.rbOrigen.Location = new System.Drawing.Point(15, 82);
            this.rbOrigen.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.rbOrigen.Name = "rbOrigen";
            this.rbOrigen.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.rbOrigen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOrigen.Size = new System.Drawing.Size(115, 25);
            this.rbOrigen.TabIndex = 39;
            this.rbOrigen.TabStop = true;
            this.rbOrigen.Text = "Pto. Origen";
            this.rbOrigen.UseVisualStyleBackColor = false;
            // 
            // btnConectaAnterior
            // 
            this.btnConectaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectaAnterior.Location = new System.Drawing.Point(41, 124);
            this.btnConectaAnterior.Name = "btnConectaAnterior";
            this.btnConectaAnterior.Size = new System.Drawing.Size(198, 26);
            this.btnConectaAnterior.TabIndex = 34;
            this.btnConectaAnterior.Text = "Nuevo Origen = Final Actual";
            this.btnConectaAnterior.UseVisualStyleBackColor = true;
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.Black;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbColor.ForeColor = System.Drawing.Color.White;
            this.lbColor.Location = new System.Drawing.Point(152, 169);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(108, 55);
            this.lbColor.TabIndex = 33;
            this.lbColor.Text = "Color";
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Grosor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudGrosor
            // 
            this.nudGrosor.BackColor = System.Drawing.Color.Blue;
            this.nudGrosor.DecimalPlaces = 1;
            this.nudGrosor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nudGrosor.ForeColor = System.Drawing.Color.White;
            this.nudGrosor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudGrosor.Location = new System.Drawing.Point(37, 195);
            this.nudGrosor.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrosor.Name = "nudGrosor";
            this.nudGrosor.Size = new System.Drawing.Size(75, 29);
            this.nudGrosor.TabIndex = 24;
            this.nudGrosor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txbY0
            // 
            this.txbY0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbY0.ForeColor = System.Drawing.Color.White;
            this.txbY0.Location = new System.Drawing.Point(74, 47);
            this.txbY0.MaxLength = 3;
            this.txbY0.Name = "txbY0";
            this.txbY0.Size = new System.Drawing.Size(57, 29);
            this.txbY0.TabIndex = 22;
            this.txbY0.Text = "0";
            this.txbY0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbY0
            // 
            this.lbY0.AutoSize = true;
            this.lbY0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY0.ForeColor = System.Drawing.Color.White;
            this.lbY0.Location = new System.Drawing.Point(95, 31);
            this.lbY0.Name = "lbY0";
            this.lbY0.Size = new System.Drawing.Size(17, 17);
            this.lbY0.TabIndex = 21;
            this.lbY0.Text = "Y";
            // 
            // txbX0
            // 
            this.txbX0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbX0.ForeColor = System.Drawing.Color.White;
            this.txbX0.Location = new System.Drawing.Point(11, 47);
            this.txbX0.MaxLength = 3;
            this.txbX0.Name = "txbX0";
            this.txbX0.Size = new System.Drawing.Size(57, 29);
            this.txbX0.TabIndex = 20;
            this.txbX0.Text = "0";
            this.txbX0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbX0
            // 
            this.lbX0.AutoSize = true;
            this.lbX0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX0.ForeColor = System.Drawing.Color.White;
            this.lbX0.Location = new System.Drawing.Point(32, 31);
            this.lbX0.Name = "lbX0";
            this.lbX0.Size = new System.Drawing.Size(17, 17);
            this.lbX0.TabIndex = 19;
            this.lbX0.Text = "X";
            // 
            // tracX
            // 
            this.tracX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tracX.LargeChange = 50;
            this.tracX.Location = new System.Drawing.Point(39, 471);
            this.tracX.Maximum = 450;
            this.tracX.Name = "tracX";
            this.tracX.Size = new System.Drawing.Size(468, 45);
            this.tracX.SmallChange = 10;
            this.tracX.TabIndex = 22;
            this.tracX.TickFrequency = 10;
            this.tracX.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDibujo.Location = new System.Drawing.Point(50, 21);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(450, 450);
            this.panelDibujo.TabIndex = 21;
            // 
            // tracY
            // 
            this.tracY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tracY.LargeChange = 50;
            this.tracY.Location = new System.Drawing.Point(15, 14);
            this.tracY.Maximum = 450;
            this.tracY.Name = "tracY";
            this.tracY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tracY.Size = new System.Drawing.Size(45, 468);
            this.tracY.SmallChange = 10;
            this.tracY.TabIndex = 23;
            this.tracY.TabStop = false;
            this.tracY.TickFrequency = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnConectaPtos);
            this.groupBox2.Controls.Add(this.btnDibujar);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(523, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 153);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnConectaPtos
            // 
            this.btnConectaPtos.Enabled = false;
            this.btnConectaPtos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectaPtos.Location = new System.Drawing.Point(24, 97);
            this.btnConectaPtos.Name = "btnConectaPtos";
            this.btnConectaPtos.Size = new System.Drawing.Size(261, 36);
            this.btnConectaPtos.TabIndex = 45;
            this.btnConectaPtos.Text = "Conectar Ptos. guardados";
            this.btnConectaPtos.UseVisualStyleBackColor = true;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(24, 28);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(150, 63);
            this.btnDibujar.TabIndex = 19;
            this.btnDibujar.Text = "Dibujar y Guardar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(191, 28);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 45);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // grbColorFondo
            // 
            this.grbColorFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbColorFondo.Controls.Add(this.chbAzul);
            this.grbColorFondo.Controls.Add(this.chbVerde);
            this.grbColorFondo.Controls.Add(this.chbRojo);
            this.grbColorFondo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbColorFondo.Location = new System.Drawing.Point(523, 451);
            this.grbColorFondo.Name = "grbColorFondo";
            this.grbColorFondo.Size = new System.Drawing.Size(300, 63);
            this.grbColorFondo.TabIndex = 48;
            this.grbColorFondo.TabStop = false;
            this.grbColorFondo.Text = "Color del Fondo";
            // 
            // chbAzul
            // 
            this.chbAzul.AutoSize = true;
            this.chbAzul.BackColor = System.Drawing.Color.Blue;
            this.chbAzul.ForeColor = System.Drawing.Color.White;
            this.chbAzul.Location = new System.Drawing.Point(214, 28);
            this.chbAzul.Name = "chbAzul";
            this.chbAzul.Size = new System.Drawing.Size(55, 20);
            this.chbAzul.TabIndex = 2;
            this.chbAzul.Text = "Azul";
            this.chbAzul.UseVisualStyleBackColor = false;
            // 
            // chbVerde
            // 
            this.chbVerde.AutoSize = true;
            this.chbVerde.BackColor = System.Drawing.Color.Lime;
            this.chbVerde.Location = new System.Drawing.Point(111, 30);
            this.chbVerde.Name = "chbVerde";
            this.chbVerde.Size = new System.Drawing.Size(64, 20);
            this.chbVerde.TabIndex = 1;
            this.chbVerde.Text = "Verde";
            this.chbVerde.UseVisualStyleBackColor = false;
            // 
            // chbRojo
            // 
            this.chbRojo.AutoSize = true;
            this.chbRojo.BackColor = System.Drawing.Color.Red;
            this.chbRojo.Location = new System.Drawing.Point(16, 28);
            this.chbRojo.Name = "chbRojo";
            this.chbRojo.Size = new System.Drawing.Size(56, 20);
            this.chbRojo.TabIndex = 0;
            this.chbRojo.Text = "Rojo";
            this.chbRojo.UseVisualStyleBackColor = false;
            // 
            // FormDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbColorFondo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tracX);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.tracY);
            this.Name = "FormDibujo";
            this.Text = "Dibujo de Segmentos (Apellidos, Nombre)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrosor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracY)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grbColorFondo.ResumeLayout(false);
            this.grbColorFondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFinal;
        private System.Windows.Forms.TextBox txbYF;
        private System.Windows.Forms.Label lbY1;
        private System.Windows.Forms.TextBox txbXF;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.RadioButton rbOrigen;
        private System.Windows.Forms.Button btnConectaAnterior;
        private System.Windows.Forms.TextBox txbY0;
        private System.Windows.Forms.Label lbY0;
        private System.Windows.Forms.TextBox txbX0;
        private System.Windows.Forms.Label lbX0;
        private System.Windows.Forms.TrackBar tracX;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.TrackBar tracY;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGrosor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConectaPtos;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox grbColorFondo;
        private System.Windows.Forms.CheckBox chbAzul;
        private System.Windows.Forms.CheckBox chbVerde;
        private System.Windows.Forms.CheckBox chbRojo;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

