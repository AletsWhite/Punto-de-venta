
namespace PuntoDeVenta
{
    partial class ProductoVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtvProducto = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblNumeroOrde = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvProducto
            // 
            this.dtvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProducto.Location = new System.Drawing.Point(38, 55);
            this.dtvProducto.Name = "dtvProducto";
            this.dtvProducto.RowHeadersWidth = 51;
            this.dtvProducto.RowTemplate.Height = 24;
            this.dtvProducto.Size = new System.Drawing.Size(574, 342);
            this.dtvProducto.TabIndex = 0;
            this.dtvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvProducto_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(163, 414);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(77, 34);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(38, 420);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(106, 22);
            this.txtProducto.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(278, 452);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(143, 22);
            this.txtClave.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(278, 480);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(278, 508);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(275, 409);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(49, 17);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "Datos:";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(464, 508);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(121, 39);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblNumeroOrde
            // 
            this.lblNumeroOrde.AutoSize = true;
            this.lblNumeroOrde.Location = new System.Drawing.Point(275, 431);
            this.lblNumeroOrde.Name = "lblNumeroOrde";
            this.lblNumeroOrde.Size = new System.Drawing.Size(0, 17);
            this.lblNumeroOrde.TabIndex = 8;
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(464, 437);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(54, 22);
            this.Cantidad.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(464, 474);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(124, 22);
            this.dtpFecha.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRODUCTO";
            // 
            // ProductoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.lblNumeroOrde);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dtvProducto);
            this.Name = "ProductoVenta";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dtvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvProducto;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblNumeroOrde;
        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
    }
}

