namespace ProyectoOra
{
    partial class CrearUnidadesInternas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUnidadesInternas));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnGuardarUI = new System.Windows.Forms.Button();
            this.txtDesUI = new System.Windows.Forms.TextBox();
            this.txtNombreUI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(484, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 17);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardarUI
            // 
            this.btnGuardarUI.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarUI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardarUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUI.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarUI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUI.Location = new System.Drawing.Point(215, 381);
            this.btnGuardarUI.Name = "btnGuardarUI";
            this.btnGuardarUI.Size = new System.Drawing.Size(155, 36);
            this.btnGuardarUI.TabIndex = 46;
            this.btnGuardarUI.Text = "Guardar";
            this.btnGuardarUI.UseVisualStyleBackColor = false;
            this.btnGuardarUI.Click += new System.EventHandler(this.btnGuardarUI_Click);
            // 
            // txtDesUI
            // 
            this.txtDesUI.Location = new System.Drawing.Point(254, 239);
            this.txtDesUI.Multiline = true;
            this.txtDesUI.Name = "txtDesUI";
            this.txtDesUI.Size = new System.Drawing.Size(173, 102);
            this.txtDesUI.TabIndex = 45;
            this.txtDesUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesUI_KeyPress);
            // 
            // txtNombreUI
            // 
            this.txtNombreUI.Location = new System.Drawing.Point(254, 187);
            this.txtNombreUI.Name = "txtNombreUI";
            this.txtNombreUI.Size = new System.Drawing.Size(173, 20);
            this.txtNombreUI.TabIndex = 44;
            this.txtNombreUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUI_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(93, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(93, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre Unidad";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(130, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 35);
            this.label8.TabIndex = 41;
            this.label8.Text = "Crear Unidades Internas";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ProyectoOra.Properties.Resources.logochico2;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // CrearUnidadesInternas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarUI);
            this.Controls.Add(this.txtDesUI);
            this.Controls.Add(this.txtNombreUI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearUnidadesInternas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUnidadesInternas";
            this.Load += new System.EventHandler(this.CrearUnidadesInternas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CrearUnidadesInternas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnGuardarUI;
        private System.Windows.Forms.TextBox txtDesUI;
        private System.Windows.Forms.TextBox txtNombreUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}