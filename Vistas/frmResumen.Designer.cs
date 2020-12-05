namespace ProyectoOra
{
    partial class frmResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumen));
            this.dgvMostrarTareas = new System.Windows.Forms.DataGridView();
            this.btncargarResumen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarTareas
            // 
            this.dgvMostrarTareas.AllowUserToAddRows = false;
            this.dgvMostrarTareas.AllowUserToDeleteRows = false;
            this.dgvMostrarTareas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMostrarTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarTareas.EnableHeadersVisualStyles = false;
            this.dgvMostrarTareas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMostrarTareas.Location = new System.Drawing.Point(58, 109);
            this.dgvMostrarTareas.Name = "dgvMostrarTareas";
            this.dgvMostrarTareas.ReadOnly = true;
            this.dgvMostrarTareas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarTareas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarTareas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dgvMostrarTareas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarTareas.Size = new System.Drawing.Size(679, 210);
            this.dgvMostrarTareas.TabIndex = 14;
            this.dgvMostrarTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrearTareas_CellContentClick);
            // 
            // btncargarResumen
            // 
            this.btncargarResumen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncargarResumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncargarResumen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncargarResumen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btncargarResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btncargarResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargarResumen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarResumen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btncargarResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncargarResumen.Location = new System.Drawing.Point(58, 343);
            this.btncargarResumen.Name = "btncargarResumen";
            this.btncargarResumen.Size = new System.Drawing.Size(200, 52);
            this.btncargarResumen.TabIndex = 15;
            this.btncargarResumen.Text = "Cargar Resumen";
            this.btncargarResumen.UseVisualStyleBackColor = false;
            this.btncargarResumen.Click += new System.EventHandler(this.btncargarResumen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(294, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Interfaz de Resumen";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(537, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 52);
            this.button1.TabIndex = 20;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncargarResumen);
            this.Controls.Add(this.dgvMostrarTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResumen";
            this.Text = "frmResumen";
            this.Load += new System.EventHandler(this.frmResumen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarTareas;
        private System.Windows.Forms.Button btncargarResumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}