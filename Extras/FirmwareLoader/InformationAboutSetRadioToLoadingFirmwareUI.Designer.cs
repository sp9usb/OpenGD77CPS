namespace Extras.FirmwareLoader
{
    partial class InformationAboutSetRadioToLoadingFirmwareUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationAboutSetRadioToLoadingFirmwareUI));
            this.settingRadioImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.informationalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingRadioImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingRadioImage
            // 
            this.settingRadioImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingRadioImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingRadioImage.ErrorImage = null;
            this.settingRadioImage.Image = global::Properties.Resources.gd_77_key;
            this.settingRadioImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("settingRadioImage.InitialImage")));
            this.settingRadioImage.Location = new System.Drawing.Point(3, 38);
            this.settingRadioImage.Name = "settingRadioImage";
            this.settingRadioImage.Size = new System.Drawing.Size(455, 412);
            this.settingRadioImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingRadioImage.TabIndex = 0;
            this.settingRadioImage.TabStop = false;
            this.settingRadioImage.WaitOnLoad = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.settingRadioImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.informationalLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.905138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.09486F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 506);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(184, 463);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(92, 32);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // informationalLabel
            // 
            this.informationalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationalLabel.AutoSize = true;
            this.informationalLabel.Location = new System.Drawing.Point(3, 0);
            this.informationalLabel.Name = "informationalLabel";
            this.informationalLabel.Size = new System.Drawing.Size(455, 35);
            this.informationalLabel.TabIndex = 2;
            this.informationalLabel.Text = "Before starting upload firmware, click the buttons and turn on the radio.";
            this.informationalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationAboutSetRadioToLoadingFirmwareUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationAboutSetRadioToLoadingFirmwareUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup your radio before firmware uploading.";
            ((System.ComponentModel.ISupportInitialize)(this.settingRadioImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox settingRadioImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label informationalLabel;
    }
}