namespace CatalogoWinForm
{
    partial class frmAgregarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarMarca));
            this.lblTituloAgregarMarca = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.tbAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloAgregarMarca
            // 
            this.lblTituloAgregarMarca.AutoSize = true;
            this.lblTituloAgregarMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregarMarca.Location = new System.Drawing.Point(163, 59);
            this.lblTituloAgregarMarca.Name = "lblTituloAgregarMarca";
            this.lblTituloAgregarMarca.Size = new System.Drawing.Size(198, 25);
            this.lblTituloAgregarMarca.TabIndex = 4;
            this.lblTituloAgregarMarca.Text = "AGREGAR MARCA";
            this.lblTituloAgregarMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Location = new System.Drawing.Point(85, 191);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(160, 31);
            this.btnAgregarMarca.TabIndex = 5;
            this.btnAgregarMarca.Text = "AGREGAR";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.BtnAgregarMarca_Click);
            // 
            // tbAgregarMarca
            // 
            this.tbAgregarMarca.Location = new System.Drawing.Point(141, 125);
            this.tbAgregarMarca.Name = "tbAgregarMarca";
            this.tbAgregarMarca.Size = new System.Drawing.Size(237, 20);
            this.tbAgregarMarca.TabIndex = 6;
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCancelarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlta.Location = new System.Drawing.Point(275, 191);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(160, 31);
            this.btnCancelarAlta.TabIndex = 13;
            this.btnCancelarAlta.Text = "CANCELAR";
            this.btnCancelarAlta.UseVisualStyleBackColor = false;
            this.btnCancelarAlta.Click += new System.EventHandler(this.BtnCancelarAlta_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 294);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.tbAgregarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblTituloAgregarMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 333);
            this.MinimumSize = new System.Drawing.Size(540, 333);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Marca";
            this.Load += new System.EventHandler(this.FrmAgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.TextBox tbAgregarMarca;
        private System.Windows.Forms.Button btnCancelarAlta;
    }
}