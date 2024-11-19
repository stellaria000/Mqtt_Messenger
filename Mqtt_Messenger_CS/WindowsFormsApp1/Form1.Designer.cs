
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>

        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox, hostPortBox, topicBox, messageBox;
        private FlowLayoutPanel mainPanel, hostPortPanel, topicPanel, messagePanel;
        private Panel line;
        private Label host_txtLb, port_txtLb, tpc_txtLb, msg_txtLb;
        private TextBox host_txtEd, port_txtEd, tpc_txtEd, msg_txtEd;
        private RichTextBox textBrowser;
        private Button sub_btn, close_btn, pub_btn;


        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.hostPortBox = new System.Windows.Forms.GroupBox();
            this.host_txtLb = new System.Windows.Forms.Label();
            this.host_txtEd = new System.Windows.Forms.TextBox();
            this.port_txtLb = new System.Windows.Forms.Label();
            this.port_txtEd = new System.Windows.Forms.TextBox();
            this.topicBox = new System.Windows.Forms.GroupBox();
            this.tpc_txtLb = new System.Windows.Forms.Label();
            this.tpc_txtEd = new System.Windows.Forms.TextBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.textBrowser = new System.Windows.Forms.RichTextBox();
            this.messageBox = new System.Windows.Forms.GroupBox();
            this.msg_txtLb = new System.Windows.Forms.Label();
            this.msg_txtEd = new System.Windows.Forms.TextBox();
            this.pub_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hostPortPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topicPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.messagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.line = new System.Windows.Forms.Panel();
            //this.groupBox.SuspendLayout();
            //this.hostPortBox.SuspendLayout();
            //this.topicBox.SuspendLayout();
            //this.messageBox.SuspendLayout();
            //this.SuspendLayout();

            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.hostPortBox);
            this.groupBox.Controls.Add(this.topicBox);
            this.groupBox.Controls.Add(this.textBrowser);
            this.groupBox.Controls.Add(this.messageBox);
            this.groupBox.Controls.Add(this.close_btn);
            this.groupBox.Location = new System.Drawing.Point(10, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(600, 450);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "MQTT Messenger";
            // 
            // hostPortBox
            // 
            this.hostPortBox.Controls.Add(this.host_txtLb);
            this.hostPortBox.Controls.Add(this.host_txtEd);
            this.hostPortBox.Controls.Add(this.port_txtLb);
            this.hostPortBox.Controls.Add(this.port_txtEd);
            this.hostPortBox.Location = new System.Drawing.Point(20, 6);
            this.hostPortBox.Name = "hostPortBox";
            this.hostPortBox.Size = new System.Drawing.Size(531, 65);
            this.hostPortBox.TabIndex = 1;
            this.hostPortBox.TabStop = false;
            // 
            // host_txtLb
            // 
            this.host_txtLb.Location = new System.Drawing.Point(17, 23);
            this.host_txtLb.Name = "host_txtLb";
            this.host_txtLb.Size = new System.Drawing.Size(50, 20);
            this.host_txtLb.TabIndex = 0;
            this.host_txtLb.Text = "Host";
            // 
            // host_txtEd
            // 
            this.host_txtEd.Location = new System.Drawing.Point(73, 20);
            this.host_txtEd.Name = "host_txtEd";
            this.host_txtEd.Size = new System.Drawing.Size(178, 21);
            this.host_txtEd.TabIndex = 1;
            // 
            // port_txtLb
            // 
            this.port_txtLb.Location = new System.Drawing.Point(263, 21);
            this.port_txtLb.Name = "port_txtLb";
            this.port_txtLb.Size = new System.Drawing.Size(50, 20);
            this.port_txtLb.TabIndex = 2;
            this.port_txtLb.Text = "Port";
            this.port_txtLb.Click += new System.EventHandler(this.port_txtLb_Click);
            // 
            // port_txtEd
            // 
            this.port_txtEd.Location = new System.Drawing.Point(319, 20);
            this.port_txtEd.Name = "port_txtEd";
            this.port_txtEd.Size = new System.Drawing.Size(180, 21);
            this.port_txtEd.TabIndex = 3;
            // 
            // topicBox
            // 
            this.topicBox.Controls.Add(this.tpc_txtLb);
            this.topicBox.Controls.Add(this.tpc_txtEd);
            this.topicBox.Controls.Add(this.sub_btn);
            this.topicBox.Location = new System.Drawing.Point(20, 280);
            this.topicBox.Name = "topicBox";
            this.topicBox.Size = new System.Drawing.Size(531, 30);
            this.topicBox.TabIndex = 2;
            this.topicBox.TabStop = false;
            // 
            // tpc_txtLb
            // 
            this.tpc_txtLb.Location = new System.Drawing.Point(3, 0);
            this.tpc_txtLb.Name = "tpc_txtLb";
            this.tpc_txtLb.Size = new System.Drawing.Size(50, 20);
            this.tpc_txtLb.TabIndex = 0;
            this.tpc_txtLb.Text = "Topic";
            // 
            // tpc_txtEd
            // 
            this.tpc_txtEd.Location = new System.Drawing.Point(59, 3);
            this.tpc_txtEd.Name = "tpc_txtEd";
            this.tpc_txtEd.Size = new System.Drawing.Size(200, 21);
            this.tpc_txtEd.TabIndex = 1;
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(265, 3);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(100, 25);
            this.sub_btn.TabIndex = 2;
            this.sub_btn.Text = "Subscribe";
            // 
            // textBrowser
            // 
            this.textBrowser.Location = new System.Drawing.Point(20, 77);
            this.textBrowser.Name = "textBrowser";
            this.textBrowser.Size = new System.Drawing.Size(531, 200);
            this.textBrowser.TabIndex = 0;
            this.textBrowser.Text = "";
            this.textBrowser.TextChanged += new System.EventHandler(this.textBrowser_TextChanged);
            // 
            // messageBox
            // 
            this.messageBox.Controls.Add(this.msg_txtLb);
            this.messageBox.Controls.Add(this.msg_txtEd);
            this.messageBox.Controls.Add(this.pub_btn);
            this.messageBox.Location = new System.Drawing.Point(34, 346);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(531, 30);
            this.messageBox.TabIndex = 3;
            this.messageBox.TabStop = false;
            // 
            // msg_txtLb
            // 
            this.msg_txtLb.Location = new System.Drawing.Point(3, 0);
            this.msg_txtLb.Name = "msg_txtLb";
            this.msg_txtLb.Size = new System.Drawing.Size(70, 20);
            this.msg_txtLb.TabIndex = 0;
            this.msg_txtLb.Text = "Message";
            // 
            // msg_txtEd
            // 
            this.msg_txtEd.Location = new System.Drawing.Point(79, 3);
            this.msg_txtEd.Name = "msg_txtEd";
            this.msg_txtEd.Size = new System.Drawing.Size(300, 21);
            this.msg_txtEd.TabIndex = 1;
            // 
            // pub_btn
            // 
            this.pub_btn.Location = new System.Drawing.Point(385, 3);
            this.pub_btn.Name = "pub_btn";
            this.pub_btn.Size = new System.Drawing.Size(100, 25);
            this.pub_btn.TabIndex = 2;
            this.pub_btn.Text = "Publish";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(460, 470);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(100, 30);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "Close";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 100);
            this.mainPanel.TabIndex = 0;
            // 
            // hostPortPanel
            // 
            this.hostPortPanel.Location = new System.Drawing.Point(0, 0);
            this.hostPortPanel.Name = "hostPortPanel";
            this.hostPortPanel.Size = new System.Drawing.Size(200, 100);
            this.hostPortPanel.TabIndex = 0;
            // 
            // topicPanel
            // 
            this.topicPanel.Location = new System.Drawing.Point(0, 0);
            this.topicPanel.Name = "topicPanel";
            this.topicPanel.Size = new System.Drawing.Size(200, 100);
            this.topicPanel.TabIndex = 0;
            // 
            // messagePanel
            // 
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(200, 100);
            this.messagePanel.TabIndex = 0;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(0, 0);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(200, 100);
            this.line.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Network Connection UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.hostPortBox.ResumeLayout(false);
            this.hostPortBox.PerformLayout();
            this.topicBox.ResumeLayout(false);
            this.topicBox.PerformLayout();
            this.messageBox.ResumeLayout(false);
            this.messageBox.PerformLayout();
            this.ResumeLayout(false);


        }

    }

        #endregion
}


