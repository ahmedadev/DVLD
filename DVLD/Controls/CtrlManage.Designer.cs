namespace DVLD
{
    partial class CtrlManage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlManage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cxtManageTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.SendCall = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvManageTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cxtManageTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.Brown;
            this.lblTitle.Location = new System.Drawing.Point(145, 138);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Table";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cxtManageTable
            // 
            this.cxtManageTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails,
            this.toolStripSeparator1,
            this.AddNew,
            this.Edit,
            this.Delete,
            this.toolStripSeparator2,
            this.SendEmail,
            this.SendCall});
            this.cxtManageTable.Name = "cxtManageTable";
            this.cxtManageTable.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cxtManageTable.Size = new System.Drawing.Size(142, 148);
            // 
            // ShowDetails
            // 
            this.ShowDetails.Image = ((System.Drawing.Image)(resources.GetObject("ShowDetails.Image")));
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(152, 22);
            this.ShowDetails.Text = "Show Details";
            this.ShowDetails.Click += new System.EventHandler(this.ShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // AddNew
            // 
            this.AddNew.Image = ((System.Drawing.Image)(resources.GetObject("AddNew.Image")));
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(152, 22);
            this.AddNew.Text = "Add New";
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Edit
            // 
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(152, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(152, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // SendEmail
            // 
            this.SendEmail.Image = ((System.Drawing.Image)(resources.GetObject("SendEmail.Image")));
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(152, 22);
            this.SendEmail.Text = "Send Email";
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // SendCall
            // 
            this.SendCall.Image = ((System.Drawing.Image)(resources.GetObject("SendCall.Image")));
            this.SendCall.Name = "SendCall";
            this.SendCall.Size = new System.Drawing.Size(152, 22);
            this.SendCall.Text = "Send Call";
            this.SendCall.Click += new System.EventHandler(this.SendCall_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.dgvManageTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 295);
            this.panel1.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.Location = new System.Drawing.Point(503, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(49, 41);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvManageTable
            // 
            this.dgvManageTable.AllowUserToAddRows = false;
            this.dgvManageTable.AllowUserToDeleteRows = false;
            this.dgvManageTable.AllowUserToOrderColumns = true;
            this.dgvManageTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvManageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTable.Location = new System.Drawing.Point(0, 54);
            this.dgvManageTable.Name = "dgvManageTable";
            this.dgvManageTable.ReadOnly = true;
            this.dgvManageTable.Size = new System.Drawing.Size(579, 238);
            this.dgvManageTable.TabIndex = 7;
            this.dgvManageTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvManageTable_MouseClick);
            // 
            // CtrlManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "CtrlManage";
            this.Size = new System.Drawing.Size(582, 465);
            this.Load += new System.EventHandler(this.CtrlManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cxtManageTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip cxtManageTable;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AddNew;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SendEmail;
        private System.Windows.Forms.ToolStripMenuItem SendCall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvManageTable;
    }
}
