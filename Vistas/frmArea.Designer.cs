namespace ProyectoOra
{
    partial class frmArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsignarTrabajador = new System.Windows.Forms.Button();
            this.btnModificarUI = new System.Windows.Forms.Button();
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.btnUInternas = new System.Windows.Forms.Button();
            this.btnCargarAreas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Interfaz de Areas";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.Location = new System.Drawing.Point(619, 269);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(156, 42);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsignarTrabajador
            // 
            this.btnAsignarTrabajador.BackColor = System.Drawing.SystemColors.Control;
            this.btnAsignarTrabajador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarTrabajador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAsignarTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTrabajador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTrabajador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAsignarTrabajador.Location = new System.Drawing.Point(619, 167);
            this.btnAsignarTrabajador.Name = "btnAsignarTrabajador";
            this.btnAsignarTrabajador.Size = new System.Drawing.Size(156, 48);
            this.btnAsignarTrabajador.TabIndex = 15;
            this.btnAsignarTrabajador.Text = "Eliminar Areas";
            this.btnAsignarTrabajador.UseVisualStyleBackColor = false;
            this.btnAsignarTrabajador.Click += new System.EventHandler(this.btnAsignarTrabajador_Click);
            // 
            // btnModificarUI
            // 
            this.btnModificarUI.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUI.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificarUI.Location = new System.Drawing.Point(619, 119);
            this.btnModificarUI.Name = "btnModificarUI";
            this.btnModificarUI.Size = new System.Drawing.Size(156, 42);
            this.btnModificarUI.TabIndex = 14;
            this.btnModificarUI.Text = "Modificar";
            this.btnModificarUI.UseVisualStyleBackColor = false;
            this.btnModificarUI.Click += new System.EventHandler(this.btnModificarUI_Click);
            // 
            // dgvAreas
            // 
            this.dgvAreas.AllowUserToAddRows = false;
            this.dgvAreas.AllowUserToDeleteRows = false;
            this.dgvAreas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAreas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAreas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.EnableHeadersVisualStyles = false;
            this.dgvAreas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAreas.Location = new System.Drawing.Point(27, 67);
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.ReadOnly = true;
            this.dgvAreas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAreas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAreas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgvAreas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAreas.Size = new System.Drawing.Size(572, 244);
            this.dgvAreas.TabIndex = 13;
            // 
            // btnUInternas
            // 
            this.btnUInternas.BackColor = System.Drawing.SystemColors.Control;
            this.btnUInternas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUInternas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUInternas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUInternas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUInternas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUInternas.Location = new System.Drawing.Point(619, 67);
            this.btnUInternas.Name = "btnUInternas";
            this.btnUInternas.Size = new System.Drawing.Size(156, 46);
            this.btnUInternas.TabIndex = 12;
            this.btnUInternas.Text = "Añadir Areas";
            this.btnUInternas.UseVisualStyleBackColor = false;
            this.btnUInternas.Click += new System.EventHandler(this.btnUInternas_Click);
            // 
            // btnCargarAreas
            // 
            this.btnCargarAreas.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargarAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarAreas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCargarAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAreas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAreas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarAreas.Location = new System.Drawing.Point(251, 328);
            this.btnCargarAreas.Name = "btnCargarAreas";
            this.btnCargarAreas.Size = new System.Drawing.Size(171, 40);
            this.btnCargarAreas.TabIndex = 18;
            this.btnCargarAreas.Text = "Cargar Areas";
            this.btnCargarAreas.UseVisualStyleBackColor = false;
            this.btnCargarAreas.Click += new System.EventHandler(this.btnCargarAreas_Click);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(797, 380);
            this.Controls.Add(this.btnCargarAreas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignarTrabajador);
            this.Controls.Add(this.btnModificarUI);
            this.Controls.Add(this.dgvAreas);
            this.Controls.Add(this.btnUInternas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArea";
            this.Text = "frmArea";
            this.Load += new System.EventHandler(this.frmArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAsignarTrabajador;
        private System.Windows.Forms.Button btnModificarUI;
        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.Button btnUInternas;
        private System.Windows.Forms.Button btnCargarAreas;
    }
}