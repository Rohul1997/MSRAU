namespace MSR_Amiibo_Unlocker
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.Open_button = new System.Windows.Forms.Button();
            this.Reserve_tank_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Rohul1997";
            // 
            // Open_button
            // 
            this.Open_button.Location = new System.Drawing.Point(12, 12);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(42, 23);
            this.Open_button.TabIndex = 1;
            this.Open_button.Text = "Open";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // Reserve_tank_button
            // 
            this.Reserve_tank_button.Enabled = false;
            this.Reserve_tank_button.Location = new System.Drawing.Point(60, 12);
            this.Reserve_tank_button.Name = "Reserve_tank_button";
            this.Reserve_tank_button.Size = new System.Drawing.Size(148, 23);
            this.Reserve_tank_button.TabIndex = 2;
            this.Reserve_tank_button.Text = "Unlock All 3 Reserve Tanks";
            this.Reserve_tank_button.UseVisualStyleBackColor = true;
            this.Reserve_tank_button.Click += new System.EventHandler(this.Reserve_tank_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 45);
            this.Controls.Add(this.Reserve_tank_button);
            this.Controls.Add(this.Open_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "MSR Amiibo Unlocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.Button Reserve_tank_button;
    }
}

