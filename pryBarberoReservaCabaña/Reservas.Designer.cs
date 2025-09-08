namespace pryBarberoReservaCabaña
{
    partial class Reservas
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
            lblTipodeCabaña = new Label();
            lblTipo = new Label();
            lblPersonas = new Label();
            lblDias = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            lblDesde = new Label();
            lblHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblAdicionales = new Label();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            chkTelevisor = new CheckBox();
            lblFormaPago = new Label();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            cmbTarjetas = new ComboBox();
            lblSeleccioneTarjeta = new Label();
            lblTitular = new Label();
            textBox1 = new TextBox();
            llblNombre = new Label();
            lblNumero = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lblTipodeCabaña
            // 
            lblTipodeCabaña.AutoSize = true;
            lblTipodeCabaña.Font = new Font("Segoe UI", 9F);
            lblTipodeCabaña.Location = new Point(35, 26);
            lblTipodeCabaña.Name = "lblTipodeCabaña";
            lblTipodeCabaña.RightToLeft = RightToLeft.No;
            lblTipodeCabaña.Size = new Size(89, 15);
            lblTipodeCabaña.TabIndex = 0;
            lblTipodeCabaña.Text = "Tipo de Cabaña";
            lblTipodeCabaña.Click += lblTipo_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F);
            lblTipo.Location = new Point(74, 77);
            lblTipo.Name = "lblTipo";
            lblTipo.RightToLeft = RightToLeft.No;
            lblTipo.Size = new Size(36, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = " Tipo:";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Font = new Font("Segoe UI", 9F);
            lblPersonas.Location = new Point(261, 77);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.RightToLeft = RightToLeft.No;
            lblPersonas.Size = new Size(126, 15);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas:                       ";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI", 9F);
            lblDias.Location = new Point(487, 77);
            lblDias.Name = "lblDias";
            lblDias.RightToLeft = RightToLeft.No;
            lblDias.Size = new Size(32, 15);
            lblDias.TabIndex = 3;
            lblDias.Text = "Dìas:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(321, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(574, 74);
            dateTimePicker1.MinDate = new DateTime(2025, 9, 8, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(93, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F);
            lblDesde.Location = new Point(526, 77);
            lblDesde.Name = "lblDesde";
            lblDesde.RightToLeft = RightToLeft.No;
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 7;
            lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F);
            lblHasta.Location = new Point(528, 109);
            lblHasta.Name = "lblHasta";
            lblHasta.RightToLeft = RightToLeft.No;
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 8;
            lblHasta.Text = "Hasta:";
            lblHasta.Click += label2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(574, 103);
            dateTimePicker2.MinDate = new DateTime(2025, 9, 8, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(93, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Font = new Font("Segoe UI", 9F);
            lblAdicionales.Location = new Point(55, 176);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.RightToLeft = RightToLeft.No;
            lblAdicionales.Size = new Size(71, 15);
            lblAdicionales.TabIndex = 10;
            lblAdicionales.Text = "Adicionales:";
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(98, 205);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 11;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(98, 249);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 12;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(98, 293);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 13;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 9F);
            lblFormaPago.Location = new Point(287, 176);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.RightToLeft = RightToLeft.No;
            lblFormaPago.Size = new Size(95, 15);
            lblFormaPago.TabIndex = 14;
            lblFormaPago.Text = "Formas de Pago:";
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(336, 218);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 15;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(336, 261);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(62, 19);
            optTarjeta.TabIndex = 16;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta:";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Location = new Point(460, 280);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(207, 23);
            cmbTarjetas.TabIndex = 17;
            // 
            // lblSeleccioneTarjeta
            // 
            lblSeleccioneTarjeta.AutoSize = true;
            lblSeleccioneTarjeta.Font = new Font("Segoe UI", 9F);
            lblSeleccioneTarjeta.Location = new Point(460, 263);
            lblSeleccioneTarjeta.Name = "lblSeleccioneTarjeta";
            lblSeleccioneTarjeta.RightToLeft = RightToLeft.No;
            lblSeleccioneTarjeta.Size = new Size(118, 15);
            lblSeleccioneTarjeta.TabIndex = 18;
            lblSeleccioneTarjeta.Text = "Seleccione su Tarjeta:";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI", 9F);
            lblTitular.Location = new Point(55, 368);
            lblTitular.Name = "lblTitular";
            lblTitular.RightToLeft = RightToLeft.No;
            lblTitular.Size = new Size(114, 15);
            lblTitular.TabIndex = 19;
            lblTitular.Text = "Titular de la Reserva:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 406);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 23);
            textBox1.TabIndex = 20;
            // 
            // llblNombre
            // 
            llblNombre.AutoSize = true;
            llblNombre.Font = new Font("Segoe UI", 9F);
            llblNombre.Location = new Point(101, 409);
            llblNombre.Name = "llblNombre";
            llblNombre.RightToLeft = RightToLeft.No;
            llblNombre.Size = new Size(54, 15);
            llblNombre.TabIndex = 21;
            llblNombre.Text = "Nombre:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9F);
            lblNumero.Location = new Point(100, 454);
            lblNumero.Name = "lblNumero";
            lblNumero.RightToLeft = RightToLeft.No;
            lblNumero.Size = new Size(55, 15);
            lblNumero.TabIndex = 22;
            lblNumero.Text = "Telefono:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 451);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(506, 23);
            textBox2.TabIndex = 23;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(textBox2);
            Controls.Add(lblNumero);
            Controls.Add(llblNombre);
            Controls.Add(textBox1);
            Controls.Add(lblTitular);
            Controls.Add(lblSeleccioneTarjeta);
            Controls.Add(cmbTarjetas);
            Controls.Add(optTarjeta);
            Controls.Add(optEfectivo);
            Controls.Add(lblFormaPago);
            Controls.Add(chkTelevisor);
            Controls.Add(chkHeladera);
            Controls.Add(chkCocina);
            Controls.Add(lblAdicionales);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblDias);
            Controls.Add(lblPersonas);
            Controls.Add(lblTipo);
            Controls.Add(lblTipodeCabaña);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Reservas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipodeCabaña;
        private Label lblTipo;
        private Label lblPersonas;
        private Label lblDias;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dateTimePicker2;
        private Label lblAdicionales;
        private CheckBox chkCocina;
        private CheckBox chkHeladera;
        private CheckBox chkTelevisor;
        private Label lblFormaPago;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private ComboBox cmbTarjetas;
        private Label lblSeleccioneTarjeta;
        private Label lblTitular;
        private TextBox textBox1;
        private Label llblNombre;
        private Label lblNumero;
        private TextBox textBox2;
    }
}
