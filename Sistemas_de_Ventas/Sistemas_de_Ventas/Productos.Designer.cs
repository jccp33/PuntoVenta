namespace Sistemas_de_Ventas
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.tbCodigoExterno = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoInterno = new System.Windows.Forms.TextBox();
            this.msProductos = new System.Windows.Forms.MenuStrip();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARSTOCKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.rbAgranel = new System.Windows.Forms.RadioButton();
            this.rbUnidad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msProductos.SuspendLayout();
            this.gbVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigoExterno
            // 
            this.tbCodigoExterno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoExterno.Location = new System.Drawing.Point(119, 90);
            this.tbCodigoExterno.Name = "tbCodigoExterno";
            this.tbCodigoExterno.Size = new System.Drawing.Size(243, 22);
            this.tbCodigoExterno.TabIndex = 2;
            this.tbCodigoExterno.Validated += new System.EventHandler(this.tbCodigoExterno_Validated);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(119, 130);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(243, 22);
            this.tbDescripcion.TabIndex = 3;
            this.tbDescripcion.Validated += new System.EventHandler(this.tbDescripcion_Validated);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(119, 242);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(243, 22);
            this.tbPrecio.TabIndex = 4;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            this.tbPrecio.Validated += new System.EventHandler(this.tbPrecio_Validated);
            // 
            // tbIva
            // 
            this.tbIva.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIva.Location = new System.Drawing.Point(119, 282);
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(243, 22);
            this.tbIva.TabIndex = 5;
            this.tbIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIva_KeyPress);
            this.tbIva.Validated += new System.EventHandler(this.tbIva_Validated);
            // 
            // tbStock
            // 
            this.tbStock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(119, 322);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(243, 22);
            this.tbStock.TabIndex = 6;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            this.tbStock.Validated += new System.EventHandler(this.tbStock_Validated);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(380, 47);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(108, 27);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(70, 373);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(108, 36);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(204, 373);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(108, 36);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "IVA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo Interno:";
            // 
            // tbCodigoInterno
            // 
            this.tbCodigoInterno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoInterno.Location = new System.Drawing.Point(119, 50);
            this.tbCodigoInterno.Name = "tbCodigoInterno";
            this.tbCodigoInterno.Size = new System.Drawing.Size(243, 22);
            this.tbCodigoInterno.TabIndex = 18;
            this.tbCodigoInterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoInterno_KeyPress);
            this.tbCodigoInterno.Validated += new System.EventHandler(this.tbCodigoInterno_Validated);
            // 
            // msProductos
            // 
            this.msProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONSULTARToolStripMenuItem,
            this.nUEVOToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem,
            this.aCTUALIZARSTOCKToolStripMenuItem});
            this.msProductos.Location = new System.Drawing.Point(0, 0);
            this.msProductos.Name = "msProductos";
            this.msProductos.Size = new System.Drawing.Size(563, 26);
            this.msProductos.TabIndex = 19;
            this.msProductos.Text = "menuStrip1";
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR";
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem_Click);
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARToolStripMenuItem_Click);
            // 
            // aCTUALIZARSTOCKToolStripMenuItem
            // 
            this.aCTUALIZARSTOCKToolStripMenuItem.Name = "aCTUALIZARSTOCKToolStripMenuItem";
            this.aCTUALIZARSTOCKToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aCTUALIZARSTOCKToolStripMenuItem.Text = "ACTUALIZAR STOCK";
            this.aCTUALIZARSTOCKToolStripMenuItem.Click += new System.EventHandler(this.aCTUALIZARSTOCKToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Codigo Externo:";
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.rbAgranel);
            this.gbVenta.Controls.Add(this.rbUnidad);
            this.gbVenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVenta.Location = new System.Drawing.Point(143, 169);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(195, 54);
            this.gbVenta.TabIndex = 21;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Venta:";
            // 
            // rbAgranel
            // 
            this.rbAgranel.AutoSize = true;
            this.rbAgranel.Location = new System.Drawing.Point(106, 29);
            this.rbAgranel.Name = "rbAgranel";
            this.rbAgranel.Size = new System.Drawing.Size(76, 20);
            this.rbAgranel.TabIndex = 22;
            this.rbAgranel.TabStop = true;
            this.rbAgranel.Text = "A Granel";
            this.rbAgranel.UseVisualStyleBackColor = true;
            // 
            // rbUnidad
            // 
            this.rbUnidad.AutoSize = true;
            this.rbUnidad.Location = new System.Drawing.Point(6, 29);
            this.rbUnidad.Name = "rbUnidad";
            this.rbUnidad.Size = new System.Drawing.Size(90, 20);
            this.rbUnidad.TabIndex = 0;
            this.rbUnidad.TabStop = true;
            this.rbUnidad.Text = "Por Unidad";
            this.rbUnidad.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistemas_de_Ventas.Properties.Resources.internet;
            this.pictureBox1.Location = new System.Drawing.Point(394, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCodigoInterno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbIva);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbCodigoExterno);
            this.Controls.Add(this.msProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msProductos;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.msProductos.ResumeLayout(false);
            this.msProductos.PerformLayout();
            this.gbVenta.ResumeLayout(false);
            this.gbVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigoExterno;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoInterno;
        private System.Windows.Forms.MenuStrip msProductos;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARSTOCKToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.RadioButton rbAgranel;
        private System.Windows.Forms.RadioButton rbUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}