namespace OrdenServicio
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconMin = new FontAwesome.Sharp.IconPictureBox();
            this.IconMax = new FontAwesome.Sharp.IconPictureBox();
            this.IconClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelBottom.SuspendLayout();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.textBox2);
            this.PanelBottom.Controls.Add(this.textBox1);
            this.PanelBottom.Controls.Add(this.lblDescripcion);
            this.PanelBottom.Controls.Add(this.lblId);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 263);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(634, 188);
            this.PanelBottom.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(333, 92);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(95, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcción:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.IconMin);
            this.PanelTop.Controls.Add(this.IconMax);
            this.PanelTop.Controls.Add(this.IconClose);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(634, 37);
            this.PanelTop.TabIndex = 4;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de órdenes de servicio";
            // 
            // IconMin
            // 
            this.IconMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.IconMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMin.ForeColor = System.Drawing.Color.LightGray;
            this.IconMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.IconMin.IconColor = System.Drawing.Color.LightGray;
            this.IconMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMin.IconSize = 21;
            this.IconMin.Location = new System.Drawing.Point(550, 3);
            this.IconMin.Name = "IconMin";
            this.IconMin.Size = new System.Drawing.Size(23, 21);
            this.IconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMin.TabIndex = 2;
            this.IconMin.TabStop = false;
            this.IconMin.Click += new System.EventHandler(this.IconMin_Click);
            // 
            // IconMax
            // 
            this.IconMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.IconMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMax.ForeColor = System.Drawing.Color.LightGray;
            this.IconMax.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.IconMax.IconColor = System.Drawing.Color.LightGray;
            this.IconMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconMax.IconSize = 21;
            this.IconMax.Location = new System.Drawing.Point(579, 3);
            this.IconMax.Name = "IconMax";
            this.IconMax.Size = new System.Drawing.Size(23, 21);
            this.IconMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMax.TabIndex = 1;
            this.IconMax.TabStop = false;
            this.IconMax.Click += new System.EventHandler(this.IconMax_Click);
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
            this.IconClose.Location = new System.Drawing.Point(608, 3);
            this.IconClose.Name = "IconClose";
            this.IconClose.Size = new System.Drawing.Size(23, 21);
            this.IconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconClose.TabIndex = 0;
            this.IconClose.TabStop = false;
            this.IconClose.Click += new System.EventHandler(this.IconClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.LightGray;
            this.btnNew.Location = new System.Drawing.Point(3, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nueva órden";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Location = new System.Drawing.Point(3, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar órden";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightGray;
            this.btnDelete.Location = new System.Drawing.Point(3, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar órden";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(80)))), ((int)(((byte)(115)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.LightGray;
            this.btnSend.Location = new System.Drawing.Point(3, 163);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(122, 44);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Enviar órdenes emitidas";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.GridColor = System.Drawing.Color.Black;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(503, 226);
            this.dgvOrders.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(503, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 226);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 226);
            this.panel1.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.PanelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de órdenes de servicio";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.DataGridView dgvOrders;
        private FontAwesome.Sharp.IconPictureBox IconMin;
        private FontAwesome.Sharp.IconPictureBox IconMax;
        private FontAwesome.Sharp.IconPictureBox IconClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

