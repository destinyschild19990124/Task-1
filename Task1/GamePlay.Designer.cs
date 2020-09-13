namespace Task1
{
    partial class GamePlay
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
            this.actionstatusLabel = new System.Windows.Forms.Label();
            this.gameviewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionstatusLabel
            // 
            this.actionstatusLabel.AutoSize = true;
            this.actionstatusLabel.Location = new System.Drawing.Point(471, 421);
            this.actionstatusLabel.Name = "actionstatusLabel";
            this.actionstatusLabel.Size = new System.Drawing.Size(0, 17);
            this.actionstatusLabel.TabIndex = 0;
            // 
            // gameviewLabel
            // 
            this.gameviewLabel.AutoSize = true;
            this.gameviewLabel.Location = new System.Drawing.Point(22, 27);
            this.gameviewLabel.Name = "gameviewLabel";
            this.gameviewLabel.Size = new System.Drawing.Size(0, 17);
            this.gameviewLabel.TabIndex = 1;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameviewLabel);
            this.Controls.Add(this.actionstatusLabel);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamePlay_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GamePlay_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actionstatusLabel;
        private System.Windows.Forms.Label gameviewLabel;
    }
}