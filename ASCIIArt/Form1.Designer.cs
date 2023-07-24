namespace ASCIIArt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            drawButton = new Button();
            fileButton = new Button();
            groupBox1 = new GroupBox();
            saveButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            charsetText = new TextBox();
            charsetList = new ListBox();
            fileText = new TextBox();
            label2 = new Label();
            widthText = new TextBox();
            repeatText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "File:";
            // 
            // drawButton
            // 
            drawButton.Location = new Point(12, 270);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(272, 26);
            drawButton.TabIndex = 2;
            drawButton.Text = "Draw";
            drawButton.UseVisualStyleBackColor = true;
            // 
            // fileButton
            // 
            fileButton.Location = new Point(221, 27);
            fileButton.Name = "fileButton";
            fileButton.Size = new Size(63, 23);
            fileButton.TabIndex = 3;
            fileButton.Text = "Open";
            fileButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(removeButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(charsetText);
            groupBox1.Controls.Add(charsetList);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 168);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Charset";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(209, 22);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(57, 24);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(147, 137);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(119, 25);
            removeButton.TabIndex = 3;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 137);
            addButton.Name = "addButton";
            addButton.Size = new Size(135, 25);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // charsetText
            // 
            charsetText.Location = new Point(6, 23);
            charsetText.Name = "charsetText";
            charsetText.Size = new Size(197, 23);
            charsetText.TabIndex = 1;
            // 
            // charsetList
            // 
            charsetList.FormattingEnabled = true;
            charsetList.ItemHeight = 15;
            charsetList.Location = new Point(6, 52);
            charsetList.Name = "charsetList";
            charsetList.Size = new Size(260, 79);
            charsetList.TabIndex = 0;
            // 
            // fileText
            // 
            fileText.Location = new Point(12, 27);
            fileText.Name = "fileText";
            fileText.Size = new Size(203, 23);
            fileText.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Size: ~";
            // 
            // widthText
            // 
            widthText.Location = new Point(53, 56);
            widthText.Name = "widthText";
            widthText.Size = new Size(47, 23);
            widthText.TabIndex = 7;
            widthText.Text = "50";
            // 
            // repeatText
            // 
            repeatText.Location = new Point(195, 56);
            repeatText.Name = "repeatText";
            repeatText.Size = new Size(47, 23);
            repeatText.TabIndex = 9;
            repeatText.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 59);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Repeat char";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 59);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "times";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 308);
            Controls.Add(label4);
            Controls.Add(repeatText);
            Controls.Add(label3);
            Controls.Add(widthText);
            Controls.Add(label2);
            Controls.Add(fileText);
            Controls.Add(groupBox1);
            Controls.Add(fileButton);
            Controls.Add(drawButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "ASCII Art";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button drawButton;
        private Button fileButton;
        private GroupBox groupBox1;
        private TextBox charsetText;
        private ListBox charsetList;
        private Button removeButton;
        private Button addButton;
        private TextBox fileText;
        private Label label2;
        private TextBox widthText;
        private Button saveButton;
        private TextBox repeatText;
        private Label label3;
        private Label label4;
    }
}