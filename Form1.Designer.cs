namespace Cafeteria
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
            dgvCafe = new DataGridView();
            lblProducto = new Label();
            cmbBoxProducto = new ComboBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCantidad = new Label();
            nmUDCantidad = new NumericUpDown();
            chkLlevar = new CheckBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVaciar = new Button();
            lblTotal = new Label();
            label1 = new Label();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCafe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmUDCantidad).BeginInit();
            SuspendLayout();
            // 
            // dgvCafe
            // 
            dgvCafe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCafe.Location = new Point(313, 12);
            dgvCafe.Name = "dgvCafe";
            dgvCafe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCafe.Size = new Size(464, 242);
            dgvCafe.TabIndex = 0;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(17, 30);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto:";
            // 
            // cmbBoxProducto
            // 
            cmbBoxProducto.FormattingEnabled = true;
            cmbBoxProducto.Location = new Point(144, 22);
            cmbBoxProducto.Name = "cmbBoxProducto";
            cmbBoxProducto.Size = new Size(121, 23);
            cmbBoxProducto.TabIndex = 2;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(17, 75);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(88, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio Unitario:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(144, 72);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(17, 125);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // nmUDCantidad
            // 
            nmUDCantidad.Location = new Point(145, 125);
            nmUDCantidad.Name = "nmUDCantidad";
            nmUDCantidad.Size = new Size(120, 23);
            nmUDCantidad.TabIndex = 6;
            // 
            // chkLlevar
            // 
            chkLlevar.AutoSize = true;
            chkLlevar.Location = new Point(24, 180);
            chkLlevar.Name = "chkLlevar";
            chkLlevar.Size = new Size(172, 19);
            chkLlevar.TabIndex = 7;
            chkLlevar.Text = "Para llevar (+5$ por pedido)";
            chkLlevar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(30, 232);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(111, 232);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(192, 231);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(75, 23);
            btnVaciar.TabIndex = 8;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(612, 303);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(618, 303);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Total:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(674, 303);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 380);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(btnVaciar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(chkLlevar);
            Controls.Add(nmUDCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(cmbBoxProducto);
            Controls.Add(lblProducto);
            Controls.Add(dgvCafe);
            Name = "Form1";
            Text = "Cafeteria";
            ((System.ComponentModel.ISupportInitialize)dgvCafe).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmUDCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCafe;
        private Label lblProducto;
        private ComboBox cmbBoxProducto;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCantidad;
        private NumericUpDown nmUDCantidad;
        private CheckBox chkLlevar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVaciar;
        private Label lblTotal;
        private Label label1;
        private Label lblResultado;
    }
}
