namespace Classe7
{
    partial class FormNuevo
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
            this.label4 = new System.Windows.Forms.Label();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textPrecioCom = new System.Windows.Forms.TextBox();
            this.textPrecioVent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Venta";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(178, 297);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(148, 23);
            this.BTNGuardar.TabIndex = 4;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(333, 297);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(148, 23);
            this.BTNCancelar.TabIndex = 5;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(178, 84);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(324, 24);
            this.cmbMarca.TabIndex = 6;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(178, 132);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(303, 22);
            this.textDescripcion.TabIndex = 7;
            // 
            // textPrecioCom
            // 
            this.textPrecioCom.Location = new System.Drawing.Point(178, 183);
            this.textPrecioCom.Name = "textPrecioCom";
            this.textPrecioCom.Size = new System.Drawing.Size(303, 22);
            this.textPrecioCom.TabIndex = 8;
            // 
            // textPrecioVent
            // 
            this.textPrecioVent.Location = new System.Drawing.Point(178, 229);
            this.textPrecioVent.Name = "textPrecioVent";
            this.textPrecioVent.Size = new System.Drawing.Size(303, 22);
            this.textPrecioVent.TabIndex = 9;
            // 
            // FormNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 408);
            this.Controls.Add(this.textPrecioVent);
            this.Controls.Add(this.textPrecioCom);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNuevo";
            this.Text = "FormNuevo";
            this.Load += new System.EventHandler(this.FormNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textPrecioCom;
        private System.Windows.Forms.TextBox textPrecioVent;
    }
}