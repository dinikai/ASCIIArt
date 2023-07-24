namespace ASCIIArt
{
    partial class ArtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtForm));
            artText = new RichTextBox();
            copyButton = new Button();
            SuspendLayout();
            // 
            // artText
            // 
            artText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            artText.DetectUrls = false;
            artText.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            artText.Location = new Point(12, 12);
            artText.Name = "artText";
            artText.Size = new Size(635, 363);
            artText.TabIndex = 0;
            artText.Text = "";
            // 
            // copyButton
            // 
            copyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            copyButton.Location = new Point(12, 381);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(635, 25);
            copyButton.TabIndex = 1;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            // 
            // ArtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 418);
            Controls.Add(copyButton);
            Controls.Add(artText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ArtForm";
            Text = "Done";
            ResumeLayout(false);
        }

        #endregion
        private Button copyButton;
        protected RichTextBox artText;
    }
}