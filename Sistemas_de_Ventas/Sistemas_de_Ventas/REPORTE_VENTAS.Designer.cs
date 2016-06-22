namespace Sistemas_de_Ventas
{
    partial class REPORTE_VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTE_VENTAS));
            this.dTInicial = new System.Windows.Forms.DateTimePicker();
            this.lbFInicial = new System.Windows.Forms.Label();
            this.btHReporte = new System.Windows.Forms.Button();
            this.dgCortes = new System.Windows.Forms.DataGridView();
            this.btPDF = new System.Windows.Forms.Button();
            this.idCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCortes)).BeginInit();
            this.SuspendLayout();
            // 
            // dTInicial
            // 
            this.dTInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTInicial.Location = new System.Drawing.Point(64, 16);
            this.dTInicial.Name = "dTInicial";
            this.dTInicial.Size = new System.Drawing.Size(236, 22);
            this.dTInicial.TabIndex = 0;
            // 
            // lbFInicial
            // 
            this.lbFInicial.AutoSize = true;
            this.lbFInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFInicial.Location = new System.Drawing.Point(10, 21);
            this.lbFInicial.Name = "lbFInicial";
            this.lbFInicial.Size = new System.Drawing.Size(48, 16);
            this.lbFInicial.TabIndex = 2;
            this.lbFInicial.Text = "Fecha:";
            // 
            // btHReporte
            // 
            this.btHReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btHReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHReporte.Location = new System.Drawing.Point(322, 14);
            this.btHReporte.Name = "btHReporte";
            this.btHReporte.Size = new System.Drawing.Size(160, 24);
            this.btHReporte.TabIndex = 4;
            this.btHReporte.Text = "GENERAR REPORTE";
            this.btHReporte.UseVisualStyleBackColor = false;
            this.btHReporte.Click += new System.EventHandler(this.btHReporte_Click);
            // 
            // dgCortes
            // 
            this.dgCortes.AllowUserToAddRows = false;
            this.dgCortes.AllowUserToDeleteRows = false;
            this.dgCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCortes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCorte,
            this.fecha,
            this.cajero,
            this.turno,
            this.total});
            this.dgCortes.Location = new System.Drawing.Point(12, 56);
            this.dgCortes.Name = "dgCortes";
            this.dgCortes.ReadOnly = true;
            this.dgCortes.Size = new System.Drawing.Size(719, 379);
            this.dgCortes.TabIndex = 5;
            // 
            // btPDF
            // 
            this.btPDF.Image = global::Sistemas_de_Ventas.Properties.Resources.icoPDF;
            this.btPDF.Location = new System.Drawing.Point(501, 14);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(50, 25);
            this.btPDF.TabIndex = 6;
            this.btPDF.UseVisualStyleBackColor = true;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // idCorte
            // 
            this.idCorte.HeaderText = "CORTE NO.";
            this.idCorte.Name = "idCorte";
            this.idCorte.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 75;
            // 
            // cajero
            // 
            this.cajero.HeaderText = "CAJERO";
            this.cajero.Name = "cajero";
            this.cajero.ReadOnly = true;
            this.cajero.Width = 250;
            // 
            // turno
            // 
            this.turno.HeaderText = "TURNO";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            this.turno.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // REPORTE_VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 448);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.dgCortes);
            this.Controls.Add(this.btHReporte);
            this.Controls.Add(this.lbFInicial);
            this.Controls.Add(this.dTInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "REPORTE_VENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE VENTAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgCortes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTInicial;
        private System.Windows.Forms.Label lbFInicial;
        private System.Windows.Forms.Button btHReporte;
        private System.Windows.Forms.DataGridView dgCortes;
        private System.Windows.Forms.Button btPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}