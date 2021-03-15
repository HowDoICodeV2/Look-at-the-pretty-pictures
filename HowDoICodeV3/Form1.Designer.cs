
namespace HowDoICodeV3
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
            this.fileSelect = new System.Windows.Forms.Button();
            this.popOutButton = new System.Windows.Forms.Button();
            this.folderLocationText = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ListBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelect.Location = new System.Drawing.Point(37, 33);
            this.fileSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(118, 31);
            this.fileSelect.TabIndex = 0;
            this.fileSelect.Text = "Folder Select";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // popOutButton
            // 
            this.popOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popOutButton.Location = new System.Drawing.Point(37, 246);
            this.popOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.popOutButton.Name = "popOutButton";
            this.popOutButton.Size = new System.Drawing.Size(118, 31);
            this.popOutButton.TabIndex = 1;
            this.popOutButton.Text = "Show Picture";
            this.popOutButton.UseVisualStyleBackColor = true;
            this.popOutButton.Click += new System.EventHandler(this.popOutButton_Click);
            // 
            // folderLocationText
            // 
            this.folderLocationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderLocationText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderLocationText.Location = new System.Drawing.Point(173, 296);
            this.folderLocationText.Name = "folderLocationText";
            this.folderLocationText.Size = new System.Drawing.Size(274, 22);
            this.folderLocationText.TabIndex = 3;
            this.folderLocationText.Click += new System.EventHandler(this.folderLocationText_Click);
            // 
            // imageList
            // 
            this.imageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageList.FormattingEnabled = true;
            this.imageList.ItemHeight = 20;
            this.imageList.Location = new System.Drawing.Point(173, 33);
            this.imageList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(274, 244);
            this.imageList.TabIndex = 4;
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 341);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.folderLocationText);
            this.Controls.Add(this.popOutButton);
            this.Controls.Add(this.fileSelect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ImageViewer(No-Virus)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.Button popOutButton;
        private System.Windows.Forms.Label folderLocationText;
        private System.Windows.Forms.ListBox imageList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
    }
}

