namespace CapaPresentacion
{
    partial class Comida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.textPVenta = new System.Windows.Forms.TextBox();
            this.textPCosto = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCodBarra = new System.Windows.Forms.TextBox();
            this.textCod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textFiltro);
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bEditar);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.textDesc);
            this.groupBox1.Controls.Add(this.textPVenta);
            this.groupBox1.Controls.Add(this.textPCosto);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textCodBarra);
            this.groupBox1.Controls.Add(this.textCod);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1714, 735);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comida";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dataGridView1.Location = new System.Drawing.Point(392, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 652);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(779, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 27;
            this.button4.Text = "Filtrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textFiltro
            // 
            this.textFiltro.Location = new System.Drawing.Point(457, 21);
            this.textFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(296, 22);
            this.textFiltro.TabIndex = 26;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(262, 289);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(112, 28);
            this.bEliminar.TabIndex = 25;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(131, 289);
            this.bEditar.Margin = new System.Windows.Forms.Padding(4);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(123, 28);
            this.bEditar.TabIndex = 24;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(3, 289);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(120, 28);
            this.bGuardar.TabIndex = 23;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(120, 247);
            this.textDesc.Margin = new System.Windows.Forms.Padding(4);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(253, 22);
            this.textDesc.TabIndex = 19;
            // 
            // textPVenta
            // 
            this.textPVenta.Location = new System.Drawing.Point(120, 214);
            this.textPVenta.Margin = new System.Windows.Forms.Padding(4);
            this.textPVenta.Name = "textPVenta";
            this.textPVenta.Size = new System.Drawing.Size(253, 22);
            this.textPVenta.TabIndex = 18;
            // 
            // textPCosto
            // 
            this.textPCosto.Location = new System.Drawing.Point(120, 181);
            this.textPCosto.Margin = new System.Windows.Forms.Padding(4);
            this.textPCosto.Name = "textPCosto";
            this.textPCosto.Size = new System.Drawing.Size(253, 22);
            this.textPCosto.TabIndex = 17;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(121, 145);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(253, 22);
            this.textNombre.TabIndex = 15;
            // 
            // textCodBarra
            // 
            this.textCodBarra.Location = new System.Drawing.Point(121, 112);
            this.textCodBarra.Margin = new System.Windows.Forms.Padding(4);
            this.textCodBarra.Name = "textCodBarra";
            this.textCodBarra.Size = new System.Drawing.Size(253, 22);
            this.textCodBarra.TabIndex = 14;
            // 
            // textCod
            // 
            this.textCod.Location = new System.Drawing.Point(121, 79);
            this.textCod.Margin = new System.Windows.Forms.Padding(4);
            this.textCod.Name = "textCod";
            this.textCod.Size = new System.Drawing.Size(253, 22);
            this.textCod.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Filtro";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(117, 41);
            this.numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(54, 17);
            this.numero.TabIndex = 11;
            this.numero.Text = "label12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pr. Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pr. Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod. Barra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Comida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 942);
            this.Controls.Add(this.groupBox1);
            this.Name = "Comida";
            this.ShowIcon = false;
            this.Text = "Comida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Comida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.TextBox textPVenta;
        private System.Windows.Forms.TextBox textPCosto;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCodBarra;
        private System.Windows.Forms.TextBox textCod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}