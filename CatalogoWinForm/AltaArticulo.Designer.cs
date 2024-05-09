namespace CatalogoWinForm
{
    partial class AltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaArticulo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnSubirImgAgregarArt = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.btnBeforeImg = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.pbImgAgregar = new System.Windows.Forms.PictureBox();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAgregarImg = new System.Windows.Forms.Panel();
            this.PanelAtributos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAgregar)).BeginInit();
            this.PanelAgregarImg.SuspendLayout();
            this.PanelAtributos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(46, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(43, 103);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(46, 119);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(241, 21);
            this.cboCategoria.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(45, 151);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 13);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "MARCA";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(46, 166);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(241, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(43, 203);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(46, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(241, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(249, 320);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(215, 34);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(46, 270);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(43, 253);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // btnSubirImgAgregarArt
            // 
            this.btnSubirImgAgregarArt.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSubirImgAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirImgAgregarArt.Location = new System.Drawing.Point(342, 26);
            this.btnSubirImgAgregarArt.Name = "btnSubirImgAgregarArt";
            this.btnSubirImgAgregarArt.Size = new System.Drawing.Size(25, 23);
            this.btnSubirImgAgregarArt.TabIndex = 38;
            this.btnSubirImgAgregarArt.Text = "+";
            this.btnSubirImgAgregarArt.UseVisualStyleBackColor = false;
            this.btnSubirImgAgregarArt.Click += new System.EventHandler(this.BtnSubirImgAgregarArt_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(46, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(241, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "CODIGO";
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.BackColor = System.Drawing.Color.Red;
            this.btnEliminarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarImg.Location = new System.Drawing.Point(342, 63);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(21, 20);
            this.btnEliminarImg.TabIndex = 45;
            this.btnEliminarImg.Text = "X";
            this.btnEliminarImg.UseVisualStyleBackColor = false;
            this.btnEliminarImg.Click += new System.EventHandler(this.BtnEliminarImg_Click);
            // 
            // btnBeforeImg
            // 
            this.btnBeforeImg.BackColor = System.Drawing.Color.PaleGreen;
            this.btnBeforeImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeforeImg.Location = new System.Drawing.Point(21, 158);
            this.btnBeforeImg.Name = "btnBeforeImg";
            this.btnBeforeImg.Size = new System.Drawing.Size(29, 34);
            this.btnBeforeImg.TabIndex = 44;
            this.btnBeforeImg.Text = "<";
            this.btnBeforeImg.UseVisualStyleBackColor = false;
            this.btnBeforeImg.Click += new System.EventHandler(this.BtnBeforeImg_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNextImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImg.Location = new System.Drawing.Point(369, 158);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(29, 34);
            this.btnNextImg.TabIndex = 43;
            this.btnNextImg.Text = ">";
            this.btnNextImg.UseVisualStyleBackColor = false;
            this.btnNextImg.Click += new System.EventHandler(this.BtnNextImg_Click);
            // 
            // pbImgAgregar
            // 
            this.pbImgAgregar.Location = new System.Drawing.Point(56, 63);
            this.pbImgAgregar.Name = "pbImgAgregar";
            this.pbImgAgregar.Size = new System.Drawing.Size(307, 226);
            this.pbImgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgAgregar.TabIndex = 42;
            this.pbImgAgregar.TabStop = false;
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(56, 28);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(276, 20);
            this.txtUrlImg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "URL DE IMAGEN";
            // 
            // PanelAgregarImg
            // 
            this.PanelAgregarImg.BackColor = System.Drawing.Color.White;
            this.PanelAgregarImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAgregarImg.Controls.Add(this.label2);
            this.PanelAgregarImg.Controls.Add(this.txtUrlImg);
            this.PanelAgregarImg.Controls.Add(this.btnEliminarImg);
            this.PanelAgregarImg.Controls.Add(this.btnBeforeImg);
            this.PanelAgregarImg.Controls.Add(this.btnNextImg);
            this.PanelAgregarImg.Controls.Add(this.pbImgAgregar);
            this.PanelAgregarImg.Controls.Add(this.btnSubirImgAgregarArt);
            this.PanelAgregarImg.Location = new System.Drawing.Point(355, 7);
            this.PanelAgregarImg.Name = "PanelAgregarImg";
            this.PanelAgregarImg.Size = new System.Drawing.Size(419, 304);
            this.PanelAgregarImg.TabIndex = 48;
            // 
            // PanelAtributos
            // 
            this.PanelAtributos.BackColor = System.Drawing.Color.White;
            this.PanelAtributos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAtributos.Controls.Add(this.txtCodigo);
            this.PanelAtributos.Controls.Add(this.label1);
            this.PanelAtributos.Controls.Add(this.txtDescripcion);
            this.PanelAtributos.Controls.Add(this.lblDescripcion);
            this.PanelAtributos.Controls.Add(this.txtPrecio);
            this.PanelAtributos.Controls.Add(this.lblPrecio);
            this.PanelAtributos.Controls.Add(this.cboMarca);
            this.PanelAtributos.Controls.Add(this.lblMarca);
            this.PanelAtributos.Controls.Add(this.cboCategoria);
            this.PanelAtributos.Controls.Add(this.lblCategoria);
            this.PanelAtributos.Controls.Add(this.txtNombre);
            this.PanelAtributos.Controls.Add(this.lblNombre);
            this.PanelAtributos.Location = new System.Drawing.Point(12, 7);
            this.PanelAtributos.Name = "PanelAtributos";
            this.PanelAtributos.Size = new System.Drawing.Size(325, 304);
            this.PanelAtributos.TabIndex = 49;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(783, 366);
            this.Controls.Add(this.PanelAtributos);
            this.Controls.Add(this.PanelAgregarImg);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(799, 405);
            this.MinimumSize = new System.Drawing.Size(799, 405);
            this.Name = "AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAgregar)).EndInit();
            this.PanelAgregarImg.ResumeLayout(false);
            this.PanelAgregarImg.PerformLayout();
            this.PanelAtributos.ResumeLayout(false);
            this.PanelAtributos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnSubirImgAgregarArt;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarImg;
        private System.Windows.Forms.Button btnBeforeImg;
        private System.Windows.Forms.Button btnNextImg;
        private System.Windows.Forms.PictureBox pbImgAgregar;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelAgregarImg;
        private System.Windows.Forms.Panel PanelAtributos;
    }
}