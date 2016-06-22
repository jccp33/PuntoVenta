namespace Sistemas_de_Ventas
{
    partial class FINCORTE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FINCORTE));
            this.lbFondo = new System.Windows.Forms.Label();
            this.lbVentas = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFondo
            // 
            this.lbFondo.AutoSize = true;
            this.lbFondo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFondo.Location = new System.Drawing.Point(24, 141);
            this.lbFondo.Name = "lbFondo";
            this.lbFondo.Size = new System.Drawing.Size(69, 18);
            this.lbFondo.TabIndex = 0;
            this.lbFondo.Text = "FONDO:";
            // 
            // lbVentas
            // 
            this.lbVentas.AutoSize = true;
            this.lbVentas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentas.Location = new System.Drawing.Point(24, 184);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(75, 18);
            this.lbVentas.TabIndex = 1;
            this.lbVentas.Text = "VENTAS:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Green;
            this.lbTotal.Location = new System.Drawing.Point(24, 227);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(67, 19);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "TOTAL:";
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(52, 271);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(126, 33);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistemas_de_Ventas.Properties.Resources.dinero;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FINCORTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(240, 328);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbVentas);
            this.Controls.Add(this.lbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FINCORTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINCORTE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFondo;
        private System.Windows.Forms.Label lbVentas;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}