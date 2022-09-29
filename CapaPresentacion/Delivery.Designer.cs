namespace CapaPresentacion
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bProducto = new System.Windows.Forms.Button();
            this.bComida = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bProveedor = new System.Windows.Forms.Button();
            this.bCliente = new System.Windows.Forms.Button();
            this.bRepartidor = new System.Windows.Forms.Button();
            this.bCaja = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bProducto
            // 
            this.bProducto.Location = new System.Drawing.Point(26, 58);
            this.bProducto.Name = "bProducto";
            this.bProducto.Size = new System.Drawing.Size(127, 49);
            this.bProducto.TabIndex = 1;
            this.bProducto.Text = "Productos";
            this.bProducto.UseVisualStyleBackColor = true;
            this.bProducto.Click += new System.EventHandler(this.bProducto_Click);
            // 
            // bComida
            // 
            this.bComida.Location = new System.Drawing.Point(26, 127);
            this.bComida.Name = "bComida";
            this.bComida.Size = new System.Drawing.Size(127, 54);
            this.bComida.TabIndex = 2;
            this.bComida.Text = "Comidas";
            this.bComida.UseVisualStyleBackColor = true;
            this.bComida.Click += new System.EventHandler(this.bComida_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ingresos y Egresos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bProveedor
            // 
            this.bProveedor.Location = new System.Drawing.Point(26, 294);
            this.bProveedor.Name = "bProveedor";
            this.bProveedor.Size = new System.Drawing.Size(127, 60);
            this.bProveedor.TabIndex = 4;
            this.bProveedor.Text = "Proveedores";
            this.bProveedor.UseVisualStyleBackColor = true;
            this.bProveedor.Click += new System.EventHandler(this.bProveedor_Click);
            // 
            // bCliente
            // 
            this.bCliente.Location = new System.Drawing.Point(26, 373);
            this.bCliente.Name = "bCliente";
            this.bCliente.Size = new System.Drawing.Size(127, 62);
            this.bCliente.TabIndex = 5;
            this.bCliente.Text = "Clientes";
            this.bCliente.UseVisualStyleBackColor = true;
            this.bCliente.Click += new System.EventHandler(this.bCliente_Click);
            // 
            // bRepartidor
            // 
            this.bRepartidor.Location = new System.Drawing.Point(26, 454);
            this.bRepartidor.Name = "bRepartidor";
            this.bRepartidor.Size = new System.Drawing.Size(127, 57);
            this.bRepartidor.TabIndex = 6;
            this.bRepartidor.Text = "Repartidores";
            this.bRepartidor.UseVisualStyleBackColor = true;
            this.bRepartidor.Click += new System.EventHandler(this.bRepartidor_Click);
            // 
            // bCaja
            // 
            this.bCaja.Location = new System.Drawing.Point(26, 530);
            this.bCaja.Name = "bCaja";
            this.bCaja.Size = new System.Drawing.Size(127, 54);
            this.bCaja.TabIndex = 8;
            this.bCaja.Text = "Caja";
            this.bCaja.UseVisualStyleBackColor = true;
            this.bCaja.Click += new System.EventHandler(this.bCaja_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Control Diario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1565, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bCaja);
            this.Controls.Add(this.bRepartidor);
            this.Controls.Add(this.bCliente);
            this.Controls.Add(this.bProveedor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bComida);
            this.Controls.Add(this.bProducto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Delivery";
            this.ShowIcon = false;
            this.Text = "Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bProducto;
        private System.Windows.Forms.Button bComida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bProveedor;
        private System.Windows.Forms.Button bCliente;
        private System.Windows.Forms.Button bRepartidor;
        private System.Windows.Forms.Button bCaja;
        private System.Windows.Forms.Button button1;
    }
}