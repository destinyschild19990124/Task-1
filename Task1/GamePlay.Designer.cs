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
            this.label1 = new System.Windows.Forms.Label();
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
            this.gameviewLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameviewLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameviewLabel.Location = new System.Drawing.Point(23, 176);
            this.gameviewLabel.Name = "gameviewLabel";
            this.gameviewLabel.Size = new System.Drawing.Size(2, 24);
            this.gameviewLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameviewLabel);
            this.Controls.Add(this.actionstatusLabel);
            this.Name = "GamePlay";
            this.Text = "GamePlay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamePlay_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actionstatusLabel;
        private System.Windows.Forms.Label gameviewLabel;
        private System.Windows.Forms.Label label1;
    }
}