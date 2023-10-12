namespace wfGameTrainerAccount
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
            tableLayoutPanel1 = new TableLayoutPanel();
            laWrong = new Label();
            laCorrect = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnNo = new Button();
            btnYes = new Button();
            laCode = new Label();
            laAsk = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(laWrong, 0, 0);
            tableLayoutPanel1.Controls.Add(laCorrect, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(360, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // laWrong
            // 
            laWrong.AutoSize = true;
            laWrong.BackColor = Color.FromArgb(255, 192, 192);
            laWrong.Dock = DockStyle.Fill;
            laWrong.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            laWrong.Location = new Point(183, 0);
            laWrong.Name = "laWrong";
            laWrong.Size = new Size(174, 125);
            laWrong.TabIndex = 1;
            laWrong.Text = "Неверно = 0";
            laWrong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            laCorrect.AutoSize = true;
            laCorrect.BackColor = Color.FromArgb(192, 255, 192);
            laCorrect.Dock = DockStyle.Fill;
            laCorrect.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            laCorrect.Location = new Point(3, 0);
            laCorrect.Name = "laCorrect";
            laCorrect.Size = new Size(174, 125);
            laCorrect.TabIndex = 0;
            laCorrect.Text = "Верно = 0";
            laCorrect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnNo, 1, 0);
            tableLayoutPanel2.Controls.Add(btnYes, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 385);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(360, 156);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnNo
            // 
            btnNo.Cursor = Cursors.Hand;
            btnNo.Dock = DockStyle.Fill;
            btnNo.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnNo.ForeColor = Color.FromArgb(192, 0, 0);
            btnNo.Location = new Point(183, 3);
            btnNo.Name = "btnNo";
            btnNo.RightToLeft = RightToLeft.No;
            btnNo.Size = new Size(174, 150);
            btnNo.TabIndex = 1;
            btnNo.Text = "Нет";
            btnNo.UseVisualStyleBackColor = true;
            // 
            // btnYes
            // 
            btnYes.Cursor = Cursors.Hand;
            btnYes.Dock = DockStyle.Fill;
            btnYes.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            btnYes.ForeColor = Color.Green;
            btnYes.Location = new Point(3, 3);
            btnYes.Name = "btnYes";
            btnYes.RightToLeft = RightToLeft.No;
            btnYes.Size = new Size(174, 150);
            btnYes.TabIndex = 0;
            btnYes.Text = "Да";
            btnYes.UseVisualStyleBackColor = true;
            // 
            // laCode
            // 
            laCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            laCode.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            laCode.Location = new Point(12, 137);
            laCode.Name = "laCode";
            laCode.Size = new Size(358, 215);
            laCode.TabIndex = 2;
            laCode.Text = "10 + 12 = 22";
            laCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // laAsk
            // 
            laAsk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            laAsk.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laAsk.Location = new Point(12, 352);
            laAsk.Name = "laAsk";
            laAsk.Size = new Size(358, 33);
            laAsk.TabIndex = 3;
            laAsk.Text = "Верно?";
            laAsk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 553);
            Controls.Add(laAsk);
            Controls.Add(laCode);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(400, 500);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trainer Account";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label laCorrect;
        private Label laWrong;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnYes;
        private Button btnNo;
        private Label laCode;
        private Label laAsk;
    }
}