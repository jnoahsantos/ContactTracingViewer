
namespace ContactTracingViewer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnViewData = new System.Windows.Forms.Button();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelSearchWarning = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 19;
            this.listBox.Location = new System.Drawing.Point(25, 196);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(523, 175);
            this.listBox.TabIndex = 3;
            // 
            // btnViewData
            // 
            this.btnViewData.BackColor = System.Drawing.Color.DeepPink;
            this.btnViewData.FlatAppearance.BorderSize = 0;
            this.btnViewData.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btnViewData.Location = new System.Drawing.Point(253, 2);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(94, 30);
            this.btnViewData.TabIndex = 4;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = false;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Cooper Black", 25F);
            this.labelTitle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle1.Location = new System.Drawing.Point(27, 21);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(522, 39);
            this.labelTitle1.TabIndex = 5;
            this.labelTitle1.Text = "Contact Tracing Data Viewer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a name:";
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBxSearch.Location = new System.Drawing.Point(25, 135);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(385, 27);
            this.txtBxSearch.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search name:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepPink;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.Location = new System.Drawing.Point(416, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelSearchWarning
            // 
            this.labelSearchWarning.AutoSize = true;
            this.labelSearchWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchWarning.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchWarning.ForeColor = System.Drawing.Color.Maroon;
            this.labelSearchWarning.Location = new System.Drawing.Point(22, 22);
            this.labelSearchWarning.Name = "labelSearchWarning";
            this.labelSearchWarning.Size = new System.Drawing.Size(0, 16);
            this.labelSearchWarning.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTitle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 92);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel2.Controls.Add(this.btnViewData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 37);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(576, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.labelSearchWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSearchWarning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

