namespace Sistemas_de_Ventas
{
    partial class ABRIRTURNO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABRIRTURNO));
            this.tbFondo = new System.Windows.Forms.TextBox();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAbrirTurno = new System.Windows.Forms.Button();
            this.btCerrarTurno = new System.Windows.Forms.Button();
            this.btEntrarCaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFondo
            // 
            this.tbFondo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFondo.Location = new System.Drawing.Point(112, 127);
            this.tbFondo.Name = "tbFondo";
            this.tbFondo.Size = new System.Drawing.Size(289, 22);
            this.tbFondo.TabIndex = 11;
            this.tbFondo.Text = "0.0";
            this.tbFondo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFondo_KeyPress);
            // 
            // cbTurnos
            // 
            this.cbTurnos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Items.AddRange(new object[] {
            "PRIMERO",
            "SEGUNDO",
            "TERCERO"});
            this.cbTurnos.Location = new System.Drawing.Point(112, 78);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(289, 24);
            this.cbTurnos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "FONDO: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TURNO:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(112, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CAJERO:";
            // 
            // btAbrirTurno
            // 
            this.btAbrirTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAbrirTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirTurno.Location = new System.Drawing.Point(12, 183);
            this.btAbrirTurno.Name = "btAbrirTurno";
            this.btAbrirTurno.Size = new System.Drawing.Size(134, 30);
            this.btAbrirTurno.TabIndex = 12;
            this.btAbrirTurno.Text = "ABRIR TURNO";
            this.btAbrirTurno.UseVisualStyleBackColor = false;
            this.btAbrirTurno.Click += new System.EventHandler(this.btAbrirTurno_Click);
            // 
            // btCerrarTurno
            // 
            this.btCerrarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCerrarTurno.Enabled = false;
            this.btCerrarTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrarTurno.Location = new System.Drawing.Point(164, 183);
            this.btCerrarTurno.Name = "btCerrarTurno";
            this.btCerrarTurno.Size = new System.Drawing.Size(134, 30);
            this.btCerrarTurno.TabIndex = 13;
            this.btCerrarTurno.Text = "CERRAR TURNO";
            this.btCerrarTurno.UseVisualStyleBackColor = false;
            this.btCerrarTurno.Click += new System.EventHandler(this.btCerrarTurno_Click);
            // 
            // btEntrarCaja
            // 
            this.btEntrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btEntrarCaja.Enabled = false;
            this.btEntrarCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrarCaja.Location = new System.Drawing.Point(318, 183);
            this.btEntrarCaja.Name = "btEntrarCaja";
            this.btEntrarCaja.Size = new System.Drawing.Size(134, 30);
            this.btEntrarCaja.TabIndex = 14;
            this.btEntrarCaja.Text = "ENTRAR A CAJA";
            this.btEntrarCaja.UseVisualStyleBackColor = false;
            this.btEntrarCaja.Click += new System.EventHandler(this.btEntrarCaja_Click);
            // 
            // ABRIRTURNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btEntrarCaja);
            this.Controls.Add(this.btCerrarTurno);
            this.Controls.Add(this.btAbrirTurno);
            this.Controls.Add(this.tbFondo);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABRIRTURNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABRIR TURNO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFondo;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAbrirTurno;
        private System.Windows.Forms.Button btCerrarTurno;
        private System.Windows.Forms.Button btEntrarCaja;
    }
}