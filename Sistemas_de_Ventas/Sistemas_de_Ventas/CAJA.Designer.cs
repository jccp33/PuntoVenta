namespace Sistemas_de_Ventas
{
    partial class CAJA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAJA));
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCancelarArt = new System.Windows.Forms.Button();
            this.btCancelarVenta = new System.Windows.Forms.Button();
            this.btCobrar = new System.Windows.Forms.Button();
            this.tbCodigoArt = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTicket = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.lbCajero = new System.Windows.Forms.Label();
            this.lbArticulos = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbIva = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbTurno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(3, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(220, 36);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.Text = "BUSCAR ARTICULO   (F1)";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btCancelarArt
            // 
            this.btCancelarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelarArt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarArt.Location = new System.Drawing.Point(229, 2);
            this.btCancelarArt.Name = "btCancelarArt";
            this.btCancelarArt.Size = new System.Drawing.Size(257, 36);
            this.btCancelarArt.TabIndex = 1;
            this.btCancelarArt.Text = "CANCELAR ARTICULO   (F2)";
            this.btCancelarArt.UseVisualStyleBackColor = false;
            this.btCancelarArt.Click += new System.EventHandler(this.btCancelarArt_Click);
            // 
            // btCancelarVenta
            // 
            this.btCancelarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarVenta.Location = new System.Drawing.Point(492, 2);
            this.btCancelarVenta.Name = "btCancelarVenta";
            this.btCancelarVenta.Size = new System.Drawing.Size(220, 36);
            this.btCancelarVenta.TabIndex = 2;
            this.btCancelarVenta.Text = "CANCELAR VENTA   (F3)";
            this.btCancelarVenta.UseVisualStyleBackColor = false;
            this.btCancelarVenta.Click += new System.EventHandler(this.btCancelarVenta_Click);
            // 
            // btCobrar
            // 
            this.btCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCobrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCobrar.Location = new System.Drawing.Point(718, 2);
            this.btCobrar.Name = "btCobrar";
            this.btCobrar.Size = new System.Drawing.Size(137, 36);
            this.btCobrar.TabIndex = 3;
            this.btCobrar.Text = "COBRAR   (F4)";
            this.btCobrar.UseVisualStyleBackColor = false;
            this.btCobrar.Click += new System.EventHandler(this.btCobrar_Click);
            // 
            // tbCodigoArt
            // 
            this.tbCodigoArt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigoArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoArt.Location = new System.Drawing.Point(114, 53);
            this.tbCodigoArt.Name = "tbCodigoArt";
            this.tbCodigoArt.Size = new System.Drawing.Size(249, 22);
            this.tbCodigoArt.TabIndex = 4;
            this.tbCodigoArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigoArt_KeyDown);
            this.tbCodigoArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoArt_KeyPress);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(460, 53);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(85, 22);
            this.tbCantidad.TabIndex = 5;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(0, 56);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(108, 16);
            this.lbProducto.TabIndex = 6;
            this.lbProducto.Text = "Codigo Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.cantidad,
            this.total});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 294);
            this.dataGridView1.TabIndex = 7;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 80;
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 80;
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicket.Location = new System.Drawing.Point(566, 219);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(67, 16);
            this.lbTicket.TabIndex = 8;
            this.lbTicket.Text = "Ticket No:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(566, 249);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(48, 16);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(566, 282);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(39, 16);
            this.lbHora.TabIndex = 10;
            this.lbHora.Text = "Hora:";
            // 
            // lbCajero
            // 
            this.lbCajero.AutoSize = true;
            this.lbCajero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCajero.Location = new System.Drawing.Point(566, 312);
            this.lbCajero.Name = "lbCajero";
            this.lbCajero.Size = new System.Drawing.Size(49, 16);
            this.lbCajero.TabIndex = 11;
            this.lbCajero.Text = "Cajero:";
            // 
            // lbArticulos
            // 
            this.lbArticulos.AutoSize = true;
            this.lbArticulos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulos.ForeColor = System.Drawing.Color.Red;
            this.lbArticulos.Location = new System.Drawing.Point(12, 407);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(137, 24);
            this.lbArticulos.TabIndex = 12;
            this.lbArticulos.Text = "ARTICULOS:";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.ForeColor = System.Drawing.Color.Red;
            this.lbSubTotal.Location = new System.Drawing.Point(15, 455);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(134, 24);
            this.lbSubTotal.TabIndex = 13;
            this.lbSubTotal.Text = "SUB TOTAL:";
            // 
            // lbIva
            // 
            this.lbIva.AutoSize = true;
            this.lbIva.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIva.ForeColor = System.Drawing.Color.Red;
            this.lbIva.Location = new System.Drawing.Point(329, 407);
            this.lbIva.Name = "lbIva";
            this.lbIva.Size = new System.Drawing.Size(48, 24);
            this.lbIva.TabIndex = 14;
            this.lbIva.Text = "IVA:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(292, 455);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(85, 24);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "TOTAL:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(381, 56);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(63, 16);
            this.lbCantidad.TabIndex = 17;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurno.Location = new System.Drawing.Point(566, 340);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(44, 16);
            this.lbTurno.TabIndex = 18;
            this.lbTurno.Text = "Turno:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistemas_de_Ventas.Properties.Resources.imagen2;
            this.pictureBox1.Location = new System.Drawing.Point(630, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CAJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 499);
            this.Controls.Add(this.lbTurno);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbIva);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.lbArticulos);
            this.Controls.Add(this.lbCajero);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbCodigoArt);
            this.Controls.Add(this.btCobrar);
            this.Controls.Add(this.btCancelarVenta);
            this.Controls.Add(this.btCancelarArt);
            this.Controls.Add(this.btBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CAJA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAJA";
            this.Activated += new System.EventHandler(this.CAJA_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btCancelarArt;
        private System.Windows.Forms.Button btCancelarVenta;
        private System.Windows.Forms.Button btCobrar;
        private System.Windows.Forms.TextBox tbCodigoArt;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label lbTicket;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbCajero;
        private System.Windows.Forms.Label lbArticulos;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbIva;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbTurno;
    }
}