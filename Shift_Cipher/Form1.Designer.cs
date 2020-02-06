namespace Shift_Cipher
{
    partial class ShiftCipher
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.encryptTechComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.EncryptedLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.MsgClerBtn = new System.Windows.Forms.Button();
            this.encryptTextClearBtn = new System.Windows.Forms.Button();
            this.encryptMsgTextBtn = new System.Windows.Forms.Button();
            this.decryptMsgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeadingLabel.Location = new System.Drawing.Point(281, 20);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(200, 20);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Encryption Techniques";
            // 
            // encryptTechComboBox
            // 
            this.encryptTechComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptTechComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.encryptTechComboBox.FormattingEnabled = true;
            this.encryptTechComboBox.Location = new System.Drawing.Point(310, 52);
            this.encryptTechComboBox.Name = "encryptTechComboBox";
            this.encryptTechComboBox.Size = new System.Drawing.Size(149, 21);
            this.encryptTechComboBox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 138);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(493, 119);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(259, 138);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.MsgLabel.Location = new System.Drawing.Point(115, 96);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(84, 20);
            this.MsgLabel.TabIndex = 4;
            this.MsgLabel.Text = "Message";
            // 
            // EncryptedLabel
            // 
            this.EncryptedLabel.AutoSize = true;
            this.EncryptedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EncryptedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptedLabel.ForeColor = System.Drawing.Color.Red;
            this.EncryptedLabel.Location = new System.Drawing.Point(536, 96);
            this.EncryptedLabel.Name = "EncryptedLabel";
            this.EncryptedLabel.Size = new System.Drawing.Size(174, 20);
            this.EncryptedLabel.TabIndex = 5;
            this.EncryptedLabel.Text = "Encrypted Message";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(351, 162);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftLabel.ForeColor = System.Drawing.Color.Olive;
            this.ShiftLabel.Location = new System.Drawing.Point(363, 139);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(48, 20);
            this.ShiftLabel.TabIndex = 7;
            this.ShiftLabel.Text = "Shift";
            // 
            // MsgClerBtn
            // 
            this.MsgClerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MsgClerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.MsgClerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.MsgClerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.MsgClerBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MsgClerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgClerBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MsgClerBtn.Location = new System.Drawing.Point(196, 289);
            this.MsgClerBtn.Name = "MsgClerBtn";
            this.MsgClerBtn.Size = new System.Drawing.Size(110, 37);
            this.MsgClerBtn.TabIndex = 8;
            this.MsgClerBtn.Text = "Clear";
            this.MsgClerBtn.UseVisualStyleBackColor = true;
            this.MsgClerBtn.Click += new System.EventHandler(this.MsgClerBtn_Click);
            // 
            // encryptTextClearBtn
            // 
            this.encryptTextClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptTextClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.encryptTextClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.encryptTextClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.encryptTextClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.encryptTextClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptTextClearBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.encryptTextClearBtn.Location = new System.Drawing.Point(642, 289);
            this.encryptTextClearBtn.Name = "encryptTextClearBtn";
            this.encryptTextClearBtn.Size = new System.Drawing.Size(110, 37);
            this.encryptTextClearBtn.TabIndex = 9;
            this.encryptTextClearBtn.Text = "Clear";
            this.encryptTextClearBtn.UseVisualStyleBackColor = true;
            this.encryptTextClearBtn.Click += new System.EventHandler(this.encryptTextClearBtn_Click);
            // 
            // encryptMsgTextBtn
            // 
            this.encryptMsgTextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptMsgTextBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.encryptMsgTextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.encryptMsgTextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.encryptMsgTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.encryptMsgTextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptMsgTextBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.encryptMsgTextBtn.Location = new System.Drawing.Point(47, 289);
            this.encryptMsgTextBtn.Name = "encryptMsgTextBtn";
            this.encryptMsgTextBtn.Size = new System.Drawing.Size(110, 37);
            this.encryptMsgTextBtn.TabIndex = 10;
            this.encryptMsgTextBtn.Text = "Encrypt";
            this.encryptMsgTextBtn.UseVisualStyleBackColor = true;
            this.encryptMsgTextBtn.Click += new System.EventHandler(this.encryptMsgTextBtn_Click);
            // 
            // decryptMsgBtn
            // 
            this.decryptMsgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptMsgBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.decryptMsgBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.decryptMsgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.decryptMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.decryptMsgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptMsgBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.decryptMsgBtn.Location = new System.Drawing.Point(493, 289);
            this.decryptMsgBtn.Name = "decryptMsgBtn";
            this.decryptMsgBtn.Size = new System.Drawing.Size(110, 37);
            this.decryptMsgBtn.TabIndex = 11;
            this.decryptMsgBtn.Text = "Decrypt";
            this.decryptMsgBtn.UseVisualStyleBackColor = true;
            this.decryptMsgBtn.Click += new System.EventHandler(this.decryptMsgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(371, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Key";
            // 
            // keyTxtBox
            // 
            this.keyTxtBox.Location = new System.Drawing.Point(321, 268);
            this.keyTxtBox.Name = "keyTxtBox";
            this.keyTxtBox.Size = new System.Drawing.Size(149, 20);
            this.keyTxtBox.TabIndex = 13;
            // 
            // ShiftCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.keyTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptMsgBtn);
            this.Controls.Add(this.encryptMsgTextBtn);
            this.Controls.Add(this.encryptTextClearBtn);
            this.Controls.Add(this.MsgClerBtn);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.EncryptedLabel);
            this.Controls.Add(this.MsgLabel);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.encryptTechComboBox);
            this.Controls.Add(this.HeadingLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "ShiftCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftCipher";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.ComboBox encryptTechComboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.Label EncryptedLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.Button MsgClerBtn;
        private System.Windows.Forms.Button encryptTextClearBtn;
        private System.Windows.Forms.Button encryptMsgTextBtn;
        private System.Windows.Forms.Button decryptMsgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTxtBox;
    }
}

