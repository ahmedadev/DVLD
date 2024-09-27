using Business;

namespace DVLD.People
{
    partial class ManagePeople
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
            this.ctrlManage1 = new DVLD.CtrlManage();
            this.SuspendLayout();
            // 
            // ctrlManage1
            // 
            this.ctrlManage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlManage1.Location = new System.Drawing.Point(-1, -7);
            this.ctrlManage1.Name = "ctrlManage1";
            this.ctrlManage1.Size = new System.Drawing.Size(706, 499);
            this.ctrlManage1.TabIndex = 0;
            this.ctrlManage1.TableList = null;
            this.ctrlManage1.Title = null;

            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 489);
            this.Controls.Add(this.ctrlManage1);
            this.Name = "ManagePeople";
            this.Text = "Manage People";
            this.ResumeLayout(false);

        }


        #endregion

        private CtrlManage ctrlManage1;
    }
}