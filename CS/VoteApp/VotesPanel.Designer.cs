namespace DevExpress.VoteApp {
    partial class VotesPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbVotesLeft = new DevExpress.XtraEditors.LabelControl();
            this.lbVotesRight = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // lbVotesLeft
            // 
            this.lbVotesLeft.AllowHtmlString = true;
            this.lbVotesLeft.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVotesLeft.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbVotesLeft.Appearance.Options.UseFont = true;
            this.lbVotesLeft.Appearance.Options.UseForeColor = true;
            this.lbVotesLeft.Location = new System.Drawing.Point(3, 3);
            this.lbVotesLeft.Name = "lbVotesLeft";
            this.lbVotesLeft.Size = new System.Drawing.Size(135, 30);
            this.lbVotesLeft.TabIndex = 1;
            this.lbVotesLeft.Text = "<b>100</b> <size=-5><i>Electoral Votes";
            // 
            // lbVotesRight
            // 
            this.lbVotesRight.AllowHtmlString = true;
            this.lbVotesRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVotesRight.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVotesRight.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbVotesRight.Appearance.Options.UseFont = true;
            this.lbVotesRight.Appearance.Options.UseForeColor = true;
            this.lbVotesRight.Appearance.Options.UseTextOptions = true;
            this.lbVotesRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbVotesRight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbVotesRight.Location = new System.Drawing.Point(319, 3);
            this.lbVotesRight.Name = "lbVotesRight";
            this.lbVotesRight.Size = new System.Drawing.Size(284, 30);
            this.lbVotesRight.TabIndex = 2;
            this.lbVotesRight.Text = "<size=-5>Electoral Votes</size> <b>100</b>";
            // 
            // VotesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbVotesRight);
            this.Controls.Add(this.lbVotesLeft);
            this.Name = "VotesPanel";
            this.Size = new System.Drawing.Size(606, 84);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VotesPanel_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbVotesLeft;
        private DevExpress.XtraEditors.LabelControl lbVotesRight;
    }
}
