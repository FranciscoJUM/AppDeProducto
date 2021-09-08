
namespace AdministradorDeProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.UnidadMedida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuscarRango = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHasta = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.tmrBuscarCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarCaducidad = new System.Windows.Forms.Button();
            this.btnMostrarJson = new System.Windows.Forms.Button();
            this.richJson = new System.Windows.Forms.RichTextBox();
            this.BuscarId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Caducidadasd = new System.Windows.Forms.DateTimePicker();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Buscarprecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad de medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(21, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caducidad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(325, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNom.Location = new System.Drawing.Point(173, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 22);
            this.txtNom.TabIndex = 8;
            // 
            // txtDes
            // 
            this.txtDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDes.Location = new System.Drawing.Point(173, 71);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(121, 22);
            this.txtDes.TabIndex = 9;
            // 
            // txtCan
            // 
            this.txtCan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCan.Location = new System.Drawing.Point(173, 119);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(121, 22);
            this.txtCan.TabIndex = 10;
            // 
            // txtPre
            // 
            this.txtPre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPre.Location = new System.Drawing.Point(173, 165);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(121, 22);
            this.txtPre.TabIndex = 11;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnidadMedida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UnidadMedida.FormattingEnabled = true;
            this.UnidadMedida.Items.AddRange(new object[] {
            "Unidad.",
            "Lt.",
            "Ml.",
            "Lbr.",
            "Gr.",
            "Kg."});
            this.UnidadMedida.Location = new System.Drawing.Point(173, 267);
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.Size = new System.Drawing.Size(121, 24);
            this.UnidadMedida.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(329, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Codigo:";
            // 
            // textCodigo
            // 
            this.textCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textCodigo.Location = new System.Drawing.Point(410, 19);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(121, 22);
            this.textCodigo.TabIndex = 23;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(24, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "Buscar por precio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(325, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 27);
            this.button3.TabIndex = 25;
            this.button3.Text = "Buscar por Unidad de medida";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(645, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 27);
            this.button4.TabIndex = 26;
            this.button4.Text = "Buscar por Id";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(325, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 27);
            this.button5.TabIndex = 27;
            this.button5.Text = "Borrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.ForeColor = System.Drawing.Color.Snow;
            this.button6.Location = new System.Drawing.Point(436, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 27);
            this.button6.TabIndex = 28;
            this.button6.Text = "Actualizar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(889, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Buscar productos en rango de precio";
            // 
            // btnBuscarRango
            // 
            this.btnBuscarRango.Location = new System.Drawing.Point(952, 167);
            this.btnBuscarRango.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRango.Name = "btnBuscarRango";
            this.btnBuscarRango.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarRango.TabIndex = 36;
            this.btnBuscarRango.Text = "buscar";
            this.btnBuscarRango.UseVisualStyleBackColor = true;
            this.btnBuscarRango.Click += new System.EventHandler(this.btnBuscarRango_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1064, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Hasta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(915, 82);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "De";
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(1024, 119);
            this.btnHasta.Margin = new System.Windows.Forms.Padding(4);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(152, 22);
            this.btnHasta.TabIndex = 33;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(846, 119);
            this.txtDe.Margin = new System.Windows.Forms.Padding(4);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(141, 22);
            this.txtDe.TabIndex = 32;
            // 
            // tmrBuscarCaducidad
            // 
            this.tmrBuscarCaducidad.Location = new System.Drawing.Point(892, 269);
            this.tmrBuscarCaducidad.Margin = new System.Windows.Forms.Padding(4);
            this.tmrBuscarCaducidad.Name = "tmrBuscarCaducidad";
            this.tmrBuscarCaducidad.Size = new System.Drawing.Size(277, 22);
            this.tmrBuscarCaducidad.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(912, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Productos vencidos antes de:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fecha";
            // 
            // btnBuscarCaducidad
            // 
            this.btnBuscarCaducidad.Location = new System.Drawing.Point(931, 313);
            this.btnBuscarCaducidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCaducidad.Name = "btnBuscarCaducidad";
            this.btnBuscarCaducidad.Size = new System.Drawing.Size(101, 26);
            this.btnBuscarCaducidad.TabIndex = 38;
            this.btnBuscarCaducidad.Text = "Buscar";
            this.btnBuscarCaducidad.UseVisualStyleBackColor = true;
            this.btnBuscarCaducidad.Click += new System.EventHandler(this.btnBuscarCaducidad_Click);
            // 
            // btnMostrarJson
            // 
            this.btnMostrarJson.Location = new System.Drawing.Point(645, 13);
            this.btnMostrarJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarJson.Name = "btnMostrarJson";
            this.btnMostrarJson.Size = new System.Drawing.Size(172, 28);
            this.btnMostrarJson.TabIndex = 43;
            this.btnMostrarJson.Text = "Mostar productos";
            this.btnMostrarJson.UseVisualStyleBackColor = true;
            this.btnMostrarJson.Click += new System.EventHandler(this.btnMostrarJson_Click);
            // 
            // richJson
            // 
            this.richJson.Location = new System.Drawing.Point(645, 63);
            this.richJson.Margin = new System.Windows.Forms.Padding(4);
            this.richJson.Name = "richJson";
            this.richJson.Size = new System.Drawing.Size(171, 243);
            this.richJson.TabIndex = 42;
            this.richJson.Text = "";
            this.richJson.TextChanged += new System.EventHandler(this.richJson_TextChanged);
            // 
            // BuscarId
            // 
            this.BuscarId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuscarId.Location = new System.Drawing.Point(645, 351);
            this.BuscarId.Name = "BuscarId";
            this.BuscarId.Size = new System.Drawing.Size(121, 22);
            this.BuscarId.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Buscar producto por Id";
            // 
            // Caducidadasd
            // 
            this.Caducidadasd.Location = new System.Drawing.Point(173, 216);
            this.Caducidadasd.Margin = new System.Windows.Forms.Padding(4);
            this.Caducidadasd.Name = "Caducidadasd";
            this.Caducidadasd.Size = new System.Drawing.Size(277, 22);
            this.Caducidadasd.TabIndex = 46;
            // 
            // combo
            // 
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "Unidad.",
            "Lt.",
            "Ml.",
            "Lbr.",
            "Gr.",
            "Kg."});
            this.combo.Location = new System.Drawing.Point(436, 349);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(121, 24);
            this.combo.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(284, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Unidad de medida:";
            // 
            // Buscarprecio
            // 
            this.Buscarprecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscarprecio.Location = new System.Drawing.Point(57, 344);
            this.Buscarprecio.Name = "Buscarprecio";
            this.Buscarprecio.Size = new System.Drawing.Size(121, 22);
            this.Buscarprecio.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1189, 458);
            this.Controls.Add(this.Buscarprecio);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Caducidadasd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BuscarId);
            this.Controls.Add(this.btnMostrarJson);
            this.Controls.Add(this.richJson);
            this.Controls.Add(this.tmrBuscarCaducidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarCaducidad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBuscarRango);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UnidadMedida);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Administrade de productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.ComboBox UnidadMedida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarRango;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox btnHasta;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.DateTimePicker tmrBuscarCaducidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarCaducidad;
        private System.Windows.Forms.Button btnMostrarJson;
        private System.Windows.Forms.RichTextBox richJson;
        private System.Windows.Forms.TextBox BuscarId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Caducidadasd;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Buscarprecio;
    }
}

