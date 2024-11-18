
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
        private GroupBox groupBox, idPwBox, hostPortGroup, topicMessageGroup, logGroup;
        private Panel connectingBox;
        // private FlowLayoutPanel idPwBox;
        private Label id_txtLb;
        private TextBox id_txtEd;
        private Label pw_txtLb;
        private TextBox pw_txtEd;
        private FlowLayoutPanel hostPortBox;
        private Label host_txtLb;
        private TextBox host_txtEd;
        private Label port_txtLb;
        private TextBox port_txtEd;
        private Button connect_btn;
        private Panel line;
        private Panel topicMessageBox;
        private FlowLayoutPanel topicBox;
        private Label tpc_txtLb;
        private TextBox tpc_txtEd;
        private Button sub_btn;
        private FlowLayoutPanel messageBox;
        private Label msg_txtLb;
        private TextBox msg_txtEd;
        private Button pub_btn;
        private RichTextBox textbrowser;
        private Button close_btn;
        private FlowLayoutPanel mainPanel;
        private RichTextBox textBrowser;

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
            #region First
            //this.groupBox = new System.Windows.Forms.GroupBox();
            //// idPwBox = new System.Windows.Forms.FlowLayoutPanel();
            //this.id_txtLb = new System.Windows.Forms.Label();
            //this.id_txtEd = new System.Windows.Forms.TextBox();
            //this.pw_txtLb = new System.Windows.Forms.Label();
            //this.pw_txtEd = new System.Windows.Forms.TextBox();
            //hostPortBox = new System.Windows.Forms.FlowLayoutPanel();
            //this.host_txtLb = new System.Windows.Forms.Label();
            //this.host_txtEd = new System.Windows.Forms.TextBox();
            //this.port_txtLb = new System.Windows.Forms.Label();
            //this.port_txtEd = new System.Windows.Forms.TextBox();
            //this.connect_btn = new System.Windows.Forms.Button();
            //this.topicBox = new System.Windows.Forms.FlowLayoutPanel();
            //this.tpc_txtLb = new System.Windows.Forms.Label();
            //this.tpc_txtEd = new System.Windows.Forms.TextBox();
            //this.sub_btn = new System.Windows.Forms.Button();
            //this.messageBox = new System.Windows.Forms.FlowLayoutPanel();
            //this.msg_txtLb = new System.Windows.Forms.Label();
            //this.msg_txtEd = new System.Windows.Forms.TextBox();
            //this.pub_btn = new System.Windows.Forms.Button();
            //this.close_btn = new System.Windows.Forms.Button();
            //this.groupBox.SuspendLayout();
            //this.idPwBox.SuspendLayout();
            //this.hostPortBox.SuspendLayout();
            //this.topicBox.SuspendLayout();
            //this.messageBox.SuspendLayout();
            //this.SuspendLayout();

            //// 
            //// groupBox
            //// 
            //this.groupBox.Controls.Add(this.idPwBox);
            //this.groupBox.Controls.Add(this.hostPortBox);
            //this.groupBox.Controls.Add(this.topicBox);
            //this.groupBox.Controls.Add(this.messageBox);
            //this.groupBox.Controls.Add(this.close_btn);
            //this.groupBox.Location = new System.Drawing.Point(10, 0);
            //this.groupBox.Name = "groupBox";
            //this.groupBox.Size = new System.Drawing.Size(600, 450);
            //this.groupBox.TabIndex = 0;
            //this.groupBox.TabStop = false;
            //this.groupBox.Text = "Network Connection";
            //// 
            //// idPwBox
            //// 
            //this.idPwBox.Controls.Add(this.id_txtLb);
            //this.idPwBox.Controls.Add(this.id_txtEd);
            //this.idPwBox.Controls.Add(this.pw_txtLb);
            //this.idPwBox.Controls.Add(this.pw_txtEd);
            //this.idPwBox.Location = new System.Drawing.Point(20, 20);
            //this.idPwBox.Name = "idPwBox";
            //this.idPwBox.Size = new System.Drawing.Size(531, 30);
            //this.idPwBox.TabIndex = 0;
            //// 
            //// id_txtLb
            //// 
            //this.id_txtLb.Location = new System.Drawing.Point(3, 0);
            //this.id_txtLb.Name = "id_txtLb";
            //this.id_txtLb.Size = new System.Drawing.Size(50, 20);
            //this.id_txtLb.TabIndex = 0;
            //this.id_txtLb.Text = "ID";
            //this.id_txtLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //// 
            //// id_txtEd
            //// 
            //this.id_txtEd.Location = new System.Drawing.Point(59, 3);
            //this.id_txtEd.Name = "id_txtEd";
            //this.id_txtEd.Size = new System.Drawing.Size(100, 21);
            //this.id_txtEd.TabIndex = 1;
            //// 
            //// pw_txtLb
            //// 
            //this.pw_txtLb.Location = new System.Drawing.Point(165, 0);
            //this.pw_txtLb.Name = "pw_txtLb";
            //this.pw_txtLb.Size = new System.Drawing.Size(70, 20);
            //this.pw_txtLb.TabIndex = 2;
            //this.pw_txtLb.Text = "Password";
            //this.pw_txtLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //// 
            //// pw_txtEd
            //// 
            //this.pw_txtEd.Location = new System.Drawing.Point(241, 3);
            //this.pw_txtEd.Name = "pw_txtEd";
            //this.pw_txtEd.Size = new System.Drawing.Size(100, 21);
            //this.pw_txtEd.TabIndex = 3;
            //// 
            //// hostPortBox
            //// 
            //this.hostPortBox.Controls.Add(this.host_txtLb);
            //this.hostPortBox.Controls.Add(this.host_txtEd);
            //this.hostPortBox.Controls.Add(this.port_txtLb);
            //this.hostPortBox.Controls.Add(this.port_txtEd);
            //this.hostPortBox.Controls.Add(this.connect_btn);
            //this.hostPortBox.Location = new System.Drawing.Point(20, 69);
            //this.hostPortBox.Name = "hostPortBox";
            //this.hostPortBox.Size = new System.Drawing.Size(531, 30);
            //this.hostPortBox.TabIndex = 1;
            //// 
            //// host_txtLb
            //// 
            //this.host_txtLb.Location = new System.Drawing.Point(3, 0);
            //this.host_txtLb.Name = "host_txtLb";
            //this.host_txtLb.Size = new System.Drawing.Size(50, 20);
            //this.host_txtLb.TabIndex = 0;
            //this.host_txtLb.Text = "Host";
            //// 
            //// host_txtEd
            //// 
            //this.host_txtEd.Location = new System.Drawing.Point(59, 3);
            //this.host_txtEd.Name = "host_txtEd";
            //this.host_txtEd.Size = new System.Drawing.Size(100, 21);
            //this.host_txtEd.TabIndex = 1;
            //// 
            //// port_txtLb
            //// 
            //this.port_txtLb.Location = new System.Drawing.Point(165, 0);
            //this.port_txtLb.Name = "port_txtLb";
            //this.port_txtLb.Size = new System.Drawing.Size(50, 20);
            //this.port_txtLb.TabIndex = 2;
            //this.port_txtLb.Text = "Port";
            //// 
            //// port_txtEd
            //// 
            //this.port_txtEd.Location = new System.Drawing.Point(221, 3);
            //this.port_txtEd.Name = "port_txtEd";
            //this.port_txtEd.Size = new System.Drawing.Size(100, 21);
            //this.port_txtEd.TabIndex = 3;
            //// 
            //// connect_btn
            //// 
            //this.connect_btn.Location = new System.Drawing.Point(327, 3);
            //this.connect_btn.Name = "connect_btn";
            //this.connect_btn.Size = new System.Drawing.Size(100, 25);
            //this.connect_btn.TabIndex = 4;
            //this.connect_btn.Text = "Connect";
            //// 
            //// topicBox
            //// 
            //this.topicBox.Controls.Add(this.tpc_txtLb);
            //this.topicBox.Controls.Add(this.tpc_txtEd);
            //this.topicBox.Controls.Add(this.sub_btn);
            //this.topicBox.Location = new System.Drawing.Point(20, 280);
            //this.topicBox.Name = "topicBox";
            //this.topicBox.Size = new System.Drawing.Size(531, 30);
            //this.topicBox.TabIndex = 2;
            //// 
            //// tpc_txtLb
            //// 
            //this.tpc_txtLb.Location = new System.Drawing.Point(3, 0);
            //this.tpc_txtLb.Name = "tpc_txtLb";
            //this.tpc_txtLb.Size = new System.Drawing.Size(50, 20);
            //this.tpc_txtLb.TabIndex = 0;
            //this.tpc_txtLb.Text = "Topic";
            //// 
            //// tpc_txtEd
            //// 
            //this.tpc_txtEd.Location = new System.Drawing.Point(59, 3);
            //this.tpc_txtEd.Name = "tpc_txtEd";
            //this.tpc_txtEd.Size = new System.Drawing.Size(200, 21);
            //this.tpc_txtEd.TabIndex = 1;
            //// 
            //// sub_btn
            //// 
            //this.sub_btn.Location = new System.Drawing.Point(265, 3);
            //this.sub_btn.Name = "sub_btn";
            //this.sub_btn.Size = new System.Drawing.Size(100, 25);
            //this.sub_btn.TabIndex = 2;
            //this.sub_btn.Text = "Subscribe";
            //// 
            //// messageBox
            //// 
            //this.messageBox.Controls.Add(this.msg_txtLb);
            //this.messageBox.Controls.Add(this.msg_txtEd);
            //this.messageBox.Controls.Add(this.pub_btn);
            //this.messageBox.Location = new System.Drawing.Point(34, 346);
            //this.messageBox.Name = "messageBox";
            //this.messageBox.Size = new System.Drawing.Size(531, 30);
            //this.messageBox.TabIndex = 3;
            //// 
            //// msg_txtLb
            //// 
            //this.msg_txtLb.Location = new System.Drawing.Point(3, 0);
            //this.msg_txtLb.Name = "msg_txtLb";
            //this.msg_txtLb.Size = new System.Drawing.Size(70, 20);
            //this.msg_txtLb.TabIndex = 0;
            //this.msg_txtLb.Text = "Message";
            //// 
            //// msg_txtEd
            //// 
            //this.msg_txtEd.Location = new System.Drawing.Point(79, 3);
            //this.msg_txtEd.Name = "msg_txtEd";
            //this.msg_txtEd.Size = new System.Drawing.Size(300, 21);
            //this.msg_txtEd.TabIndex = 1;
            //// 
            //// pub_btn
            //// 
            //this.pub_btn.Location = new System.Drawing.Point(385, 3);
            //this.pub_btn.Name = "pub_btn";
            //this.pub_btn.Size = new System.Drawing.Size(100, 25);
            //this.pub_btn.TabIndex = 2;
            //this.pub_btn.Text = "Publish";
            //// 
            //// close_btn
            //// 
            //this.close_btn.Location = new System.Drawing.Point(460, 470);
            //this.close_btn.Name = "close_btn";
            //this.close_btn.Size = new System.Drawing.Size(100, 30);
            //this.close_btn.TabIndex = 4;
            //this.close_btn.Text = "Close";
            //// 
            //// Form1
            //// 
            //this.ClientSize = new System.Drawing.Size(584, 511);
            //this.Controls.Add(this.groupBox);
            //this.Name = "Form1";
            //this.Text = "Network Connection UI";
            //this.groupBox.ResumeLayout(false);
            //this.idPwBox.ResumeLayout(false);
            //this.idPwBox.PerformLayout();
            //this.hostPortBox.ResumeLayout(false);
            //this.hostPortBox.PerformLayout();
            //this.topicBox.ResumeLayout(false);
            //this.topicBox.PerformLayout();
            //this.messageBox.ResumeLayout(false);
            //this.messageBox.PerformLayout();
            //this.ResumeLayout(false);
        #endregion

            #region Two
            // Main FlowLayoutPanel
            mainPanel = new FlowLayoutPanel();
            mainPanel.FlowDirection = FlowDirection.TopDown;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.AutoScroll = true;

            // ID/PW GroupBox
            idPwBox = new GroupBox();
            idPwBox.Text = "Login Information";
            idPwBox.AutoSize = true;
            idPwBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FlowLayoutPanel idPwLayout = new FlowLayoutPanel();
            idPwLayout.FlowDirection = FlowDirection.LeftToRight;
            idPwLayout.AutoSize = true;
            idPwLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            id_txtEd = CreateTextBox("ID");
            pw_txtEd = CreateTextBox("Password", isPassword: true);

            idPwLayout.Controls.Add(CreateLabel("ID:"));
            idPwLayout.Controls.Add(id_txtEd);
            idPwLayout.Controls.Add(CreateLabel("Password:"));
            idPwLayout.Controls.Add(pw_txtEd);

            idPwBox.Controls.Add(idPwLayout);

            // Host/Port GroupBox
            hostPortGroup = new GroupBox();
            hostPortGroup.Text = "Connection Information";
            hostPortGroup.AutoSize = true;
            hostPortGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FlowLayoutPanel hostPortLayout = new FlowLayoutPanel();
            hostPortLayout.FlowDirection = FlowDirection.LeftToRight;
            hostPortLayout.AutoSize = true;
            hostPortLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            host_txtEd = CreateTextBox("Host");
            port_txtEd = CreateTextBox("Port");
            connect_btn = new Button { Text = "Connect", AutoSize = true };

            hostPortLayout.Controls.Add(CreateLabel("Host:"));
            hostPortLayout.Controls.Add(host_txtEd);
            hostPortLayout.Controls.Add(CreateLabel("Port:"));
            hostPortLayout.Controls.Add(port_txtEd);
            hostPortLayout.Controls.Add(connect_btn);

            hostPortGroup.Controls.Add(hostPortLayout);

            // Topic/Message GroupBox
            topicMessageGroup = new GroupBox();
            topicMessageGroup.Text = "Topic and Message";
            topicMessageGroup.AutoSize = true;
            topicMessageGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FlowLayoutPanel topicMessageLayout = new FlowLayoutPanel();
            topicMessageLayout.FlowDirection = FlowDirection.TopDown;
            topicMessageLayout.AutoSize = true;
            topicMessageLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            FlowLayoutPanel topicLayout = new FlowLayoutPanel();
            topicLayout.FlowDirection = FlowDirection.LeftToRight;
            topicLayout.AutoSize = true;

            tpc_txtEd = CreateTextBox("Topic");
            sub_btn = new Button { Text = "Subscribe", AutoSize = true };

            topicLayout.Controls.Add(CreateLabel("Topic:"));
            topicLayout.Controls.Add(tpc_txtEd);
            topicLayout.Controls.Add(sub_btn);

            FlowLayoutPanel messageLayout = new FlowLayoutPanel();
            messageLayout.FlowDirection = FlowDirection.LeftToRight;
            messageLayout.AutoSize = true;

            msg_txtEd = CreateTextBox("Message");
            pub_btn = new Button { Text = "Publish", AutoSize = true };

            messageLayout.Controls.Add(CreateLabel("Message:"));
            messageLayout.Controls.Add(msg_txtEd);
            messageLayout.Controls.Add(pub_btn);

            topicMessageLayout.Controls.Add(topicLayout);
            topicMessageLayout.Controls.Add(messageLayout);
            topicMessageGroup.Controls.Add(topicMessageLayout);

            // Log GroupBox
            logGroup = new GroupBox();
            logGroup.Text = "Logs";
            logGroup.AutoSize = true;
            logGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            textBrowser = new RichTextBox();
            textBrowser.Size = new Size(500, 200);
            textBrowser.ReadOnly = true;

            logGroup.Controls.Add(textBrowser);

            // Close Button
            close_btn = new Button
            {
                Text = "Close",
                AutoSize = true,
                Dock = DockStyle.Bottom
            };
            close_btn.Click += (s, e) => this.Close();

            // Add all groups to the main panel
            mainPanel.Controls.Add(idPwBox);
            mainPanel.Controls.Add(hostPortGroup);
            mainPanel.Controls.Add(topicMessageGroup);
            mainPanel.Controls.Add(logGroup);
            mainPanel.Controls.Add(close_btn);

            // Add main panel to the form
            this.Controls.Add(mainPanel);

            // Form Settings
            this.Text = "Network Connection UI";
            this.Size = new Size(600, 600);
            #endregion Two
        }

    }

        #endregion
}


