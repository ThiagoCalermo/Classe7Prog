namespace Classe7
{
    partial class FormNuevoMarca
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
            this.txtIdMarcaNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIdMarcaNew
            // 
            this.txtIdMarcaNew.Location = new System.Drawing.Point(161, 63);
            this.txtIdMarcaNew.Name = "txtIdMarcaNew";
            this.txtIdMarcaNew.Size = new System.Drawing.Size(190, 22);
            this.txtIdMarcaNew.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción de la nueva marca";
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Location = new System.Drawing.Point(116, 111);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(129, 23);
            this.btnNuevaMarca.TabIndex = 2;
            this.btnNuevaMarca.Text = "Agregar";
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            this.btnNuevaMarca.Click += new System.EventHandler(this.btnNuevaMarca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 111);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormNuevoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 176);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevaMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdMarcaNew);
            this.Name = "FormNuevoMarca";
            this.Text = "FormNuevoMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdMarcaNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.Button btnCancelar;
    }
}