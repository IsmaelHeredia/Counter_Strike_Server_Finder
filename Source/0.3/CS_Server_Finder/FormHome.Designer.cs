namespace CS_Server_Finder
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.gbEnterSearch = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbServersFound = new System.Windows.Forms.GroupBox();
            this.lbServersFound = new System.Windows.Forms.ListBox();
            this.lvServersFound = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyIPToClipBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.gbEnterSearch.SuspendLayout();
            this.gbServersFound.SuspendLayout();
            this.cmsOptions.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEnterSearch
            // 
            this.gbEnterSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbEnterSearch.Controls.Add(this.cmbType);
            this.gbEnterSearch.Controls.Add(this.btnSearch);
            this.gbEnterSearch.Controls.Add(this.txtSearch);
            this.gbEnterSearch.ForeColor = System.Drawing.Color.Lime;
            this.gbEnterSearch.Location = new System.Drawing.Point(18, 129);
            this.gbEnterSearch.Name = "gbEnterSearch";
            this.gbEnterSearch.Size = new System.Drawing.Size(483, 65);
            this.gbEnterSearch.TabIndex = 0;
            this.gbEnterSearch.TabStop = false;
            this.gbEnterSearch.Text = "Enter Search";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Search By Name",
            "Search By Current Map"});
            this.cmbType.Location = new System.Drawing.Point(209, 28);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(151, 21);
            this.cmbType.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(366, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.ForeColor = System.Drawing.Color.Lime;
            this.txtSearch.Location = new System.Drawing.Point(20, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // gbServersFound
            // 
            this.gbServersFound.BackColor = System.Drawing.Color.Transparent;
            this.gbServersFound.Controls.Add(this.lbServersFound);
            this.gbServersFound.Controls.Add(this.lvServersFound);
            this.gbServersFound.ForeColor = System.Drawing.Color.Lime;
            this.gbServersFound.Location = new System.Drawing.Point(18, 200);
            this.gbServersFound.Name = "gbServersFound";
            this.gbServersFound.Size = new System.Drawing.Size(483, 167);
            this.gbServersFound.TabIndex = 1;
            this.gbServersFound.TabStop = false;
            this.gbServersFound.Text = "Servers Found";
            // 
            // lbServersFound
            // 
            this.lbServersFound.FormattingEnabled = true;
            this.lbServersFound.Location = new System.Drawing.Point(266, 56);
            this.lbServersFound.Name = "lbServersFound";
            this.lbServersFound.Size = new System.Drawing.Size(120, 95);
            this.lbServersFound.TabIndex = 3;
            this.lbServersFound.Visible = false;
            // 
            // lvServersFound
            // 
            this.lvServersFound.BackColor = System.Drawing.Color.Black;
            this.lvServersFound.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvServersFound.ContextMenuStrip = this.cmsOptions;
            this.lvServersFound.ForeColor = System.Drawing.Color.Lime;
            this.lvServersFound.FullRowSelect = true;
            this.lvServersFound.Location = new System.Drawing.Point(20, 28);
            this.lvServersFound.Name = "lvServersFound";
            this.lvServersFound.Size = new System.Drawing.Size(449, 123);
            this.lvServersFound.TabIndex = 0;
            this.lvServersFound.UseCompatibleStateImageBehavior = false;
            this.lvServersFound.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Server Name";
            this.columnHeader1.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Players";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Server Map";
            this.columnHeader3.Width = 131;
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyIPToClipBoardToolStripMenuItem});
            this.cmsOptions.Name = "contextMenuStrip1";
            this.cmsOptions.Size = new System.Drawing.Size(210, 26);
            // 
            // copyIPToClipBoardToolStripMenuItem
            // 
            this.copyIPToClipBoardToolStripMenuItem.Name = "copyIPToClipBoardToolStripMenuItem";
            this.copyIPToClipBoardToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.copyIPToClipBoardToolStripMenuItem.Text = "Copy IP:Port to ClipBoard";
            this.copyIPToClipBoardToolStripMenuItem.Click += new System.EventHandler(this.copyIPToClipBoardToolStripMenuItem_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.Color.Black;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.ssStatus.Location = new System.Drawing.Point(0, 428);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(514, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Lime;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // pcLogo
            // 
            this.pcLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogo.Image")));
            this.pcLogo.Location = new System.Drawing.Point(12, 12);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(489, 97);
            this.pcLogo.TabIndex = 3;
            this.pcLogo.TabStop = false;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.Lime;
            this.lblCopyRight.Location = new System.Drawing.Point(92, 385);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(327, 29);
            this.lblCopyRight.TabIndex = 4;
            this.lblCopyRight.Text = "Powered By GameTracker ";
            this.lblCopyRight.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.pcLogo);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gbServersFound);
            this.Controls.Add(this.gbEnterSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Counter Strike Server Finder 0.3 - © Ismael Heredia , Argentina , 2014 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.gbEnterSearch.ResumeLayout(false);
            this.gbEnterSearch.PerformLayout();
            this.gbServersFound.ResumeLayout(false);
            this.cmsOptions.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEnterSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbServersFound;
        private System.Windows.Forms.ListView lvServersFound;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox lbServersFound;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem copyIPToClipBoardToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcLogo;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.ComboBox cmbType;
    }
}

