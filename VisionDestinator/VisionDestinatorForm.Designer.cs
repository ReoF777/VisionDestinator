namespace VisionDestinator
{
    partial class VisionDestinatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
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
        private void InitializeComponent () {
            SetAPIBox = new Button();
            Generate = new Button();
            SelectImageBox = new PictureBox();
            ImageSelector = new Button();
            label1 = new Label();
            questionBox = new TextBox();
            label2 = new Label();
            AnsBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SelectImageBox).BeginInit();
            SuspendLayout();
            // 
            // SetAPIBox
            // 
            SetAPIBox.Location = new Point(217, 391);
            SetAPIBox.Name = "SetAPIBox";
            SetAPIBox.Size = new Size(94, 29);
            SetAPIBox.TabIndex = 0;
            SetAPIBox.Text = "APIキー設定";
            SetAPIBox.UseVisualStyleBackColor = true;
            SetAPIBox.Click += GetAPIKey;
            // 
            // Generate
            // 
            Generate.Location = new Point(530, 391);
            Generate.Name = "Generate";
            Generate.Size = new Size(94, 29);
            Generate.TabIndex = 1;
            Generate.Text = "推論";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += GenerateAns;
            // 
            // SelectImageBox
            // 
            SelectImageBox.BackColor = SystemColors.AppWorkspace;
            SelectImageBox.Location = new Point(187, 31);
            SelectImageBox.Name = "SelectImageBox";
            SelectImageBox.Size = new Size(437, 222);
            SelectImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SelectImageBox.TabIndex = 2;
            SelectImageBox.TabStop = false;
            // 
            // ImageSelector
            // 
            ImageSelector.Location = new Point(530, 259);
            ImageSelector.Name = "ImageSelector";
            ImageSelector.Size = new Size(94, 29);
            ImageSelector.TabIndex = 3;
            ImageSelector.Text = "画像選択";
            ImageSelector.UseVisualStyleBackColor = true;
            ImageSelector.Click += SelectImage;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 311);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "質問";
            // 
            // questionBox
            // 
            questionBox.Location = new Point(183, 304);
            questionBox.Name = "questionBox";
            questionBox.Size = new Size(441, 27);
            questionBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 357);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "推論結果";
            // 
            // AnsBox
            // 
            AnsBox.Location = new Point(187, 354);
            AnsBox.Name = "AnsBox";
            AnsBox.ReadOnly = true;
            AnsBox.Size = new Size(437, 27);
            AnsBox.TabIndex = 7;
            // 
            // VisionDestinatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AnsBox);
            Controls.Add(label2);
            Controls.Add(questionBox);
            Controls.Add(label1);
            Controls.Add(ImageSelector);
            Controls.Add(SelectImageBox);
            Controls.Add(Generate);
            Controls.Add(SetAPIBox);
            Name = "VisionDestinatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionDestinator";
            ((System.ComponentModel.ISupportInitialize)SelectImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SetAPIBox;
        private Button Generate;
        private PictureBox SelectImageBox;
        private Button ImageSelector;
        private Label label1;
        private TextBox questionBox;
        private Label label2;
        private TextBox AnsBox;
    }
}
