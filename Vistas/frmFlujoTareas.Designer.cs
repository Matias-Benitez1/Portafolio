namespace ProyectoOra
{
    partial class frmFlujoTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlujoTareas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStarea = new System.Windows.Forms.Button();
            this.btnEtareas = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvCrearTareas = new System.Windows.Forms.DataGridView();
            this.btnAtareas = new System.Windows.Forms.Button();
            this.btnCargaFT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(190, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Interfaz de Flujo de Tareas";
            // 
            // btnStarea
            // 
            this.btnStarea.BackColor = System.Drawing.SystemColors.Control;
            this.btnStarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStarea.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStarea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarea.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStarea.Location = new System.Drawing.Point(642, 330);
            this.btnStarea.Name = "btnStarea";
            this.btnStarea.Size = new System.Drawing.Size(209, 41);
            this.btnStarea.TabIndex = 10;
            this.btnStarea.Text = "Salir";
            this.btnStarea.UseVisualStyleBackColor = false;
            this.btnStarea.Click += new System.EventHandler(this.btnStarea_Click);
            // 
            // btnEtareas
            // 
            this.btnEtareas.BackColor = System.Drawing.SystemColors.Control;
            this.btnEtareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtareas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEtareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtareas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtareas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEtareas.Location = new System.Drawing.Point(642, 226);
            this.btnEtareas.Name = "btnEtareas";
            this.btnEtareas.Size = new System.Drawing.Size(209, 42);
            this.btnEtareas.TabIndex = 9;
            this.btnEtareas.Text = "Eliminar";
            this.btnEtareas.UseVisualStyleBackColor = false;
            this.btnEtareas.Click += new System.EventHandler(this.btnEtareas_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Location = new System.Drawing.Point(642, 174);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(209, 46);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvCrearTareas
            // 
            this.dgvCrearTareas.AllowUserToAddRows = false;
            this.dgvCrearTareas.AllowUserToDeleteRows = false;
            this.dgvCrearTareas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCrearTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCrearTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrearTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCrearTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrearTareas.EnableHeadersVisualStyles = false;
            this.dgvCrearTareas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCrearTareas.Location = new System.Drawing.Point(28, 126);
            this.dgvCrearTareas.Name = "dgvCrearTareas";
            this.dgvCrearTareas.ReadOnly = true;
            this.dgvCrearTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrearTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCrearTareas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgvCrearTareas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCrearTareas.Size = new System.Drawing.Size(597, 245);
            this.dgvCrearTareas.TabIndex = 7;
            // 
            // btnAtareas
            // 
            this.btnAtareas.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtareas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtareas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtareas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAtareas.Location = new System.Drawing.Point(642, 126);
            this.btnAtareas.Name = "btnAtareas";
            this.btnAtareas.Size = new System.Drawing.Size(209, 42);
            this.btnAtareas.TabIndex = 6;
            this.btnAtareas.Text = "Añadir Flujo de Tareas";
            this.btnAtareas.UseVisualStyleBackColor = false;
            this.btnAtareas.Click += new System.EventHandler(this.btnAtareas_Click);
            // 
            // btnCargaFT
            // 
            this.btnCargaFT.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargaFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargaFT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCargaFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaFT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaFT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargaFT.Location = new System.Drawing.Point(244, 377);
            this.btnCargaFT.Name = "btnCargaFT";
            this.btnCargaFT.Size = new System.Drawing.Size(209, 46);
            this.btnCargaFT.TabIndex = 12;
            this.btnCargaFT.Text = "Cargar Flujos de Tareas";
            this.btnCargaFT.UseVisualStyleBackColor = false;
            this.btnCargaFT.Click += new System.EventHandler(this.btnCargaFT_Click);
            // 
            // frmFlujoTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(881, 435);
            this.Controls.Add(this.btnCargaFT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStarea);
            this.Controls.Add(this.btnEtareas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvCrearTareas);
            this.Controls.Add(this.btnAtareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFlujoTareas";
            this.Text = "frmFlujoTareas";
            this.Load += new System.EventHandler(this.frmFlujoTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrearTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStarea;
        private System.Windows.Forms.Button btnEtareas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvCrearTareas;
        private System.Windows.Forms.Button btnAtareas;
        private System.Windows.Forms.Button btnCargaFT;
    }
}