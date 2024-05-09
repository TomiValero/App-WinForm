namespace CatalogoWinForm
{
    partial class ListaMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaMarcas));
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.btnModificarMarcas = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.tbBuscarMarcas = new System.Windows.Forms.TextBox();
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.PanelListar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.PanelListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaMarcas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaMarcas.Location = new System.Drawing.Point(28, 12);
            this.dgvListaMarcas.MultiSelect = false;
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.RowHeadersWidth = 51;
            this.dgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarcas.Size = new System.Drawing.Size(613, 236);
            this.dgvListaMarcas.TabIndex = 3;
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarMarcas.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModificarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarcas.Location = new System.Drawing.Point(245, 17);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(174, 45);
            this.btnModificarMarcas.TabIndex = 5;
            this.btnModificarMarcas.Text = "MODIFICAR";
            this.btnModificarMarcas.UseVisualStyleBackColor = false;
            this.btnModificarMarcas.Click += new System.EventHandler(this.BtnModificarMarcas_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarMarca.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.Location = new System.Drawing.Point(476, 17);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(165, 45);
            this.btnEliminarMarca.TabIndex = 6;
            this.btnEliminarMarca.Text = "ELIMINAR";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            this.btnEliminarMarca.Click += new System.EventHandler(this.BtnEliminarMarca_Click);
            // 
            // lblTituloMarcas
            // 
            this.lblTituloMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloMarcas.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTituloMarcas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloMarcas.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarcas.Location = new System.Drawing.Point(79, 41);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(661, 40);
            this.lblTituloMarcas.TabIndex = 3;
            this.lblTituloMarcas.Text = "MARCAS";
            this.lblTituloMarcas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbBuscarMarcas
            // 
            this.tbBuscarMarcas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbBuscarMarcas.Location = new System.Drawing.Point(79, 99);
            this.tbBuscarMarcas.MinimumSize = new System.Drawing.Size(238, 20);
            this.tbBuscarMarcas.Name = "tbBuscarMarcas";
            this.tbBuscarMarcas.Size = new System.Drawing.Size(269, 20);
            this.tbBuscarMarcas.TabIndex = 1;
            this.tbBuscarMarcas.TextChanged += new System.EventHandler(this.TbBuscarMarcas_TextChanged);
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarMarcas.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarcas.Location = new System.Drawing.Point(28, 17);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(174, 45);
            this.btnAgregarMarcas.TabIndex = 4;
            this.btnAgregarMarcas.Text = "AGREGAR";
            this.btnAgregarMarcas.UseVisualStyleBackColor = false;
            this.btnAgregarMarcas.Click += new System.EventHandler(this.BtnAgregarMarcas_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.White;
            this.PanelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotones.Controls.Add(this.btnAgregarMarcas);
            this.PanelBotones.Controls.Add(this.btnEliminarMarca);
            this.PanelBotones.Controls.Add(this.btnModificarMarcas);
            this.PanelBotones.Location = new System.Drawing.Point(79, 393);
            this.PanelBotones.MaximumSize = new System.Drawing.Size(661, 81);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(661, 81);
            this.PanelBotones.TabIndex = 25;
            // 
            // PanelListar
            // 
            this.PanelListar.BackColor = System.Drawing.Color.White;
            this.PanelListar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelListar.Controls.Add(this.dgvListaMarcas);
            this.PanelListar.Location = new System.Drawing.Point(79, 125);
            this.PanelListar.Name = "PanelListar";
            this.PanelListar.Size = new System.Drawing.Size(661, 262);
            this.PanelListar.TabIndex = 26;
            // 
            // ListaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.tbBuscarMarcas);
            this.Controls.Add(this.lblTituloMarcas);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.PanelListar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ListaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Marcas";
            this.Load += new System.EventHandler(this.ListaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.PanelListar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.TextBox tbBuscarMarcas;
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel PanelListar;
    }
}