namespace MC_DTG
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExecutionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NamespaceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.VersionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ExecutionButton
            // 
            resources.ApplyResources(this.ExecutionButton, "ExecutionButton");
            this.ExecutionButton.Name = "ExecutionButton";
            this.ExecutionButton.UseVisualStyleBackColor = true;
            this.ExecutionButton.Click += new System.EventHandler(this.ExecutionButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            // 
            // NamespaceTextBox
            // 
            resources.ApplyResources(this.NamespaceTextBox, "NamespaceTextBox");
            this.NamespaceTextBox.Name = "NamespaceTextBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DescriptionTextBox
            // 
            resources.ApplyResources(this.DescriptionTextBox, "DescriptionTextBox");
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // DirectoryTextBox
            // 
            resources.ApplyResources(this.DirectoryTextBox, "DirectoryTextBox");
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // DirectoryButton
            // 
            resources.ApplyResources(this.DirectoryButton, "DirectoryButton");
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // VersionComboBox
            // 
            this.VersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VersionComboBox.FormattingEnabled = true;
            this.VersionComboBox.Items.AddRange(new object[] {
            resources.GetString("VersionComboBox.Items"),
            resources.GetString("VersionComboBox.Items1"),
            resources.GetString("VersionComboBox.Items2"),
            resources.GetString("VersionComboBox.Items3"),
            resources.GetString("VersionComboBox.Items4")});
            resources.ApplyResources(this.VersionComboBox, "VersionComboBox");
            this.VersionComboBox.Name = "VersionComboBox";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VersionComboBox);
            this.Controls.Add(this.DirectoryButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NamespaceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExecutionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecutionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NamespaceTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.ComboBox VersionComboBox;
    }
}

