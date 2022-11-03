namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_carrito = new System.Windows.Forms.DataGridView();
            this.btn_agregar_carrito = new System.Windows.Forms.Button();
            this.groupBox_producto = new System.Windows.Forms.GroupBox();
            this.txt_descripcion_prod = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_precio_unit_producto = new System.Windows.Forms.TextBox();
            this.label_precio_unit = new System.Windows.Forms.Label();
            this.txt_cantidad_producto = new System.Windows.Forms.TextBox();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.btn_buscar_producto = new System.Windows.Forms.Button();
            this.textbox_id_prod = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.label_id_producto = new System.Windows.Forms.Label();
            this.label_producto = new System.Windows.Forms.Label();
            this.groupBox_cliente = new System.Windows.Forms.GroupBox();
            this.btn_buscar_cliente = new System.Windows.Forms.Button();
            this.textBox_cedula_cliente = new System.Windows.Forms.TextBox();
            this.label_cedula = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label_nombre_cliente = new System.Windows.Forms.Label();
            this.groupbox_carrito = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_carrito)).BeginInit();
            this.groupBox_producto.SuspendLayout();
            this.groupBox_cliente.SuspendLayout();
            this.groupbox_carrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_carrito
            // 
            this.dataGridView_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_carrito.Location = new System.Drawing.Point(6, 38);
            this.dataGridView_carrito.Name = "dataGridView_carrito";
            this.dataGridView_carrito.RowTemplate.Height = 25;
            this.dataGridView_carrito.Size = new System.Drawing.Size(729, 150);
            this.dataGridView_carrito.TabIndex = 0;
            this.dataGridView_carrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_agregar_carrito
            // 
            this.btn_agregar_carrito.Location = new System.Drawing.Point(6, 101);
            this.btn_agregar_carrito.Name = "btn_agregar_carrito";
            this.btn_agregar_carrito.Size = new System.Drawing.Size(176, 23);
            this.btn_agregar_carrito.TabIndex = 1;
            this.btn_agregar_carrito.Text = "Agregar al carrito";
            this.btn_agregar_carrito.UseVisualStyleBackColor = true;
            this.btn_agregar_carrito.Click += new System.EventHandler(this.btn_agregar_carrito_Click);
            // 
            // groupBox_producto
            // 
            this.groupBox_producto.Controls.Add(this.txt_descripcion_prod);
            this.groupBox_producto.Controls.Add(this.lbl_descripcion);
            this.groupBox_producto.Controls.Add(this.txt_precio_unit_producto);
            this.groupBox_producto.Controls.Add(this.label_precio_unit);
            this.groupBox_producto.Controls.Add(this.txt_cantidad_producto);
            this.groupBox_producto.Controls.Add(this.label_cantidad);
            this.groupBox_producto.Controls.Add(this.btn_buscar_producto);
            this.groupBox_producto.Controls.Add(this.textbox_id_prod);
            this.groupBox_producto.Controls.Add(this.textBoxProducto);
            this.groupBox_producto.Controls.Add(this.btn_agregar_carrito);
            this.groupBox_producto.Controls.Add(this.label_id_producto);
            this.groupBox_producto.Controls.Add(this.label_producto);
            this.groupBox_producto.Location = new System.Drawing.Point(12, 108);
            this.groupBox_producto.Name = "groupBox_producto";
            this.groupBox_producto.Size = new System.Drawing.Size(741, 139);
            this.groupBox_producto.TabIndex = 2;
            this.groupBox_producto.TabStop = false;
            this.groupBox_producto.Text = "Datos del Producto";
            // 
            // txt_descripcion_prod
            // 
            this.txt_descripcion_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_descripcion_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_descripcion_prod.Location = new System.Drawing.Point(81, 62);
            this.txt_descripcion_prod.Name = "txt_descripcion_prod";
            this.txt_descripcion_prod.Size = new System.Drawing.Size(210, 23);
            this.txt_descripcion_prod.TabIndex = 13;
            this.txt_descripcion_prod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(6, 65);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(69, 15);
            this.lbl_descripcion.TabIndex = 12;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txt_precio_unit_producto
            // 
            this.txt_precio_unit_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_precio_unit_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_precio_unit_producto.Enabled = false;
            this.txt_precio_unit_producto.Location = new System.Drawing.Point(553, 62);
            this.txt_precio_unit_producto.Name = "txt_precio_unit_producto";
            this.txt_precio_unit_producto.Size = new System.Drawing.Size(63, 23);
            this.txt_precio_unit_producto.TabIndex = 11;
            // 
            // label_precio_unit
            // 
            this.label_precio_unit.AutoSize = true;
            this.label_precio_unit.Location = new System.Drawing.Point(462, 65);
            this.label_precio_unit.Name = "label_precio_unit";
            this.label_precio_unit.Size = new System.Drawing.Size(85, 15);
            this.label_precio_unit.TabIndex = 10;
            this.label_precio_unit.Text = "Precio Unitario";
            // 
            // txt_cantidad_producto
            // 
            this.txt_cantidad_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_cantidad_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_cantidad_producto.Location = new System.Drawing.Point(406, 62);
            this.txt_cantidad_producto.Name = "txt_cantidad_producto";
            this.txt_cantidad_producto.Size = new System.Drawing.Size(50, 23);
            this.txt_cantidad_producto.TabIndex = 9;
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(345, 65);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(55, 15);
            this.label_cantidad.TabIndex = 8;
            this.label_cantidad.Text = "Cantidad";
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.Location = new System.Drawing.Point(622, 26);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(101, 21);
            this.btn_buscar_producto.TabIndex = 7;
            this.btn_buscar_producto.Text = "Buscar";
            this.btn_buscar_producto.UseVisualStyleBackColor = true;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // textbox_id_prod
            // 
            this.textbox_id_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textbox_id_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textbox_id_prod.Location = new System.Drawing.Point(406, 26);
            this.textbox_id_prod.Name = "textbox_id_prod";
            this.textbox_id_prod.Size = new System.Drawing.Size(210, 23);
            this.textbox_id_prod.TabIndex = 6;
            this.textbox_id_prod.TextChanged += new System.EventHandler(this.textbox_id_prod_TextChanged);
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxProducto.Location = new System.Drawing.Point(81, 29);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(210, 23);
            this.textBoxProducto.TabIndex = 1;
            this.textBoxProducto.TextChanged += new System.EventHandler(this.textBoxProducto_TextChanged);
            // 
            // label_id_producto
            // 
            this.label_id_producto.AutoSize = true;
            this.label_id_producto.Location = new System.Drawing.Point(326, 29);
            this.label_id_producto.Name = "label_id_producto";
            this.label_id_producto.Size = new System.Drawing.Size(74, 15);
            this.label_id_producto.TabIndex = 5;
            this.label_id_producto.Text = "Identificador";
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Location = new System.Drawing.Point(6, 32);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(51, 15);
            this.label_producto.TabIndex = 0;
            this.label_producto.Text = "Nombre";
            // 
            // groupBox_cliente
            // 
            this.groupBox_cliente.Controls.Add(this.btn_buscar_cliente);
            this.groupBox_cliente.Controls.Add(this.textBox_cedula_cliente);
            this.groupBox_cliente.Controls.Add(this.label_cedula);
            this.groupBox_cliente.Controls.Add(this.textBoxCliente);
            this.groupBox_cliente.Controls.Add(this.label_nombre_cliente);
            this.groupBox_cliente.Location = new System.Drawing.Point(12, 31);
            this.groupBox_cliente.Name = "groupBox_cliente";
            this.groupBox_cliente.Size = new System.Drawing.Size(741, 71);
            this.groupBox_cliente.TabIndex = 3;
            this.groupBox_cliente.TabStop = false;
            this.groupBox_cliente.Text = "Datos del Cliente";
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.Location = new System.Drawing.Point(622, 29);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(101, 23);
            this.btn_buscar_cliente.TabIndex = 4;
            this.btn_buscar_cliente.Text = "Buscar";
            this.btn_buscar_cliente.UseVisualStyleBackColor = true;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // textBox_cedula_cliente
            // 
            this.textBox_cedula_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_cedula_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_cedula_cliente.Location = new System.Drawing.Point(406, 29);
            this.textBox_cedula_cliente.Name = "textBox_cedula_cliente";
            this.textBox_cedula_cliente.Size = new System.Drawing.Size(210, 23);
            this.textBox_cedula_cliente.TabIndex = 3;
            // 
            // label_cedula
            // 
            this.label_cedula.AutoSize = true;
            this.label_cedula.Location = new System.Drawing.Point(287, 32);
            this.label_cedula.Name = "label_cedula";
            this.label_cedula.Size = new System.Drawing.Size(113, 15);
            this.label_cedula.TabIndex = 2;
            this.label_cedula.Text = "Cedula de Identidad";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCliente.Location = new System.Drawing.Point(63, 29);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(210, 23);
            this.textBoxCliente.TabIndex = 1;
            this.textBoxCliente.TextChanged += new System.EventHandler(this.textBoxCliente_TextChanged);
            // 
            // label_nombre_cliente
            // 
            this.label_nombre_cliente.AutoSize = true;
            this.label_nombre_cliente.Location = new System.Drawing.Point(6, 32);
            this.label_nombre_cliente.Name = "label_nombre_cliente";
            this.label_nombre_cliente.Size = new System.Drawing.Size(51, 15);
            this.label_nombre_cliente.TabIndex = 0;
            this.label_nombre_cliente.Text = "Nombre";
            // 
            // groupbox_carrito
            // 
            this.groupbox_carrito.Controls.Add(this.dataGridView_carrito);
            this.groupbox_carrito.Location = new System.Drawing.Point(12, 265);
            this.groupbox_carrito.Name = "groupbox_carrito";
            this.groupbox_carrito.Size = new System.Drawing.Size(741, 208);
            this.groupbox_carrito.TabIndex = 4;
            this.groupbox_carrito.TabStop = false;
            this.groupbox_carrito.Text = "Carrito de Compras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 622);
            this.Controls.Add(this.groupbox_carrito);
            this.Controls.Add(this.groupBox_cliente);
            this.Controls.Add(this.groupBox_producto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_carrito)).EndInit();
            this.groupBox_producto.ResumeLayout(false);
            this.groupBox_producto.PerformLayout();
            this.groupBox_cliente.ResumeLayout(false);
            this.groupBox_cliente.PerformLayout();
            this.groupbox_carrito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_carrito;
        private Button btn_agregar_carrito;
        private GroupBox groupBox_producto;
        private TextBox textBoxProducto;
        private Label label_producto;
        private GroupBox groupBox_cliente;
        private TextBox textBoxCliente;
        private Label label_nombre_cliente;
        private Button btn_buscar_producto;
        private TextBox textbox_id_prod;
        private Label label_id_producto;
        private Button btn_buscar_cliente;
        private TextBox textBox_cedula_cliente;
        private Label label_cedula;
        private GroupBox groupbox_carrito;
        private TextBox txt_precio_unit_producto;
        private Label label_precio_unit;
        private TextBox txt_cantidad_producto;
        private Label label_cantidad;
        private TextBox txt_descripcion_prod;
        private Label lbl_descripcion;
    }
}