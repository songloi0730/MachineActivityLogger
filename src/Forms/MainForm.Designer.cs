namespace MachineActivityLogger.src.Forms
{
    partial class MainForm
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
            lbWriteLog = new Label();
            txtEditor = new TextBox();
            lbEditor = new Label();
            lbTag = new Label();
            txtTag = new TextBox();
            lbContent = new Label();
            txtContent = new TextBox();
            numEditLevel = new NumericUpDown();
            lbLevel = new Label();
            btnWriteLog = new Button();
            btnLogin = new Button();
            btnViewLog = new Button();
            ((System.ComponentModel.ISupportInitialize)numEditLevel).BeginInit();
            SuspendLayout();
            // 
            // lbWriteLog
            // 
            lbWriteLog.AutoSize = true;
            lbWriteLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWriteLog.Location = new Point(40, 26);
            lbWriteLog.Name = "lbWriteLog";
            lbWriteLog.Size = new Size(218, 28);
            lbWriteLog.TabIndex = 0;
            lbWriteLog.Text = "Ghi dòng nhật ký mới";
            lbWriteLog.Click += label1_Click;
            // 
            // txtEditor
            // 
            txtEditor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEditor.Location = new Point(228, 74);
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(220, 31);
            txtEditor.TabIndex = 1;
            txtEditor.Text = "User name";
            // 
            // lbEditor
            // 
            lbEditor.AutoSize = true;
            lbEditor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEditor.Location = new Point(73, 77);
            lbEditor.Name = "lbEditor";
            lbEditor.Size = new Size(135, 25);
            lbEditor.TabIndex = 2;
            lbEditor.Text = "Tên người nhập";
            lbEditor.Click += label1_Click_1;
            // 
            // lbTag
            // 
            lbTag.AutoSize = true;
            lbTag.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTag.Location = new Point(73, 125);
            lbTag.Name = "lbTag";
            lbTag.Size = new Size(39, 25);
            lbTag.TabIndex = 4;
            lbTag.Text = "Tag";
            lbTag.Click += label1_Click_2;
            // 
            // txtTag
            // 
            txtTag.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTag.Location = new Point(228, 122);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(220, 31);
            txtTag.TabIndex = 3;
            txtTag.Text = "Tag";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContent.Location = new Point(73, 224);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(87, 25);
            lbContent.TabIndex = 6;
            lbContent.Text = "Nội dung";
            // 
            // txtContent
            // 
            txtContent.AcceptsReturn = true;
            txtContent.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContent.Location = new Point(228, 224);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Vertical;
            txtContent.Size = new Size(636, 196);
            txtContent.TabIndex = 5;
            // 
            // numEditLevel
            // 
            numEditLevel.Location = new Point(229, 177);
            numEditLevel.Name = "numEditLevel";
            numEditLevel.Size = new Size(219, 27);
            numEditLevel.TabIndex = 7;
            numEditLevel.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lbLevel
            // 
            lbLevel.AutoSize = true;
            lbLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLevel.Location = new Point(73, 179);
            lbLevel.Name = "lbLevel";
            lbLevel.Size = new Size(51, 25);
            lbLevel.TabIndex = 8;
            lbLevel.Text = "Level";
            // 
            // btnWriteLog
            // 
            btnWriteLog.Location = new Point(754, 438);
            btnWriteLog.Name = "btnWriteLog";
            btnWriteLog.Size = new Size(94, 29);
            btnWriteLog.TabIndex = 9;
            btnWriteLog.Text = "Ghi Log";
            btnWriteLog.UseVisualStyleBackColor = true;
            btnWriteLog.Click += btnWriteLog_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(754, 29);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnViewLog
            // 
            btnViewLog.Location = new Point(229, 438);
            btnViewLog.Name = "btnViewLog";
            btnViewLog.Size = new Size(94, 29);
            btnViewLog.TabIndex = 11;
            btnViewLog.Text = "Xem Log";
            btnViewLog.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 624);
            Controls.Add(btnViewLog);
            Controls.Add(btnLogin);
            Controls.Add(btnWriteLog);
            Controls.Add(lbLevel);
            Controls.Add(numEditLevel);
            Controls.Add(lbContent);
            Controls.Add(txtContent);
            Controls.Add(lbTag);
            Controls.Add(txtTag);
            Controls.Add(lbEditor);
            Controls.Add(txtEditor);
            Controls.Add(lbWriteLog);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numEditLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWriteLog;
        private TextBox txtEditor;
        private Label lbEditor;
        private Label lbTag;
        private TextBox txtTag;
        private Label lbContent;
        private TextBox txtContent;
        private NumericUpDown numEditLevel;
        private Label lbLevel;
        private Button btnWriteLog;
        private Button btnLogin;
        private Button btnViewLog;
    }
}