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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarExpediente = new System.Windows.Forms.Button();
            this.btnVerListado = new System.Windows.Forms.Button();
            this.btnMayores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.btnVerExpedientes = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerCausaPorNumero = new System.Windows.Forms.Button();
            this.tbNroCausa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMayores);
            this.groupBox1.Controls.Add(this.btnVerListado);
            this.groupBox1.Controls.Add(this.btnAgregarExpediente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expedientes";
            // 
            // btnAgregarExpediente
            // 
            this.btnAgregarExpediente.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarExpediente.Name = "btnAgregarExpediente";
            this.btnAgregarExpediente.Size = new System.Drawing.Size(91, 49);
            this.btnAgregarExpediente.TabIndex = 0;
            this.btnAgregarExpediente.Text = "Registrar Nuevo";
            this.btnAgregarExpediente.UseVisualStyleBackColor = true;
            this.btnAgregarExpediente.Click += new System.EventHandler(this.btnAgregarExpediente_Click);
            // 
            // btnVerListado
            // 
            this.btnVerListado.Location = new System.Drawing.Point(103, 19);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(91, 49);
            this.btnVerListado.TabIndex = 1;
            this.btnVerListado.Text = "Ver Todos";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // btnMayores
            // 
            this.btnMayores.Location = new System.Drawing.Point(200, 19);
            this.btnMayores.Name = "btnMayores";
            this.btnMayores.Size = new System.Drawing.Size(91, 49);
            this.btnMayores.TabIndex = 2;
            this.btnMayores.Text = "Ver Mayores en Monto";
            this.btnMayores.UseVisualStyleBackColor = true;
            this.btnMayores.Click += new System.EventHandler(this.btnMayores_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerExpedientes);
            this.groupBox2.Controls.Add(this.tbDNI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Expediente de una persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(38, 29);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 1;
            // 
            // btnVerExpedientes
            // 
            this.btnVerExpedientes.Location = new System.Drawing.Point(200, 14);
            this.btnVerExpedientes.Name = "btnVerExpedientes";
            this.btnVerExpedientes.Size = new System.Drawing.Size(91, 49);
            this.btnVerExpedientes.TabIndex = 3;
            this.btnVerExpedientes.Text = "Ver Expedientes";
            this.btnVerExpedientes.UseVisualStyleBackColor = true;
            this.btnVerExpedientes.Click += new System.EventHandler(this.btnVerExpedientes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerCausaPorNumero);
            this.groupBox3.Controls.Add(this.tbNroCausa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 78);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ver Expediente de una persona";
            // 
            // btnVerCausaPorNumero
            // 
            this.btnVerCausaPorNumero.Location = new System.Drawing.Point(200, 14);
            this.btnVerCausaPorNumero.Name = "btnVerCausaPorNumero";
            this.btnVerCausaPorNumero.Size = new System.Drawing.Size(91, 49);
            this.btnVerCausaPorNumero.TabIndex = 3;
            this.btnVerCausaPorNumero.Text = "Ver Causa";
            this.btnVerCausaPorNumero.UseVisualStyleBackColor = true;
            this.btnVerCausaPorNumero.Click += new System.EventHandler(this.btnVerCausaPorNumero_Click);
            // 
            // tbNroCausa
            // 
            this.tbNroCausa.Location = new System.Drawing.Point(38, 29);
            this.tbNroCausa.Name = "tbNroCausa";
            this.tbNroCausa.Size = new System.Drawing.Size(100, 20);
            this.tbNroCausa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número Causa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 271);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcial 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerListado;
        private System.Windows.Forms.Button btnAgregarExpediente;
        private System.Windows.Forms.Button btnMayores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerExpedientes;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerCausaPorNumero;
        private System.Windows.Forms.TextBox tbNroCausa;
        private System.Windows.Forms.Label label2;
    }
}

