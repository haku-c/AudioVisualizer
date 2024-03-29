﻿namespace PlayFiles
{
    partial class MainPanel
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.filenameText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.smoothingControl = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.smoothingLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smoothingControl)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.AutoSize = true;
            this.startButton.Location = new System.Drawing.Point(173, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 33);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Play";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pauseButton.AutoSize = true;
            this.pauseButton.Location = new System.Drawing.Point(276, 16);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 26);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(92, 594);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(44, 16);
            this.fileLabel.TabIndex = 8;
            this.fileLabel.Text = "Name";
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filenameText
            // 
            this.filenameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filenameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filenameText.Location = new System.Drawing.Point(45, 19);
            this.filenameText.Name = "filenameText";
            this.filenameText.Size = new System.Drawing.Size(91, 22);
            this.filenameText.TabIndex = 7;
            this.filenameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(50, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.formsPlot1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.filenameText);
            this.splitContainer1.Panel2.Controls.Add(this.smoothingControl);
            this.splitContainer1.Panel2.Controls.Add(this.pauseButton);
            this.splitContainer1.Panel2.Controls.Add(this.startButton);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 541);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.TabIndex = 10;
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1234, 475);
            this.formsPlot1.TabIndex = 0;
            // 
            // smoothingControl
            // 
            this.smoothingControl.Location = new System.Drawing.Point(1036, 3);
            this.smoothingControl.Maximum = 20;
            this.smoothingControl.Name = "smoothingControl";
            this.smoothingControl.Size = new System.Drawing.Size(198, 56);
            this.smoothingControl.TabIndex = 13;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            // 
            // smoothingLabel
            // 
            this.smoothingLabel.Location = new System.Drawing.Point(1139, 588);
            this.smoothingLabel.Name = "smoothingLabel";
            this.smoothingLabel.Size = new System.Drawing.Size(100, 22);
            this.smoothingLabel.TabIndex = 11;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.smoothingLabel);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smoothingControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox filenameText;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar smoothingControl;
        private System.Windows.Forms.TextBox smoothingLabel;
    }
}

