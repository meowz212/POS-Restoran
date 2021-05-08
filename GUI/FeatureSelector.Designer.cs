namespace GUI
{
    partial class FeatureSelector
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
            this.btnSystemSetup = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSystemSetup
            // 
            this.btnSystemSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSetup.Location = new System.Drawing.Point(53, 101);
            this.btnSystemSetup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSystemSetup.Name = "btnSystemSetup";
            this.btnSystemSetup.Size = new System.Drawing.Size(133, 123);
            this.btnSystemSetup.TabIndex = 0;
            this.btnSystemSetup.Text = "Setup Sistem";
            this.btnSystemSetup.UseVisualStyleBackColor = true;
            this.btnSystemSetup.Click += new System.EventHandler(this.btnSystemSetup_Click);
            // 
            // btnWork
            // 
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWork.Location = new System.Drawing.Point(249, 101);
            this.btnWork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(133, 123);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "Kerja";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.Location = new System.Drawing.Point(441, 101);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(133, 123);
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.Text = "Analisis";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // FeatureSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 305);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnSystemSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeatureSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeatureSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemSetup;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnAnalytics;
    }
}