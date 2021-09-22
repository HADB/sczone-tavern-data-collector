﻿
namespace SczoneTavernDataCollector.Main
{
    partial class MainForm
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
            this.OperationGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckVersionButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.IntroductionGroupBox = new System.Windows.Forms.GroupBox();
            this.SczoneLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationGroupBox.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.IntroductionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationGroupBox
            // 
            this.OperationGroupBox.Controls.Add(this.label3);
            this.OperationGroupBox.Controls.Add(this.CheckVersionButton);
            this.OperationGroupBox.Controls.Add(this.RefreshButton);
            this.OperationGroupBox.Location = new System.Drawing.Point(1059, 723);
            this.OperationGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OperationGroupBox.Name = "OperationGroupBox";
            this.OperationGroupBox.Padding = new System.Windows.Forms.Padding(20);
            this.OperationGroupBox.Size = new System.Drawing.Size(349, 296);
            this.OperationGroupBox.TabIndex = 0;
            this.OperationGroupBox.TabStop = false;
            this.OperationGroupBox.Text = "操作";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(170, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "版本号：V1.0.0";
            // 
            // CheckVersionButton
            // 
            this.CheckVersionButton.Location = new System.Drawing.Point(22, 155);
            this.CheckVersionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckVersionButton.Name = "CheckVersionButton";
            this.CheckVersionButton.Size = new System.Drawing.Size(303, 72);
            this.CheckVersionButton.TabIndex = 0;
            this.CheckVersionButton.Text = "检查更新";
            this.CheckVersionButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(22, 51);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(303, 72);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "手动上传";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogGroupBox.Controls.Add(this.LogTextBox);
            this.LogGroupBox.Location = new System.Drawing.Point(22, 23);
            this.LogGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Padding = new System.Windows.Forms.Padding(20);
            this.LogGroupBox.Size = new System.Drawing.Size(1019, 995);
            this.LogGroupBox.TabIndex = 1;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "日志";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(20, 48);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(979, 927);
            this.LogTextBox.TabIndex = 0;
            // 
            // IntroductionGroupBox
            // 
            this.IntroductionGroupBox.Controls.Add(this.SczoneLinkLabel);
            this.IntroductionGroupBox.Controls.Add(this.label4);
            this.IntroductionGroupBox.Controls.Add(this.label5);
            this.IntroductionGroupBox.Controls.Add(this.label2);
            this.IntroductionGroupBox.Controls.Add(this.label1);
            this.IntroductionGroupBox.Location = new System.Drawing.Point(1059, 23);
            this.IntroductionGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IntroductionGroupBox.Name = "IntroductionGroupBox";
            this.IntroductionGroupBox.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.IntroductionGroupBox.Size = new System.Drawing.Size(349, 693);
            this.IntroductionGroupBox.TabIndex = 2;
            this.IntroductionGroupBox.TabStop = false;
            this.IntroductionGroupBox.Text = "说明";
            // 
            // SczoneLinkLabel
            // 
            this.SczoneLinkLabel.AutoSize = true;
            this.SczoneLinkLabel.Location = new System.Drawing.Point(22, 375);
            this.SczoneLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SczoneLinkLabel.Name = "SczoneLinkLabel";
            this.SczoneLinkLabel.Size = new System.Drawing.Size(305, 28);
            this.SczoneLinkLabel.TabIndex = 1;
            this.SczoneLinkLabel.TabStop = true;
            this.SczoneLinkLabel.Text = "https://sc.yuanfen.net/tavern";
            this.SczoneLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SczoneLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "【排行榜】";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 440);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "【QQ讨论群】2599679";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 128);
            this.label2.TabIndex = 0;
            this.label2.Text = "【采集频率】首次打开会主动上传，后续在检测到文件变化后会自动上传。若日志中看到错误，可过段时间点击手动上报上传。";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "【采集原理】星际酒馆会将比赛次数、积分等信息存储至本地，本工具从本地保存的文件中读取数据并上报至服务器";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1431, 1041);
            this.Controls.Add(this.IntroductionGroupBox);
            this.Controls.Add(this.LogGroupBox);
            this.Controls.Add(this.OperationGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "星际战区-酒馆数据采集器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.OperationGroupBox.ResumeLayout(false);
            this.OperationGroupBox.PerformLayout();
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.IntroductionGroupBox.ResumeLayout(false);
            this.IntroductionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OperationGroupBox;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CheckVersionButton;
        private System.Windows.Forms.GroupBox IntroductionGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel SczoneLinkLabel;
        private System.Windows.Forms.Label label5;
    }
}
