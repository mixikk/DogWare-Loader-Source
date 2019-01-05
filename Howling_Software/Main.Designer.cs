namespace Howling_Software
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.CheatList = new System.Windows.Forms.ListBox();
            this.Launch_button = new System.Windows.Forms.Button();
            this.Adminbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(296, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 13);
            this.panel1.TabIndex = 31;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.ForeColor = System.Drawing.Color.White;
            this.Welcomelbl.Location = new System.Drawing.Point(-3, 436);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(57, 14);
            this.Welcomelbl.TabIndex = 34;
            this.Welcomelbl.Text = "Welcome: ";
            // 
            // CheatList
            // 
            this.CheatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CheatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheatList.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheatList.ForeColor = System.Drawing.Color.White;
            this.CheatList.FormattingEnabled = true;
            this.CheatList.ItemHeight = 14;
            this.CheatList.Location = new System.Drawing.Point(27, 216);
            this.CheatList.Name = "CheatList";
            this.CheatList.Size = new System.Drawing.Size(281, 182);
            this.CheatList.TabIndex = 36;
            this.CheatList.SelectedIndexChanged += new System.EventHandler(this.CheatList_SelectedIndexChanged);
            // 
            // Launch_button
            // 
            this.Launch_button.BackColor = System.Drawing.Color.Transparent;
            this.Launch_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Launch_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Launch_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Launch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Launch_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launch_button.ForeColor = System.Drawing.Color.White;
            this.Launch_button.Location = new System.Drawing.Point(106, 404);
            this.Launch_button.Name = "Launch_button";
            this.Launch_button.Size = new System.Drawing.Size(117, 34);
            this.Launch_button.TabIndex = 37;
            this.Launch_button.UseVisualStyleBackColor = false;
            this.Launch_button.Click += new System.EventHandler(this.lgn_button_Click);
            // 
            // Adminbtn
            // 
            this.Adminbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Adminbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Adminbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Adminbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.ForeColor = System.Drawing.Color.White;
            this.Adminbtn.Location = new System.Drawing.Point(395, 455);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(104, 22);
            this.Adminbtn.TabIndex = 42;
            this.Adminbtn.Text = "Admin Panel";
            this.Adminbtn.UseVisualStyleBackColor = false;
            this.Adminbtn.Visible = false;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "Welcome: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::Howling_Software.Properties.Resources.DogLoader;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.Launch_button);
            this.Controls.Add(this.CheatList);
            this.Controls.Add(this.Welcomelbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.ListBox CheatList;
        private System.Windows.Forms.Button Launch_button;
        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Label label1;
    }
}