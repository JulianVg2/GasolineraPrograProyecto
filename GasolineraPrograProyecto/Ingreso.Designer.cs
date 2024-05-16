namespace GasolineraPrograProyecto
{
    partial class Ingreso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbprepago = new System.Windows.Forms.RadioButton();
            this.rdbprepagolleno = new System.Windows.Forms.RadioButton();
            this.dateTimeHora = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGasolina = new System.Windows.Forms.ComboBox();
            this.btnPanel = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbprepago);
            this.groupBox1.Controls.Add(this.rdbprepagolleno);
            this.groupBox1.Location = new System.Drawing.Point(30, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 54);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // rdbprepago
            // 
            this.rdbprepago.AutoSize = true;
            this.rdbprepago.Location = new System.Drawing.Point(6, 9);
            this.rdbprepago.Name = "rdbprepago";
            this.rdbprepago.Size = new System.Drawing.Size(69, 17);
            this.rdbprepago.TabIndex = 13;
            this.rdbprepago.TabStop = true;
            this.rdbprepago.Text = "Pre-Pago";
            this.rdbprepago.UseVisualStyleBackColor = true;
            // 
            // rdbprepagolleno
            // 
            this.rdbprepagolleno.AutoSize = true;
            this.rdbprepagolleno.Location = new System.Drawing.Point(6, 32);
            this.rdbprepagolleno.Name = "rdbprepagolleno";
            this.rdbprepagolleno.Size = new System.Drawing.Size(91, 17);
            this.rdbprepagolleno.TabIndex = 14;
            this.rdbprepagolleno.TabStop = true;
            this.rdbprepagolleno.Text = "Tanque Lleno";
            this.rdbprepagolleno.UseVisualStyleBackColor = true;
            // 
            // dateTimeHora
            // 
            this.dateTimeHora.Location = new System.Drawing.Point(101, 116);
            this.dateTimeHora.Name = "dateTimeHora";
            this.dateTimeHora.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHora.TabIndex = 31;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(22, 319);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 25);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(22, 288);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(124, 25);
            this.btnRegistro.TabIndex = 29;
            this.btnRegistro.Text = "Agregar Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(101, 47);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Seleccione Método De Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tipo de Gasolina";
            // 
            // cmbGasolina
            // 
            this.cmbGasolina.FormattingEnabled = true;
            this.cmbGasolina.Items.AddRange(new object[] {
            "Super",
            "Disel"});
            this.cmbGasolina.Location = new System.Drawing.Point(25, 169);
            this.cmbGasolina.Name = "cmbGasolina";
            this.cmbGasolina.Size = new System.Drawing.Size(121, 21);
            this.cmbGasolina.TabIndex = 24;
            // 
            // btnPanel
            // 
            this.btnPanel.Location = new System.Drawing.Point(368, 4);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(75, 39);
            this.btnPanel.TabIndex = 23;
            this.btnPanel.Text = "Panel De Control";
            this.btnPanel.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(57, 23);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha Y Hora: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nit:";
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimeHora);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGasolina);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbprepago;
        private System.Windows.Forms.RadioButton rdbprepagolleno;
        private System.Windows.Forms.DateTimePicker dateTimeHora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGasolina;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}