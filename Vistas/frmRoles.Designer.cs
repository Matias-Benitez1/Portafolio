namespace ProyectoOra
{
    partial class frmRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.btnAtareas = new System.Windows.Forms.Button();
            this.dgvInterRoles = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEtareas = new System.Windows.Forms.Button();
            this.btnStarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtareas
            // 
            this.btnAtareas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtareas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtareas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtareas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAtareas.Location = new System.Drawing.Point(617, 59);
            this.btnAtareas.Name = "btnAtareas";
            this.btnAtareas.Size = new System.Drawing.Size(154, 35);
            this.btnAtareas.TabIndex = 0;
            this.btnAtareas.Text = "Añadir Roles";
            this.btnAtareas.UseVisualStyleBackColor = false;
            this.btnAtareas.Click += new System.EventHandler(this.btnAtareas_Click);
            // 
            // dgvInterRoles
            // 
            this.dgvInterRoles.AllowUserToAddRows = false;
            this.dgvInterRoles.AllowUserToDeleteRows = false;
            this.dgvInterRoles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInterRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInterRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInterRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInterRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInterRoles.EnableHeadersVisualStyles = false;
            this.dgvInterRoles.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInterRoles.Location = new System.Drawing.Point(26, 59);
            this.dgvInterRoles.Name = "dgvInterRoles";
            this.dgvInterRoles.ReadOnly = true;
            this.dgvInterRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInterRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInterRoles.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgvInterRoles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInterRoles.Size = new System.Drawing.Size(573, 199);
            this.dgvInterRoles.TabIndex = 1;
            this.dgvInterRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrearTareas_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Location = new System.Drawing.Point(617, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(154, 36);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEtareas
            // 
            this.btnEtareas.BackColor = System.Drawing.SystemColors.Control;
            this.btnEtareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtareas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEtareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtareas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtareas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEtareas.Location = new System.Drawing.Point(617, 138);
            this.btnEtareas.Name = "btnEtareas";
            this.btnEtareas.Size = new System.Drawing.Size(154, 39);
            this.btnEtareas.TabIndex = 3;
            this.btnEtareas.Text = "Eliminar";
            this.btnEtareas.UseVisualStyleBackColor = false;
            this.btnEtareas.Click += new System.EventHandler(this.btnEtareas_Click);
            // 
            // btnStarea
            // 
            this.btnStarea.BackColor = System.Drawing.SystemColors.Control;
            this.btnStarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStarea.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarea.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStarea.Location = new System.Drawing.Point(617, 216);
            this.btnStarea.Name = "btnStarea";
            this.btnStarea.Size = new System.Drawing.Size(154, 42);
            this.btnStarea.TabIndex = 4;
            this.btnStarea.Text = "Salir";
            this.btnStarea.UseVisualStyleBackColor = false;
            this.btnStarea.Click += new System.EventHandler(this.btnStarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interfaz de Roles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCargarRol
            // 
            this.btnCargarRol.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargarRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarRol.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCargarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarRol.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarRol.Location = new System.Drawing.Point(263, 264);
            this.btnCargarRol.Name = "btnCargarRol";
            this.btnCargarRol.Size = new System.Drawing.Size(154, 40);
            this.btnCargarRol.TabIndex = 6;
            this.btnCargarRol.Text = "Cargar Roles";
            this.btnCargarRol.UseVisualStyleBackColor = false;
            this.btnCargarRol.Click += new System.EventHandler(this.btnCargarRol_Click);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(817, 327);
            this.ControlBox = false;
            this.Controls.Add(this.btnCargarRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStarea);
            this.Controls.Add(this.btnEtareas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvInterRoles);
            this.Controls.Add(this.btnAtareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoles";
            this.ShowIcon = false;
            this.Text = "CrearTareas";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtareas;
        private System.Windows.Forms.DataGridView dgvInterRoles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEtareas;
        private System.Windows.Forms.Button btnStarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarRol;
    }
}