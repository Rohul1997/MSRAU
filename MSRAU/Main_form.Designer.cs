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
            this.Normal_radioButton = new System.Windows.Forms.RadioButton();
            this.Hard_radioButton = new System.Windows.Forms.RadioButton();
            this.Fusion_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Completed_save_checkBox = new System.Windows.Forms.CheckBox();
            this.Metroid_art_checkBox = new System.Windows.Forms.CheckBox();
            this.Concept_art_checkBox = new System.Windows.Forms.CheckBox();
            this.Music_checkBox = new System.Windows.Forms.CheckBox();
            this.Energy_tank_checkBox = new System.Windows.Forms.CheckBox();
            this.Aeion_tank_checkBox = new System.Windows.Forms.CheckBox();
            this.Missile_tank_checkBox = new System.Windows.Forms.CheckBox();
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
            // Normal_radioButton
            // 
            this.Normal_radioButton.AutoSize = true;
            this.Normal_radioButton.Enabled = false;
            this.Normal_radioButton.Location = new System.Drawing.Point(50, 42);
            this.Normal_radioButton.Name = "Normal_radioButton";
            this.Normal_radioButton.Size = new System.Drawing.Size(58, 17);
            this.Normal_radioButton.TabIndex = 3;
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
            this.Fusion_radioButton.TabIndex = 5;
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
            // Completed_save_checkBox
            // 
            this.Completed_save_checkBox.AutoSize = true;
            this.Completed_save_checkBox.Enabled = false;
            this.Completed_save_checkBox.Location = new System.Drawing.Point(11, 65);
            this.Completed_save_checkBox.Name = "Completed_save_checkBox";
            this.Completed_save_checkBox.Size = new System.Drawing.Size(266, 17);
            this.Completed_save_checkBox.TabIndex = 6;
            this.Completed_save_checkBox.Text = "Show save as completed on save selection screen";
            this.Completed_save_checkBox.UseVisualStyleBackColor = true;
            // 
            // Metroid_art_checkBox
            // 
            this.Metroid_art_checkBox.AutoSize = true;
            this.Metroid_art_checkBox.Enabled = false;
            this.Metroid_art_checkBox.Location = new System.Drawing.Point(11, 124);
            this.Metroid_art_checkBox.Name = "Metroid_art_checkBox";
            this.Metroid_art_checkBox.Size = new System.Drawing.Size(86, 30);
            this.Metroid_art_checkBox.TabIndex = 10;
            this.Metroid_art_checkBox.Text = "Unlock\r\nMetroid II Art";
            this.Metroid_art_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Metroid_art_checkBox.UseVisualStyleBackColor = true;
            // 
            // Concept_art_checkBox
            // 
            this.Concept_art_checkBox.AutoSize = true;
            this.Concept_art_checkBox.Enabled = false;
            this.Concept_art_checkBox.Location = new System.Drawing.Point(104, 124);
            this.Concept_art_checkBox.Name = "Concept_art_checkBox";
            this.Concept_art_checkBox.Size = new System.Drawing.Size(82, 30);
            this.Concept_art_checkBox.TabIndex = 11;
            this.Concept_art_checkBox.Text = "Unlock\r\nConcept Art";
            this.Concept_art_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Concept_art_checkBox.UseVisualStyleBackColor = true;
            // 
            // Music_checkBox
            // 
            this.Music_checkBox.AutoSize = true;
            this.Music_checkBox.Enabled = false;
            this.Music_checkBox.Location = new System.Drawing.Point(192, 131);
            this.Music_checkBox.Name = "Music_checkBox";
            this.Music_checkBox.Size = new System.Drawing.Size(91, 17);
            this.Music_checkBox.TabIndex = 12;
            this.Music_checkBox.Text = "Unlock Music";
            this.Music_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Music_checkBox.UseVisualStyleBackColor = true;
            // 
            // Energy_tank_checkBox
            // 
            this.Energy_tank_checkBox.AutoSize = true;
            this.Energy_tank_checkBox.Enabled = false;
            this.Energy_tank_checkBox.Location = new System.Drawing.Point(11, 88);
            this.Energy_tank_checkBox.Name = "Energy_tank_checkBox";
            this.Energy_tank_checkBox.Size = new System.Drawing.Size(87, 30);
            this.Energy_tank_checkBox.TabIndex = 7;
            this.Energy_tank_checkBox.Text = "Unlock\r\nEnergy Tank";
            this.Energy_tank_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Energy_tank_checkBox.UseVisualStyleBackColor = true;
            // 
            // Aeion_tank_checkBox
            // 
            this.Aeion_tank_checkBox.AutoSize = true;
            this.Aeion_tank_checkBox.Enabled = false;
            this.Aeion_tank_checkBox.Location = new System.Drawing.Point(104, 88);
            this.Aeion_tank_checkBox.Name = "Aeion_tank_checkBox";
            this.Aeion_tank_checkBox.Size = new System.Drawing.Size(81, 30);
            this.Aeion_tank_checkBox.TabIndex = 8;
            this.Aeion_tank_checkBox.Text = "Unlock\r\nAeion Tank";
            this.Aeion_tank_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aeion_tank_checkBox.UseVisualStyleBackColor = true;
            // 
            // Missile_tank_checkBox
            // 
            this.Missile_tank_checkBox.AutoSize = true;
            this.Missile_tank_checkBox.Enabled = false;
            this.Missile_tank_checkBox.Location = new System.Drawing.Point(192, 88);
            this.Missile_tank_checkBox.Name = "Missile_tank_checkBox";
            this.Missile_tank_checkBox.Size = new System.Drawing.Size(85, 30);
            this.Missile_tank_checkBox.TabIndex = 9;
            this.Missile_tank_checkBox.Text = "Unlock\r\nMissile Tank";
            this.Missile_tank_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Missile_tank_checkBox.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 159);
            this.Controls.Add(this.Missile_tank_checkBox);
            this.Controls.Add(this.Music_checkBox);
            this.Controls.Add(this.Aeion_tank_checkBox);
            this.Controls.Add(this.Concept_art_checkBox);
            this.Controls.Add(this.Energy_tank_checkBox);
            this.Controls.Add(this.Metroid_art_checkBox);
            this.Controls.Add(this.Completed_save_checkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fusion_radioButton);
            this.Controls.Add(this.Hard_radioButton);
            this.Controls.Add(this.Normal_radioButton);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Open_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "MSRAU v1.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.RadioButton Normal_radioButton;
        private System.Windows.Forms.RadioButton Hard_radioButton;
        private System.Windows.Forms.RadioButton Fusion_radioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Completed_save_checkBox;
        private System.Windows.Forms.CheckBox Metroid_art_checkBox;
        private System.Windows.Forms.CheckBox Concept_art_checkBox;
        private System.Windows.Forms.CheckBox Music_checkBox;
        private System.Windows.Forms.CheckBox Energy_tank_checkBox;
        private System.Windows.Forms.CheckBox Aeion_tank_checkBox;
        private System.Windows.Forms.CheckBox Missile_tank_checkBox;
    }
}

