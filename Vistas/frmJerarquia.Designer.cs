namespace ProyectoOra
{
    partial class frmJerarquia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJerarquia));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStarea = new System.Windows.Forms.Button();
            this.btnEliminarJerarquia = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvJerarquia = new System.Windows.Forms.DataGridView();
            this.btnAtareas = new System.Windows.Forms.Button();
            this.btnCargaJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJerarquia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(169, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Interfaz de Jerarquia";
            // 
            // btnStarea
            // 
            this.btnStarea.BackColor = System.Drawing.SystemColors.Control;
            this.btnStarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStarea.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarea.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStarea.Location = new System.Drawing.Point(630, 307);
            this.btnStarea.Name = "btnStarea";
            this.btnStarea.Size = new System.Drawing.Size(209, 47);
            this.btnStarea.TabIndex = 16;
            this.btnStarea.Text = "Salir";
            this.btnStarea.UseVisualStyleBackColor = false;
            this.btnStarea.Click += new System.EventHandler(this.btnStarea_Click);
            // 
            // btnEliminarJerarquia
            // 
            this.btnEliminarJerarquia.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarJerarquia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarJerarquia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarJerarquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJerarquia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarJerarquia.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminarJerarquia.Location = new System.Drawing.Point(630, 207);
            this.btnEliminarJerarquia.Name = "btnEliminarJerarquia";
            this.btnEliminarJerarquia.Size = new System.Drawing.Size(209, 46);
            this.btnEliminarJerarquia.TabIndex = 15;
            this.btnEliminarJerarquia.Text = "Eliminar";
            this.btnEliminarJerarquia.UseVisualStyleBackColor = false;
            this.btnEliminarJerarquia.Click += new System.EventHandler(this.btnEliminarJerarquia_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Location = new System.Drawing.Point(630, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(209, 45);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvJerarquia
            // 
            this.dgvJerarquia.AllowUserToAddRows = false;
            this.dgvJerarquia.AllowUserToDeleteRows = false;
            this.dgvJerarquia.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvJerarquia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJerarquia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJerarquia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJerarquia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJerarquia.EnableHeadersVisualStyles = false;
            this.dgvJerarquia.GridColor = System.Drawing.SystemColors.Control;
            this.dgvJerarquia.Location = new System.Drawing.Point(12, 103);
            this.dgvJerarquia.Name = "dgvJerarquia";
            this.dgvJerarquia.ReadOnly = true;
            this.dgvJerarquia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJerarquia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJerarquia.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgvJerarquia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJerarquia.Size = new System.Drawing.Size(573, 251);
            this.dgvJerarquia.TabIndex = 13;
            this.dgvJerarquia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJerarquia_CellContentClick);
            // 
            // btnAtareas
            // 
            this.btnAtareas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtareas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtareas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtareas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAtareas.Location = new System.Drawing.Point(630, 103);
            this.btnAtareas.Name = "btnAtareas";
            this.btnAtareas.Size = new System.Drawing.Size(209, 47);
            this.btnAtareas.TabIndex = 12;
            this.btnAtareas.Text = "Añadir Jerarquia";
            this.btnAtareas.UseVisualStyleBackColor = false;
            this.btnAtareas.Click += new System.EventHandler(this.btnAtareas_Click);
            // 
            // btnCargaJ
            // 
            this.btnCargaJ.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargaJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaJ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCargaJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaJ.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargaJ.Location = new System.Drawing.Point(242, 360);
            this.btnCargaJ.Name = "btnCargaJ";
            this.btnCargaJ.Size = new System.Drawing.Size(209, 46);
            this.btnCargaJ.TabIndex = 18;
            this.btnCargaJ.Text = "Cargar Jerarquias";
            this.btnCargaJ.UseVisualStyleBackColor = false;
            this.btnCargaJ.Click += new System.EventHandler(this.btnCargaJ_Click);
            // 
            // frmJerarquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(881, 418);
            this.Controls.Add(this.btnCargaJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStarea);
            this.Controls.Add(this.btnEliminarJerarquia);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvJerarquia);
            this.Controls.Add(this.btnAtareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJerarquia";
            this.Text = "frmJerarquia";
            this.Load += new System.EventHandler(this.frmJerarquia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJerarquia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStarea;
        private System.Windows.Forms.Button btnEliminarJerarquia;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvJerarquia;
        private System.Windows.Forms.Button btnAtareas;
        private System.Windows.Forms.Button btnCargaJ;
    }
}