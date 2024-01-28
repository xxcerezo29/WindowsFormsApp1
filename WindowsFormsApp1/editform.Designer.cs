
namespace WindowsFormsApp1
{
    partial class editform
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
            this.label1 = new System.Windows.Forms.Label();
            this.namefield = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sexfield = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressfield = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(63, 9);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(245, 20);
            this.namefield.TabIndex = 4;
            this.namefield.TextChanged += new System.EventHandler(this.namefield_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sex:";
            // 
            // sexfield
            // 
            this.sexfield.FormattingEnabled = true;
            this.sexfield.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexfield.Location = new System.Drawing.Point(63, 29);
            this.sexfield.Name = "sexfield";
            this.sexfield.Size = new System.Drawing.Size(121, 21);
            this.sexfield.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // addressfield
            // 
            this.addressfield.Location = new System.Drawing.Point(63, 56);
            this.addressfield.Name = "addressfield";
            this.addressfield.Size = new System.Drawing.Size(245, 20);
            this.addressfield.TabIndex = 8;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(402, 9);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(208, 67);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // editform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 98);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addressfield);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namefield);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "editform";
            this.Text = "editform";
            this.Load += new System.EventHandler(this.editform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexfield;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressfield;
        private System.Windows.Forms.Button update;
    }
}