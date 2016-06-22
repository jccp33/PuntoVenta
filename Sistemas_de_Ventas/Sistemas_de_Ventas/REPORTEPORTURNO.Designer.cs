namespace Sistemas_de_Ventas
{
    partial class REPORTEPORTURNO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REPORTEPORTURNO));
            this.dgCortes = new System.Windows.Forms.DataGridView();
            this.btHReporte = new System.Windows.Forms.Button();
            this.lbFInicial = new System.Windows.Forms.Label();
            this.btPDF = new System.Windows.Forms.Button();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.idCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCortes)).BeginInit();
            this.SuspendLayout();
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
            this.dgCortes.Location = new System.Drawing.Point(12, 53);
            this.dgCortes.Name = "dgCortes";
            this.dgCortes.ReadOnly = true;
            this.dgCortes.Size = new System.Drawing.Size(718, 379);
            this.dgCortes.TabIndex = 10;
            // 
            // btHReporte
            // 
            this.btHReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btHReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHReporte.Location = new System.Drawing.Point(215, 14);
            this.btHReporte.Name = "btHReporte";
            this.btHReporte.Size = new System.Drawing.Size(160, 24);
            this.btHReporte.TabIndex = 9;
            this.btHReporte.Text = "GENERAR REPORTE";
            this.btHReporte.UseVisualStyleBackColor = false;
            this.btHReporte.Click += new System.EventHandler(this.btHReporte_Click);
            // 
            // lbFInicial
            // 
            this.lbFInicial.AutoSize = true;
            this.lbFInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFInicial.Location = new System.Drawing.Point(10, 18);
            this.lbFInicial.Name = "lbFInicial";
            this.lbFInicial.Size = new System.Drawing.Size(44, 16);
            this.lbFInicial.TabIndex = 8;
            this.lbFInicial.Text = "Turno:";
            // 
            // btPDF
            // 
            this.btPDF.Image = global::Sistemas_de_Ventas.Properties.Resources.icoPDF;
            this.btPDF.Location = new System.Drawing.Point(400, 14);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(50, 25);
            this.btPDF.TabIndex = 11;
            this.btPDF.UseVisualStyleBackColor = true;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // cbTurnos
            // 
            this.cbTurnos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Items.AddRange(new object[] {
            "PRIMERO",
            "SEGUNDO",
            "TERCERO"});
            this.cbTurnos.Location = new System.Drawing.Point(60, 14);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(140, 24);
            this.cbTurnos.TabIndex = 12;
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
            // REPORTEPORTURNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 445);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.dgCortes);
            this.Controls.Add(this.btHReporte);
            this.Controls.Add(this.lbFInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "REPORTEPORTURNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE POR TURNO";
            ((System.ComponentModel.ISupportInitialize)(this.dgCortes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPDF;
        private System.Windows.Forms.DataGridView dgCortes;
        private System.Windows.Forms.Button btHReporte;
        private System.Windows.Forms.Label lbFInicial;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}