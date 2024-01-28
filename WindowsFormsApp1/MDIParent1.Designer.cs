
namespace WindowsFormsApp1
{
    partial class MDIParent1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeOtherDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOfficeSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOfficeSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordsToolStripMenuItem,
            this.addEmployeeOtherDetailsToolStripMenuItem,
            this.addOfficeSuppliesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addRecordsToolStripMenuItem
            // 
            this.addRecordsToolStripMenuItem.Name = "addRecordsToolStripMenuItem";
            this.addRecordsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addRecordsToolStripMenuItem.Text = "Add Records";
            this.addRecordsToolStripMenuItem.Click += new System.EventHandler(this.addRecordsToolStripMenuItem_Click);
            // 
            // addEmployeeOtherDetailsToolStripMenuItem
            // 
            this.addEmployeeOtherDetailsToolStripMenuItem.Name = "addEmployeeOtherDetailsToolStripMenuItem";
            this.addEmployeeOtherDetailsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addEmployeeOtherDetailsToolStripMenuItem.Text = "Add Employee Other Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchEmployeeToolStripMenuItem,
            this.searchOfficeSuppliesToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // searchEmployeeToolStripMenuItem
            // 
            this.searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            this.searchEmployeeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.searchEmployeeToolStripMenuItem.Text = "Search Employee";
            // 
            // addOfficeSuppliesToolStripMenuItem
            // 
            this.addOfficeSuppliesToolStripMenuItem.Name = "addOfficeSuppliesToolStripMenuItem";
            this.addOfficeSuppliesToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addOfficeSuppliesToolStripMenuItem.Text = "Add Office Supplies";
            // 
            // searchOfficeSuppliesToolStripMenuItem
            // 
            this.searchOfficeSuppliesToolStripMenuItem.Name = "searchOfficeSuppliesToolStripMenuItem";
            this.searchOfficeSuppliesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.searchOfficeSuppliesToolStripMenuItem.Text = "Search Office Supplies";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeOtherDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOfficeSuppliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOfficeSuppliesToolStripMenuItem;
    }
}



