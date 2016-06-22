namespace Sistemas_de_Ventas
{
    partial class USUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USUARIOS));
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbTipoUsuario = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.msUsuarios = new System.Windows.Forms.MenuStrip();
            this.Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClave
            // 
            this.tbClave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClave.Location = new System.Drawing.Point(145, 43);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(276, 22);
            this.tbClave.TabIndex = 26;
            this.tbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClave_KeyPress);
            this.tbClave.Validated += new System.EventHandler(this.tbClave_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "CLAVE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONTRASEÑA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "TIPO DE USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "NOMBRE:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(145, 153);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(276, 22);
            this.tbPassword.TabIndex = 21;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.Validated += new System.EventHandler(this.tbPassword_Validated);
            // 
            // tbTipoUsuario
            // 
            this.tbTipoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoUsuario.Location = new System.Drawing.Point(145, 117);
            this.tbTipoUsuario.Name = "tbTipoUsuario";
            this.tbTipoUsuario.Size = new System.Drawing.Size(276, 22);
            this.tbTipoUsuario.TabIndex = 20;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(145, 80);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(276, 22);
            this.tbNombre.TabIndex = 19;
            this.tbNombre.Validated += new System.EventHandler(this.tbNombre_Validated);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(104, 210);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(121, 41);
            this.btAceptar.TabIndex = 28;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(441, 37);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(124, 33);
            this.btBuscar.TabIndex = 27;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // msUsuarios
            // 
            this.msUsuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Consultar,
            this.Nuevo,
            this.Editar,
            this.Eliminar});
            this.msUsuarios.Location = new System.Drawing.Point(0, 0);
            this.msUsuarios.Name = "msUsuarios";
            this.msUsuarios.Size = new System.Drawing.Size(586, 26);
            this.msUsuarios.TabIndex = 31;
            this.msUsuarios.Text = "menuStrip1";
            // 
            // Consultar
            // 
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(115, 22);
            this.Consultar.Text = "CONSULTAR";
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(76, 22);
            this.Nuevo.Text = "NUEVO";
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Editar
            // 
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(76, 22);
            this.Editar.Text = "EDITAR";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(92, 22);
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(259, 210);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(124, 42);
            this.btCancelar.TabIndex = 32;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "administrador",
            "cajero"});
            this.cbTipo.Location = new System.Drawing.Point(145, 117);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(276, 24);
            this.cbTipo.TabIndex = 33;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistemas_de_Ventas.Properties.Resources.icono_usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(441, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 277);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbTipoUsuario);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.msUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msUsuarios;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "USUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.USUARIOS_Load);
            this.msUsuarios.ResumeLayout(false);
            this.msUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbTipoUsuario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.MenuStrip msUsuarios;
        private System.Windows.Forms.ToolStripMenuItem Consultar;
        private System.Windows.Forms.ToolStripMenuItem Nuevo;
        private System.Windows.Forms.ToolStripMenuItem Editar;
        private System.Windows.Forms.ToolStripMenuItem Eliminar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}