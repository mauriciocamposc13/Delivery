namespace CapaPresentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bCaja = new System.Windows.Forms.Button();
            this.bAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(752, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bCaja
            // 
            this.bCaja.Location = new System.Drawing.Point(21, 43);
            this.bCaja.Name = "bCaja";
            this.bCaja.Size = new System.Drawing.Size(111, 50);
            this.bCaja.TabIndex = 2;
            this.bCaja.Text = "Caja";
            this.bCaja.UseVisualStyleBackColor = true;
            this.bCaja.Click += new System.EventHandler(this.bCaja_Click);
            // 
            // bAdmin
            // 
            this.bAdmin.Location = new System.Drawing.Point(21, 110);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(111, 50);
            this.bAdmin.TabIndex = 3;
            this.bAdmin.Text = "Administrar";
            this.bAdmin.UseVisualStyleBackColor = true;
            this.bAdmin.Click += new System.EventHandler(this.bAdmin_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 785);
            this.Controls.Add(this.bAdmin);
            this.Controls.Add(this.bCaja);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bCaja;
        private System.Windows.Forms.Button bAdmin;
    }
}