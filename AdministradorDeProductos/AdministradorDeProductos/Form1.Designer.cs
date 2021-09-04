
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
            this.txtCad = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.UnidadMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.TxtCaducidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBuscarCaducidad = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tmrBuscarCaducidad = new System.Windows.Forms.DateTimePicker();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.btnHasta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarRango = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.richJson = new System.Windows.Forms.RichTextBox();
            this.btnMostrarJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad de medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caducidad:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(244, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCad
            // 
            this.txtCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCad.Location = new System.Drawing.Point(130, 171);
            this.txtCad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCad.Name = "txtCad";
            this.txtCad.Size = new System.Drawing.Size(92, 20);
            this.txtCad.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNom.Location = new System.Drawing.Point(130, 18);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(92, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtDes
            // 
            this.txtDes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDes.Location = new System.Drawing.Point(130, 58);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(92, 20);
            this.txtDes.TabIndex = 9;
            // 
            // txtCan
            // 
            this.txtCan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCan.Location = new System.Drawing.Point(130, 97);
            this.txtCan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(92, 20);
            this.txtCan.TabIndex = 10;
            // 
            // txtPre
            // 
            this.txtPre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPre.Location = new System.Drawing.Point(130, 134);
            this.txtPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(92, 20);
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
            this.UnidadMedida.Location = new System.Drawing.Point(130, 217);
            this.UnidadMedida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.Size = new System.Drawing.Size(92, 21);
            this.UnidadMedida.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(253, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(253, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio Max:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(253, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fecha de caducidad:";
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrecioMin.Location = new System.Drawing.Point(372, 22);
            this.txtPrecioMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(92, 20);
            this.txtPrecioMin.TabIndex = 16;
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrecioMax.Location = new System.Drawing.Point(372, 62);
            this.txtPrecioMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(92, 20);
            this.txtPrecioMax.TabIndex = 17;
            // 
            // TxtCaducidad
            // 
            this.TxtCaducidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCaducidad.Location = new System.Drawing.Point(372, 101);
            this.TxtCaducidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCaducidad.Name = "TxtCaducidad";
            this.TxtCaducidad.Size = new System.Drawing.Size(92, 20);
            this.TxtCaducidad.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(244, 184);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 22);
            this.button2.TabIndex = 19;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(351, 138);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 22);
            this.button3.TabIndex = 20;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(244, 157);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 22);
            this.button4.TabIndex = 21;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCaducidad
            // 
            this.btnBuscarCaducidad.Location = new System.Drawing.Point(285, 290);
            this.btnBuscarCaducidad.Name = "btnBuscarCaducidad";
            this.btnBuscarCaducidad.Size = new System.Drawing.Size(76, 21);
            this.btnBuscarCaducidad.TabIndex = 22;
            this.btnBuscarCaducidad.Text = "Buscar";
            this.btnBuscarCaducidad.UseVisualStyleBackColor = true;
            this.btnBuscarCaducidad.Click += new System.EventHandler(this.btnBuscarCaducidad_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Productos vencidos antes de:";
            // 
            // tmrBuscarCaducidad
            // 
            this.tmrBuscarCaducidad.Location = new System.Drawing.Point(256, 254);
            this.tmrBuscarCaducidad.Name = "tmrBuscarCaducidad";
            this.tmrBuscarCaducidad.Size = new System.Drawing.Size(209, 20);
            this.tmrBuscarCaducidad.TabIndex = 25;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(482, 173);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(107, 20);
            this.txtDe.TabIndex = 26;
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(616, 173);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(115, 20);
            this.btnHasta.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(534, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "De";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(646, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Hasta";
            // 
            // btnBuscarRango
            // 
            this.btnBuscarRango.Location = new System.Drawing.Point(562, 212);
            this.btnBuscarRango.Name = "btnBuscarRango";
            this.btnBuscarRango.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRango.TabIndex = 30;
            this.btnBuscarRango.Text = "buscar";
            this.btnBuscarRango.UseVisualStyleBackColor = true;
            this.btnBuscarRango.Click += new System.EventHandler(this.btnBuscarRango_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Buscar productos en rango de precio";
            // 
            // richJson
            // 
            this.richJson.Location = new System.Drawing.Point(756, 101);
            this.richJson.Name = "richJson";
            this.richJson.Size = new System.Drawing.Size(129, 198);
            this.richJson.TabIndex = 32;
            this.richJson.Text = "";
            // 
            // btnMostrarJson
            // 
            this.btnMostrarJson.Location = new System.Drawing.Point(756, 60);
            this.btnMostrarJson.Name = "btnMostrarJson";
            this.btnMostrarJson.Size = new System.Drawing.Size(129, 23);
            this.btnMostrarJson.TabIndex = 33;
            this.btnMostrarJson.Text = "Mostar productos";
            this.btnMostrarJson.UseVisualStyleBackColor = true;
            this.btnMostrarJson.Click += new System.EventHandler(this.btnMostrarJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 323);
            this.Controls.Add(this.btnMostrarJson);
            this.Controls.Add(this.richJson);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnBuscarRango);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.txtDe);
            this.Controls.Add(this.tmrBuscarCaducidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscarCaducidad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtCaducidad);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnidadMedida);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Administrade de productos";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtCad;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.ComboBox UnidadMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioMin;
        private System.Windows.Forms.TextBox txtPrecioMax;
        private System.Windows.Forms.TextBox TxtCaducidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBuscarCaducidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tmrBuscarCaducidad;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox btnHasta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarRango;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richJson;
        private System.Windows.Forms.Button btnMostrarJson;
    }
}

