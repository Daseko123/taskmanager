namespace TaskManager
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new System.Windows.Forms.Label();
            labelInfo = new System.Windows.Forms.Label();
            buttonClear = new System.Windows.Forms.Button();
            buttonClose = new System.Windows.Forms.Button();

            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                System.Drawing.FontStyle.Bold);

            labelTitle.Location =
                new System.Drawing.Point(30, 25);

            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Settings";

            labelInfo.AutoSize = true;
            labelInfo.Location =
                new System.Drawing.Point(30, 80);

            labelInfo.Name = "labelInfo";
            labelInfo.Text =
                "Manage your Task Manager application.";

            buttonClear.Location =
                new System.Drawing.Point(30, 120);

            buttonClear.Name = "buttonClear";
            buttonClear.Size =
                new System.Drawing.Size(160, 35);

            buttonClear.Text = "Clear all tasks";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;

            buttonClose.Location =
                new System.Drawing.Point(210, 120);

            buttonClose.Name = "buttonClose";
            buttonClose.Size =
                new System.Drawing.Size(100, 35);

            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;

            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            ClientSize =
                new System.Drawing.Size(350, 200);

            Controls.Add(labelTitle);
            Controls.Add(labelInfo);
            Controls.Add(buttonClear);
            Controls.Add(buttonClose);

            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            MaximizeBox = false;
            Name = "SettingsForm";

            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            Text = "Settings";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}