namespace ProyectoOra
{
    partial class ModificarArea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarArea));
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbNomArea = new System.Windows.Forms.ComboBox();
            this.btnModificarAreas = new System.Windows.Forms.Button();
            this.lbl123 = new System.Windows.Forms.Label();
            this.txtNombreArea = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(246, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 35);
            this.label8.TabIndex = 36;
            this.label8.Text = "Modificar Areas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(540, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 17);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(148, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre de Area";
            // 
            // CbNomArea
            // 
            this.CbNomArea.FormattingEnabled = true;
            this.CbNomArea.Location = new System.Drawing.Point(273, 165);
            this.CbNomArea.Name = "CbNomArea";
            this.CbNomArea.Size = new System.Drawing.Size(153, 21);
            this.CbNomArea.TabIndex = 39;
            this.CbNomArea.SelectedIndexChanged += new System.EventHandler(this.CbNomArea_SelectedIndexChanged);
            this.CbNomArea.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // btnModificarAreas
            // 
            this.btnModificarAreas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificarAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAreas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarAreas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnModificarAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAreas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAreas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificarAreas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAreas.Location = new System.Drawing.Point(271, 309);
            this.btnModificarAreas.Name = "btnModificarAreas";
            this.btnModificarAreas.Size = new System.Drawing.Size(155, 36);
            this.btnModificarAreas.TabIndex = 50;
            this.btnModificarAreas.Text = "Modificar Area";
            this.btnModificarAreas.UseVisualStyleBackColor = false;
            this.btnModificarAreas.Click += new System.EventHandler(this.btnModificarAreas_Click);
            // 
            // lbl123
            // 
            this.lbl123.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl123.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl123.Location = new System.Drawing.Point(201, 242);
            this.lbl123.Name = "lbl123";
            this.lbl123.Size = new System.Drawing.Size(66, 20);
            this.lbl123.TabIndex = 52;
            this.lbl123.Text = "Nombre:";
            // 
            // txtNombreArea
            // 
            this.txtNombreArea.Location = new System.Drawing.Point(273, 241);
            this.txtNombreArea.Name = "txtNombreArea";
            this.txtNombreArea.Size = new System.Drawing.Size(153, 20);
            this.txtNombreArea.TabIndex = 53;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ProyectoOra.Properties.Resources.logochico2;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // ModificarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreArea);
            this.Controls.Add(this.lbl123);
            this.Controls.Add(this.btnModificarAreas);
            this.Controls.Add(this.CbNomArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarArea";
            this.Load += new System.EventHandler(this.ModificarArea_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarArea_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbNomArea;
        private System.Windows.Forms.Button btnModificarAreas;
        private System.Windows.Forms.Label lbl123;
        private System.Windows.Forms.TextBox txtNombreArea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}