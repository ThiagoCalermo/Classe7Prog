namespace Classe7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBBuscarMarca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNBuscarMarca = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTBBuscarDescripcion = new System.Windows.Forms.TextBox();
            this.BTNBuscarDescripcion = new System.Windows.Forms.Button();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNBuscarId = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTBBuscarID = new System.Windows.Forms.TextBox();
            this.btnBuscarTodo = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnIdMarca = new System.Windows.Forms.Button();
            this.btnDescripcionMarca = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por Marca";
            // 
            // TXTBBuscarMarca
            // 
            this.TXTBBuscarMarca.Location = new System.Drawing.Point(129, 150);
            this.TXTBBuscarMarca.Name = "TXTBBuscarMarca";
            this.TXTBBuscarMarca.Size = new System.Drawing.Size(237, 22);
            this.TXTBBuscarMarca.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            // 
            // BTNBuscarMarca
            // 
            this.BTNBuscarMarca.Location = new System.Drawing.Point(204, 192);
            this.BTNBuscarMarca.Name = "BTNBuscarMarca";
            this.BTNBuscarMarca.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscarMarca.TabIndex = 5;
            this.BTNBuscarMarca.Text = "Buscar";
            this.BTNBuscarMarca.UseVisualStyleBackColor = true;
            this.BTNBuscarMarca.Click += new System.EventHandler(this.BTNBuscarMarca_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 15;
            // 
            // TXTBBuscarDescripcion
            // 
            this.TXTBBuscarDescripcion.Location = new System.Drawing.Point(129, 263);
            this.TXTBBuscarDescripcion.Name = "TXTBBuscarDescripcion";
            this.TXTBBuscarDescripcion.Size = new System.Drawing.Size(237, 22);
            this.TXTBBuscarDescripcion.TabIndex = 7;
            // 
            // BTNBuscarDescripcion
            // 
            this.BTNBuscarDescripcion.Location = new System.Drawing.Point(212, 305);
            this.BTNBuscarDescripcion.Name = "BTNBuscarDescripcion";
            this.BTNBuscarDescripcion.Size = new System.Drawing.Size(56, 23);
            this.BTNBuscarDescripcion.TabIndex = 8;
            this.BTNBuscarDescripcion.Text = "Buscar";
            this.BTNBuscarDescripcion.UseVisualStyleBackColor = true;
            this.BTNBuscarDescripcion.Click += new System.EventHandler(this.BTNBuscarDescripcion_Click);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(396, 562);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(75, 23);
            this.BTNNuevo.TabIndex = 10;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(477, 562);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(75, 23);
            this.BTNModificar.TabIndex = 11;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(558, 562);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 12;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // BTNBuscarId
            // 
            this.BTNBuscarId.Location = new System.Drawing.Point(210, 85);
            this.BTNBuscarId.Name = "BTNBuscarId";
            this.BTNBuscarId.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscarId.TabIndex = 17;
            this.BTNBuscarId.Text = "Buscar";
            this.BTNBuscarId.UseVisualStyleBackColor = true;
            this.BTNBuscarId.Click += new System.EventHandler(this.BTNBuscarId_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Buscar por Descripción";
            // 
            // TXTBBuscarID
            // 
            this.TXTBBuscarID.Location = new System.Drawing.Point(129, 44);
            this.TXTBBuscarID.Name = "TXTBBuscarID";
            this.TXTBBuscarID.Size = new System.Drawing.Size(237, 22);
            this.TXTBBuscarID.TabIndex = 2;
            // 
            // btnBuscarTodo
            // 
            this.btnBuscarTodo.Location = new System.Drawing.Point(173, 334);
            this.btnBuscarTodo.Name = "btnBuscarTodo";
            this.btnBuscarTodo.Size = new System.Drawing.Size(137, 23);
            this.btnBuscarTodo.TabIndex = 19;
            this.btnBuscarTodo.Text = "buscar todo";
            this.btnBuscarTodo.UseVisualStyleBackColor = true;
            this.btnBuscarTodo.Click += new System.EventHandler(this.btnBuscarTodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Buscar Marca por id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Buscar marca por descripción";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(678, 37);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(237, 22);
            this.txtIdMarca.TabIndex = 22;
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(678, 150);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(237, 22);
            this.txtDescripcionMarca.TabIndex = 23;
            // 
            // btnIdMarca
            // 
            this.btnIdMarca.Location = new System.Drawing.Point(763, 79);
            this.btnIdMarca.Name = "btnIdMarca";
            this.btnIdMarca.Size = new System.Drawing.Size(75, 23);
            this.btnIdMarca.TabIndex = 24;
            this.btnIdMarca.Text = "Buscar";
            this.btnIdMarca.UseVisualStyleBackColor = true;
            this.btnIdMarca.Click += new System.EventHandler(this.btnIdMarca_Click);
            // 
            // btnDescripcionMarca
            // 
            this.btnDescripcionMarca.Location = new System.Drawing.Point(763, 192);
            this.btnDescripcionMarca.Name = "btnDescripcionMarca";
            this.btnDescripcionMarca.Size = new System.Drawing.Size(75, 23);
            this.btnDescripcionMarca.TabIndex = 25;
            this.btnDescripcionMarca.Text = "Buscar";
            this.btnDescripcionMarca.UseVisualStyleBackColor = true;
            this.btnDescripcionMarca.Click += new System.EventHandler(this.btnDescripcionMarca_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(735, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Buscar todo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Location = new System.Drawing.Point(736, 263);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(136, 23);
            this.btnNuevaMarca.TabIndex = 27;
            this.btnNuevaMarca.Text = "Nueva Marca";
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            this.btnNuevaMarca.Click += new System.EventHandler(this.btnNuevaMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(736, 325);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(136, 23);
            this.btnEliminarMarca.TabIndex = 28;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(736, 296);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(136, 23);
            this.btnModificarMarca.TabIndex = 29;
            this.btnModificarMarca.Text = "Modificar Marca";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 597);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnNuevaMarca);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDescripcionMarca);
            this.Controls.Add(this.btnIdMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarTodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNBuscarId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.BTNBuscarDescripcion);
            this.Controls.Add(this.TXTBBuscarDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNBuscarMarca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTBBuscarMarca);
            this.Controls.Add(this.TXTBBuscarID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBBuscarMarca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNBuscarMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTBBuscarDescripcion;
        private System.Windows.Forms.Button BTNBuscarDescripcion;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNBuscarId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTBBuscarID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnBuscarTodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnIdMarca;
        private System.Windows.Forms.Button btnDescripcionMarca;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
    }
}

