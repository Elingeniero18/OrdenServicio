namespace OrdenServicio
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.IconClose = new FontAwesome.Sharp.IconPictureBox();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.FechaPicker = new System.Windows.Forms.DateTimePicker();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).BeginInit();
            this.PanelCenter.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(25, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 17);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(284, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(23, 123);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(150, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción de órden:";
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(82, 31);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(181, 20);
            this.txtNomCliente.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(26, 139);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(402, 81);
            this.txtDesc.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(337, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(162)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.LightGray;
            this.btnCreate.Location = new System.Drawing.Point(240, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 31);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.PanelTop.Controls.Add(this.lblTitulo);
            this.PanelTop.Controls.Add(this.IconClose);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(452, 37);
            this.PanelTop.TabIndex = 8;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 23);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Nueva órden de servicio";
            // 
            // IconClose
            // 
            this.IconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.IconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconClose.ForeColor = System.Drawing.Color.LightGray;
            this.IconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IconClose.IconColor = System.Drawing.Color.LightGray;
            this.IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconClose.IconSize = 21;
            this.IconClose.Location = new System.Drawing.Point(427, 3);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(23, 21);
            this.IconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconClose.TabIndex = 4;
            this.IconClose.TabStop = false;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.FechaPicker);
            this.PanelCenter.Controls.Add(this.txtDesc);
            this.PanelCenter.Controls.Add(this.lblDesc);
            this.PanelCenter.Controls.Add(this.lblCliente);
            this.PanelCenter.Controls.Add(this.lblFecha);
            this.PanelCenter.Controls.Add(this.txtNomCliente);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 37);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(452, 284);
            this.PanelCenter.TabIndex = 9;
            // 
            // FechaPicker
            // 
            this.FechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaPicker.Location = new System.Drawing.Point(337, 31);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(91, 20);
            this.FechaPicker.TabIndex = 5;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.btnCancel);
            this.PanelBottom.Controls.Add(this.btnCreate);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 263);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(452, 58);
            this.PanelBottom.TabIndex = 10;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 321);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva órden de servicio";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).EndInit();
            this.PanelCenter.ResumeLayout(false);
            this.PanelCenter.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox IconClose;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.DateTimePicker FechaPicker;
    }
}