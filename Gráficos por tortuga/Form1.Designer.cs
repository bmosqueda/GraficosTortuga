namespace Gráficos_por_tortuga
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
            this.txtTablero = new System.Windows.Forms.RichTextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRigth = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.numAvance = new System.Windows.Forms.NumericUpDown();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPlumaSatate = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.btnPlumaAbajo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDatos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAvance)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTablero
            // 
            this.txtTablero.Location = new System.Drawing.Point(22, 24);
            this.txtTablero.Name = "txtTablero";
            this.txtTablero.Size = new System.Drawing.Size(524, 481);
            this.txtTablero.TabIndex = 0;
            this.txtTablero.Text = "";
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::Gráficos_por_tortuga.Properties.Resources.icoUp;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Location = new System.Drawing.Point(678, 157);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(70, 90);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = global::Gráficos_por_tortuga.Properties.Resources.icoDown;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Location = new System.Drawing.Point(678, 378);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(70, 90);
            this.btnDown.TabIndex = 2;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRigth
            // 
            this.btnRigth.BackgroundImage = global::Gráficos_por_tortuga.Properties.Resources.icoRigth;
            this.btnRigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRigth.Location = new System.Drawing.Point(785, 289);
            this.btnRigth.Name = "btnRigth";
            this.btnRigth.Size = new System.Drawing.Size(90, 70);
            this.btnRigth.TabIndex = 3;
            this.btnRigth.UseVisualStyleBackColor = true;
            this.btnRigth.Click += new System.EventHandler(this.btnRigth_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::Gráficos_por_tortuga.Properties.Resources.icoLeft;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.Location = new System.Drawing.Point(563, 289);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(90, 70);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSize = true;
            this.btnMostrar.Location = new System.Drawing.Point(765, 399);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(156, 48);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // numAvance
            // 
            this.numAvance.Location = new System.Drawing.Point(668, 333);
            this.numAvance.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAvance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAvance.Name = "numAvance";
            this.numAvance.Size = new System.Drawing.Size(99, 26);
            this.numAvance.TabIndex = 6;
            this.numAvance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.AutoSize = true;
            this.btnAvanzar.Location = new System.Drawing.Point(659, 279);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(111, 48);
            this.btnAvanzar.TabIndex = 7;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.toolStripStatusLabel1,
            this.lblPlumaSatate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 17);
            this.lblEstado.Text = "Derecha";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(793, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblPlumaSatate
            // 
            this.lblPlumaSatate.Name = "lblPlumaSatate";
            this.lblPlumaSatate.Size = new System.Drawing.Size(74, 17);
            this.lblPlumaSatate.Text = "Pluma arriba";
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.AutoSize = true;
            this.btnPlumaArriba.Location = new System.Drawing.Point(22, 37);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(111, 48);
            this.btnPlumaArriba.TabIndex = 9;
            this.btnPlumaArriba.Text = "Arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // btnPlumaAbajo
            // 
            this.btnPlumaAbajo.AutoSize = true;
            this.btnPlumaAbajo.Location = new System.Drawing.Point(150, 37);
            this.btnPlumaAbajo.Name = "btnPlumaAbajo";
            this.btnPlumaAbajo.Size = new System.Drawing.Size(111, 48);
            this.btnPlumaAbajo.TabIndex = 10;
            this.btnPlumaAbajo.Text = "Abajo";
            this.btnPlumaAbajo.UseVisualStyleBackColor = true;
            this.btnPlumaAbajo.Click += new System.EventHandler(this.btnPlumaAbajo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlumaArriba);
            this.groupBox1.Controls.Add(this.btnPlumaAbajo);
            this.groupBox1.Location = new System.Drawing.Point(587, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pluma";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(583, 177);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(43, 20);
            this.lblCoordenadas.TabIndex = 12;
            this.lblCoordenadas.Text = "[0, 0]";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(176, 542);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(744, 26);
            this.txtDatos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vector movimientos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "1, 2, 6, 3 (No importa si tiene espacios)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "1 Pluma arriba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "5: avance  Avanza x espacios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "4 Gira izquierda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "3 Gira derecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "2 Pluma abajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "6 Imprime el tablero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "7 Fin de datos";
            // 
            // btnDatos
            // 
            this.btnDatos.AutoSize = true;
            this.btnDatos.Location = new System.Drawing.Point(446, 574);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(156, 44);
            this.btnDatos.TabIndex = 23;
            this.btnDatos.Text = "Mover por datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 586);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "5: 10 (Ej. Avanzar 10 casillas)";
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(807, 482);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 37);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset tablero";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tortuga pos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 654);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.numAvance);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRigth);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtTablero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tortuga";
            ((System.ComponentModel.ISupportInitialize)(this.numAvance)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtTablero;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRigth;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.NumericUpDown numAvance;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.Button btnPlumaAbajo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblPlumaSatate;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label11;
    }
}

