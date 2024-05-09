namespace CatalogoWinForm
{
    partial class ListaCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCategorias));
            this.tbBuscarCategorias = new System.Windows.Forms.TextBox();
            this.lblTituloCategorias = new System.Windows.Forms.Label();
            this.btnEliminarCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.dgvListaCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            this.PanelListar = new System.Windows.Forms.Panel();
            this.PanelBotones = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).BeginInit();
            this.PanelListar.SuspendLayout();
            this.PanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBuscarCategorias
            // 
            this.tbBuscarCategorias.BackColor = System.Drawing.Color.White;
            this.tbBuscarCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscarCategorias.Location = new System.Drawing.Point(79, 99);
            this.tbBuscarCategorias.MinimumSize = new System.Drawing.Size(269, 20);
            this.tbBuscarCategorias.Name = "tbBuscarCategorias";
            this.tbBuscarCategorias.Size = new System.Drawing.Size(269, 20);
            this.tbBuscarCategorias.TabIndex = 1;
            this.tbBuscarCategorias.TextChanged += new System.EventHandler(this.TbBuscarCategorias_TextChanged);
            // 
            // lblTituloCategorias
            // 
            this.lblTituloCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCategorias.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTituloCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTituloCategorias.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategorias.Location = new System.Drawing.Point(79, 41);
            this.lblTituloCategorias.Name = "lblTituloCategorias";
            this.lblTituloCategorias.Size = new System.Drawing.Size(661, 40);
            this.lblTituloCategorias.TabIndex = 9;
            this.lblTituloCategorias.Text = "CATEGORIAS";
            this.lblTituloCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarCategorias.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEliminarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategorias.Location = new System.Drawing.Point(468, 16);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(165, 45);
            this.btnEliminarCategorias.TabIndex = 5;
            this.btnEliminarCategorias.Text = "ELIMINAR";
            this.btnEliminarCategorias.UseVisualStyleBackColor = false;
            this.btnEliminarCategorias.Click += new System.EventHandler(this.BtnEliminarCategorias_Click);
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarCategorias.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModificarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategorias.Location = new System.Drawing.Point(242, 16);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(174, 45);
            this.btnModificarCategorias.TabIndex = 4;
            this.btnModificarCategorias.Text = "MODIFICAR";
            this.btnModificarCategorias.UseVisualStyleBackColor = false;
            this.btnModificarCategorias.Click += new System.EventHandler(this.BtnModificarCategorias_Click);
            // 
            // dgvListaCategorias
            // 
            this.dgvListaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCategorias.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaCategorias.Location = new System.Drawing.Point(20, 13);
            this.dgvListaCategorias.MultiSelect = false;
            this.dgvListaCategorias.Name = "dgvListaCategorias";
            this.dgvListaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCategorias.Size = new System.Drawing.Size(613, 236);
            this.dgvListaCategorias.TabIndex = 2;
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarCategorias.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategorias.Location = new System.Drawing.Point(20, 16);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(174, 45);
            this.btnAgregarCategorias.TabIndex = 3;
            this.btnAgregarCategorias.Text = "AGREGAR";
            this.btnAgregarCategorias.UseVisualStyleBackColor = false;
            this.btnAgregarCategorias.Click += new System.EventHandler(this.BtnAgregarCategorias_Click);
            // 
            // PanelListar
            // 
            this.PanelListar.BackColor = System.Drawing.Color.White;
            this.PanelListar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelListar.Controls.Add(this.dgvListaCategorias);
            this.PanelListar.Location = new System.Drawing.Point(79, 125);
            this.PanelListar.Name = "PanelListar";
            this.PanelListar.Size = new System.Drawing.Size(661, 262);
            this.PanelListar.TabIndex = 23;
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.White;
            this.PanelBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBotones.Controls.Add(this.btnAgregarCategorias);
            this.PanelBotones.Controls.Add(this.btnModificarCategorias);
            this.PanelBotones.Controls.Add(this.btnEliminarCategorias);
            this.PanelBotones.Location = new System.Drawing.Point(79, 393);
            this.PanelBotones.MaximumSize = new System.Drawing.Size(661, 81);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(661, 81);
            this.PanelBotones.TabIndex = 24;
            // 
            // ListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.tbBuscarCategorias);
            this.Controls.Add(this.lblTituloCategorias);
            this.Controls.Add(this.PanelListar);
            this.Controls.Add(this.PanelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ListaCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Categorias";
            this.Load += new System.EventHandler(this.ListaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).EndInit();
            this.PanelListar.ResumeLayout(false);
            this.PanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBuscarCategorias;
        private System.Windows.Forms.Label lblTituloCategorias;
        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.DataGridView dgvListaCategorias;
        private System.Windows.Forms.Button btnAgregarCategorias;
        private System.Windows.Forms.Panel PanelListar;
        private System.Windows.Forms.Panel PanelBotones;
    }
}