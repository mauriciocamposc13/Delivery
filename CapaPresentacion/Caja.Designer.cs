namespace CapaPresentacion
{
    partial class Caja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bTodas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeFiltro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.textmontoCierre = new System.Windows.Forms.TextBox();
            this.textmontoInicio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigoCaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bVender = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bEliminar1 = new System.Windows.Forms.Button();
            this.bGuardar1 = new System.Windows.Forms.Button();
            this.textDebito = new System.Windows.Forms.TextBox();
            this.textEfectivo = new System.Windows.Forms.TextBox();
            this.textDetalle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numeroDetalleCaja = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.codigoCaja1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bTodas);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimeFiltro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bEditar);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.textmontoCierre);
            this.groupBox1.Controls.Add(this.textmontoInicio);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.dateTimeFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.codigoCaja);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1707, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caja";
            // 
            // bTodas
            // 
            this.bTodas.Location = new System.Drawing.Point(1057, 26);
            this.bTodas.Name = "bTodas";
            this.bTodas.Size = new System.Drawing.Size(141, 31);
            this.bTodas.TabIndex = 17;
            this.bTodas.Text = "Mostrar/Atualizar";
            this.bTodas.UseVisualStyleBackColor = true;
            this.bTodas.Click += new System.EventHandler(this.bTodas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(362, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 224);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTimeFiltro
            // 
            this.dateTimeFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFiltro.Location = new System.Drawing.Point(498, 26);
            this.dateTimeFiltro.Name = "dateTimeFiltro";
            this.dateTimeFiltro.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFiltro.TabIndex = 14;
            this.dateTimeFiltro.ValueChanged += new System.EventHandler(this.dateTimeFiltro_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filtrar por fecha";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(228, 225);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(105, 30);
            this.bEliminar.TabIndex = 12;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(117, 225);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(105, 30);
            this.bEditar.TabIndex = 11;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(6, 225);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(105, 30);
            this.bGuardar.TabIndex = 10;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // textmontoCierre
            // 
            this.textmontoCierre.Location = new System.Drawing.Point(102, 181);
            this.textmontoCierre.Name = "textmontoCierre";
            this.textmontoCierre.Size = new System.Drawing.Size(244, 22);
            this.textmontoCierre.TabIndex = 9;
            // 
            // textmontoInicio
            // 
            this.textmontoInicio.Location = new System.Drawing.Point(101, 150);
            this.textmontoInicio.Name = "textmontoInicio";
            this.textmontoInicio.Size = new System.Drawing.Size(244, 22);
            this.textmontoInicio.TabIndex = 8;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(101, 119);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(244, 22);
            this.textNombre.TabIndex = 7;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(101, 88);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(244, 22);
            this.dateTimeFecha.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto Cierre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // codigoCaja
            // 
            this.codigoCaja.AutoSize = true;
            this.codigoCaja.Location = new System.Drawing.Point(99, 55);
            this.codigoCaja.Name = "codigoCaja";
            this.codigoCaja.Size = new System.Drawing.Size(46, 17);
            this.codigoCaja.TabIndex = 1;
            this.codigoCaja.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bActualizar);
            this.groupBox2.Controls.Add(this.bVender);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.bEliminar1);
            this.groupBox2.Controls.Add(this.bGuardar1);
            this.groupBox2.Controls.Add(this.textDebito);
            this.groupBox2.Controls.Add(this.textEfectivo);
            this.groupBox2.Controls.Add(this.textDetalle);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numeroDetalleCaja);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.codigoCaja1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1707, 513);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Caja";
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(375, 16);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(106, 32);
            this.bActualizar.TabIndex = 15;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bVender
            // 
            this.bVender.Location = new System.Drawing.Point(60, 252);
            this.bVender.Name = "bVender";
            this.bVender.Size = new System.Drawing.Size(228, 70);
            this.bVender.TabIndex = 14;
            this.bVender.Text = "Vender";
            this.bVender.UseVisualStyleBackColor = true;
            this.bVender.Click += new System.EventHandler(this.bVender_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(352, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1329, 443);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // bEliminar1
            // 
            this.bEliminar1.Location = new System.Drawing.Point(188, 204);
            this.bEliminar1.Name = "bEliminar1";
            this.bEliminar1.Size = new System.Drawing.Size(115, 30);
            this.bEliminar1.TabIndex = 12;
            this.bEliminar1.Text = "Eliminar";
            this.bEliminar1.UseVisualStyleBackColor = true;
            this.bEliminar1.Click += new System.EventHandler(this.bEliminar1_Click);
            // 
            // bGuardar1
            // 
            this.bGuardar1.Location = new System.Drawing.Point(42, 204);
            this.bGuardar1.Name = "bGuardar1";
            this.bGuardar1.Size = new System.Drawing.Size(115, 30);
            this.bGuardar1.TabIndex = 10;
            this.bGuardar1.Text = "Guardar";
            this.bGuardar1.UseVisualStyleBackColor = true;
            this.bGuardar1.Click += new System.EventHandler(this.bGuardar1_Click);
            // 
            // textDebito
            // 
            this.textDebito.Location = new System.Drawing.Point(102, 163);
            this.textDebito.Name = "textDebito";
            this.textDebito.Size = new System.Drawing.Size(244, 22);
            this.textDebito.TabIndex = 9;
            // 
            // textEfectivo
            // 
            this.textEfectivo.Location = new System.Drawing.Point(102, 130);
            this.textEfectivo.Name = "textEfectivo";
            this.textEfectivo.Size = new System.Drawing.Size(244, 22);
            this.textEfectivo.TabIndex = 8;
            // 
            // textDetalle
            // 
            this.textDetalle.Location = new System.Drawing.Point(102, 97);
            this.textDetalle.Name = "textDetalle";
            this.textDetalle.Size = new System.Drawing.Size(244, 22);
            this.textDetalle.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Debito";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Efectivo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Descripción";
            // 
            // numeroDetalleCaja
            // 
            this.numeroDetalleCaja.AutoSize = true;
            this.numeroDetalleCaja.Location = new System.Drawing.Point(129, 66);
            this.numeroDetalleCaja.Name = "numeroDetalleCaja";
            this.numeroDetalleCaja.Size = new System.Drawing.Size(54, 17);
            this.numeroDetalleCaja.TabIndex = 3;
            this.numeroDetalleCaja.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Numero Detalle";
            // 
            // codigoCaja1
            // 
            this.codigoCaja1.AutoSize = true;
            this.codigoCaja1.Location = new System.Drawing.Point(129, 36);
            this.codigoCaja1.Name = "codigoCaja1";
            this.codigoCaja1.Size = new System.Drawing.Size(46, 17);
            this.codigoCaja1.TabIndex = 1;
            this.codigoCaja1.Text = "label8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código Caja";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1838, 883);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Caja";
            this.ShowIcon = false;
            this.Text = "Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Caja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textmontoCierre;
        private System.Windows.Forms.TextBox textmontoInicio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label codigoCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimeFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bEliminar1;
        private System.Windows.Forms.Button bGuardar1;
        private System.Windows.Forms.TextBox textDebito;
        private System.Windows.Forms.TextBox textEfectivo;
        private System.Windows.Forms.TextBox textDetalle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label numeroDetalleCaja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label codigoCaja1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bTodas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bVender;
        private System.Windows.Forms.Button bActualizar;
    }
}