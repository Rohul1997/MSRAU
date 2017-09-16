namespace MSRAU
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
            this.Save_button = new System.Windows.Forms.Button();
            this.Reserve_tanks_checkBox = new System.Windows.Forms.CheckBox();
            this.Normal_radioButton = new System.Windows.Forms.RadioButton();
            this.Hard_radioButton = new System.Windows.Forms.RadioButton();
            this.Fusion_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "By Rohul1997";
            // 
            // Open_button
            // 
            this.Open_button.Location = new System.Drawing.Point(89, 13);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(135, 23);
            this.Open_button.TabIndex = 1;
            this.Open_button.Text = "Open pkprfl.bmssv file";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Enabled = false;
            this.Save_button.Location = new System.Drawing.Point(230, 13);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(55, 23);
            this.Save_button.TabIndex = 2;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Reserve_tanks_checkBox
            // 
            this.Reserve_tanks_checkBox.AutoSize = true;
            this.Reserve_tanks_checkBox.Enabled = false;
            this.Reserve_tanks_checkBox.Location = new System.Drawing.Point(12, 65);
            this.Reserve_tanks_checkBox.Name = "Reserve_tanks_checkBox";
            this.Reserve_tanks_checkBox.Size = new System.Drawing.Size(260, 17);
            this.Reserve_tanks_checkBox.TabIndex = 3;
            this.Reserve_tanks_checkBox.Text = "Unlock Energy, Aeion and Missile Reserve Tanks";
            this.Reserve_tanks_checkBox.UseVisualStyleBackColor = true;
            // 
            // Normal_radioButton
            // 
            this.Normal_radioButton.AutoSize = true;
            this.Normal_radioButton.Enabled = false;
            this.Normal_radioButton.Location = new System.Drawing.Point(50, 42);
            this.Normal_radioButton.Name = "Normal_radioButton";
            this.Normal_radioButton.Size = new System.Drawing.Size(58, 17);
            this.Normal_radioButton.TabIndex = 4;
            this.Normal_radioButton.Text = "Normal";
            this.Normal_radioButton.UseVisualStyleBackColor = true;
            // 
            // Hard_radioButton
            // 
            this.Hard_radioButton.AutoSize = true;
            this.Hard_radioButton.Enabled = false;
            this.Hard_radioButton.Location = new System.Drawing.Point(114, 42);
            this.Hard_radioButton.Name = "Hard_radioButton";
            this.Hard_radioButton.Size = new System.Drawing.Size(48, 17);
            this.Hard_radioButton.TabIndex = 4;
            this.Hard_radioButton.Text = "Hard";
            this.Hard_radioButton.UseVisualStyleBackColor = true;
            // 
            // Fusion_radioButton
            // 
            this.Fusion_radioButton.AutoSize = true;
            this.Fusion_radioButton.Enabled = false;
            this.Fusion_radioButton.Location = new System.Drawing.Point(168, 42);
            this.Fusion_radioButton.Name = "Fusion_radioButton";
            this.Fusion_radioButton.Size = new System.Drawing.Size(120, 17);
            this.Fusion_radioButton.TabIndex = 4;
            this.Fusion_radioButton.Text = "Fusion + Fusion Suit";
            this.Fusion_radioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mode:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fusion_radioButton);
            this.Controls.Add(this.Hard_radioButton);
            this.Controls.Add(this.Normal_radioButton);
            this.Controls.Add(this.Reserve_tanks_checkBox);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Open_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "MSRAU v1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.CheckBox Reserve_tanks_checkBox;
        private System.Windows.Forms.RadioButton Normal_radioButton;
        private System.Windows.Forms.RadioButton Hard_radioButton;
        private System.Windows.Forms.RadioButton Fusion_radioButton;
        private System.Windows.Forms.Label label2;
    }
}

