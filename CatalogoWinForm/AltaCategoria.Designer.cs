namespace CatalogoWinForm
{
    partial class AltaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCategoria));
            this.tbAltaCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblTituloAgregarCategoria = new System.Windows.Forms.Label();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAltaCategoria
            // 
            this.tbAltaCategoria.Location = new System.Drawing.Point(141, 125);
            this.tbAltaCategoria.Name = "tbAltaCategoria";
            this.tbAltaCategoria.Size = new System.Drawing.Size(250, 20);
            this.tbAltaCategoria.TabIndex = 0;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.AccessibleDescription = "Agregar";
            this.btnAgregarCategoria.AccessibleName = "Agregar";
            this.btnAgregarCategoria.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(85, 191);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(160, 31);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // lblTituloAgregarCategoria
            // 
            this.lblTituloAgregarCategoria.AutoSize = true;
            this.lblTituloAgregarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregarCategoria.Location = new System.Drawing.Point(147, 58);
            this.lblTituloAgregarCategoria.Name = "lblTituloAgregarCategoria";
            this.lblTituloAgregarCategoria.Size = new System.Drawing.Size(244, 25);
            this.lblTituloAgregarCategoria.TabIndex = 7;
            this.lblTituloAgregarCategoria.Text = "AGREGAR CATEGORIA";
            this.lblTituloAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCancelarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlta.Location = new System.Drawing.Point(275, 191);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(160, 31);
            this.btnCancelarAlta.TabIndex = 2;
            this.btnCancelarAlta.Text = "CANCELAR";
            this.btnCancelarAlta.UseVisualStyleBackColor = false;
            this.btnCancelarAlta.Click += new System.EventHandler(this.BtnCancelarAlta_Click);
            // 
            // AltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 294);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.tbAltaCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblTituloAgregarCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 333);
            this.MinimumSize = new System.Drawing.Size(540, 333);
            this.Name = "AltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Categoria";
            this.Load += new System.EventHandler(this.AltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAltaCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblTituloAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarAlta;
    }
}