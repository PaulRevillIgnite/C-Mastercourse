namespace WinFormMiniProject
{
    partial class PersonBasicsForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ageTextbox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.basicInfoListbox = new System.Windows.Forms.ListBox();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(232, 84);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(70, 6);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(237, 20);
            this.firstNameTextbox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(52, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "Firstname";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(70, 32);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(237, 20);
            this.lastNameTextbox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 35);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(53, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Lastname";
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(70, 58);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(50, 20);
            this.ageTextbox.TabIndex = 2;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 61);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Age";
            // 
            // basicInfoListbox
            // 
            this.basicInfoListbox.FormattingEnabled = true;
            this.basicInfoListbox.Location = new System.Drawing.Point(15, 113);
            this.basicInfoListbox.Name = "basicInfoListbox";
            this.basicInfoListbox.Size = new System.Drawing.Size(292, 134);
            this.basicInfoListbox.TabIndex = 9;
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(15, 256);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(292, 23);
            this.addAddressButton.TabIndex = 10;
            this.addAddressButton.Text = "Add Address";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // PersonBasicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 291);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.basicInfoListbox);
            this.Controls.Add(this.ageTextbox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.addButton);
            this.Name = "PersonBasicsForm";
            this.Text = "Basic Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox ageTextbox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ListBox basicInfoListbox;
        private System.Windows.Forms.Button addAddressButton;
    }
}

