
namespace _LaboratorioProgramacionUno_.VISTAS
{
    partial class frmOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblConIva = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTSinIva = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIvaAgregar = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio del producto";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(1193, 360);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(21, 20);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "...";
            // 
            // lblConIva
            // 
            this.lblConIva.AutoSize = true;
            this.lblConIva.Location = new System.Drawing.Point(1193, 551);
            this.lblConIva.Name = "lblConIva";
            this.lblConIva.Size = new System.Drawing.Size(21, 20);
            this.lblConIva.TabIndex = 4;
            this.lblConIva.Text = "...";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(1193, 615);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(21, 20);
            this.lblTotalAPagar.TabIndex = 5;
            this.lblTotalAPagar.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(875, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad";
            // 
            // lblTSinIva
            // 
            this.lblTSinIva.AutoSize = true;
            this.lblTSinIva.Location = new System.Drawing.Point(1193, 462);
            this.lblTSinIva.Name = "lblTSinIva";
            this.lblTSinIva.Size = new System.Drawing.Size(21, 20);
            this.lblTSinIva.TabIndex = 8;
            this.lblTSinIva.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Iva";
            // 
            // lblIvaAgregar
            // 
            this.lblIvaAgregar.AutoSize = true;
            this.lblIvaAgregar.Location = new System.Drawing.Point(1193, 502);
            this.lblIvaAgregar.Name = "lblIvaAgregar";
            this.lblIvaAgregar.Size = new System.Drawing.Size(21, 20);
            this.lblIvaAgregar.TabIndex = 10;
            this.lblIvaAgregar.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(875, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total sin descuento y con IVA incluido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(875, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Producto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(875, 502);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Iva a agregar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(875, 462);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Total sin iva:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(1193, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(21, 20);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1193, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Usuario actual";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(58, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1327, 182);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ACCION";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "REGLA";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(237, 360);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(319, 26);
            this.txtIva.TabIndex = 18;
            this.txtIva.Text = "0.13";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(237, 575);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(319, 26);
            this.txtCantidad.TabIndex = 19;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(237, 502);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(319, 26);
            this.txtPrecioProducto.TabIndex = 20;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(237, 438);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(319, 26);
            this.txtNombreProducto.TabIndex = 21;
            this.txtNombreProducto.Text = "LAPTOP";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(535, 658);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 38);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmOperaciones
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1408, 729);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblIvaAgregar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTSinIva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.lblConIva);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOperaciones";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblConIva;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTSinIva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIvaAgregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox txtNombreProducto;
    }
}