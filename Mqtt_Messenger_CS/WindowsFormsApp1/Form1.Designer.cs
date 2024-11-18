
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button button1;

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
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.connectingBox = new System.Windows.Forms.Panel();
            this.idPwBox = new System.Windows.Forms.FlowLayoutPanel();
            this.id_txtLb = new System.Windows.Forms.Label();
            this.id_txtEd = new System.Windows.Forms.TextBox();
            this.pw_txtLb = new System.Windows.Forms.Label();
            this.pw_txtEd = new System.Windows.Forms.TextBox();
            this.hostPortBox = new System.Windows.Forms.FlowLayoutPanel();
            this.host_txtLb = new System.Windows.Forms.Label();
            this.host_txtEd = new System.Windows.Forms.TextBox();
            this.port_txtLb = new System.Windows.Forms.Label();
            this.port_txtEd = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Panel();
            this.topicMessageBox = new System.Windows.Forms.Panel();
            this.topicBox = new System.Windows.Forms.FlowLayoutPanel();
            this.tpc_txtLb = new System.Windows.Forms.Label();
            this.tpc_txtEd = new System.Windows.Forms.TextBox();
            this.sub_btn = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.FlowLayoutPanel();
            this.textbrowser = new System.Windows.Forms.RichTextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.msg_txtLb = new System.Windows.Forms.Label();
            this.msg_txtEd = new System.Windows.Forms.TextBox();
            this.pub_btn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.connectingBox.SuspendLayout();
            this.idPwBox.SuspendLayout();
            this.hostPortBox.SuspendLayout();
            this.topicMessageBox.SuspendLayout();
            this.topicBox.SuspendLayout();
            this.SuspendLayout();

            /*GROUPBOX*/
            this.groupBox.Controls.Add(this.connectingBox);
            this.groupBox.Controls.Add(this.line);
            this.groupBox.Controls.Add(this.topicMessageBox);
            this.groupBox.Location = new System.Drawing.Point(10, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(531, 91);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "MQTT Client";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            
            /*CONNECTING BOX*/
            this.connectingBox.Controls.Add(this.idPwBox);
            this.connectingBox.Controls.Add(this.hostPortBox);
            this.connectingBox.Location = new System.Drawing.Point(9, 19);
            this.connectingBox.Name = "connectingBox";
            this.connectingBox.Size = new System.Drawing.Size(531, 91);
            this.connectingBox.TabIndex = 0;
            
            /*IDPW BOX*/
            this.idPwBox.Controls.Add(this.id_txtEd);
            this.idPwBox.Controls.Add(this.pw_txtLb);
            this.idPwBox.Controls.Add(this.pw_txtEd);
            this.idPwBox.Location = new System.Drawing.Point(0, 0);
            this.idPwBox.Name = "idPwBox";
            this.idPwBox.Size = new System.Drawing.Size(531, 91);
            this.idPwBox.TabIndex = 0;
            // 
            // id_txtLb
            // 
            this.id_txtLb.Location = new System.Drawing.Point(430, 217);
            this.id_txtLb.Name = "id_txtLb";
            this.id_txtLb.Size = new System.Drawing.Size(100, 23);
            this.id_txtLb.TabIndex = 0;
            this.id_txtLb.Text = "ID";
            this.id_txtLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_txtEd
            // 
            this.id_txtEd.Location = new System.Drawing.Point(109, 3);
            this.id_txtEd.Name = "id_txtEd";
            this.id_txtEd.Size = new System.Drawing.Size(100, 21);
            this.id_txtEd.TabIndex = 1;
            // 
            // pw_txtLb
            // 
            this.pw_txtLb.Location = new System.Drawing.Point(215, 0);
            this.pw_txtLb.Name = "pw_txtLb";
            this.pw_txtLb.Size = new System.Drawing.Size(100, 23);
            this.pw_txtLb.TabIndex = 2;
            this.pw_txtLb.Text = "Password";
            this.pw_txtLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pw_txtEd
            // 
            this.pw_txtEd.Location = new System.Drawing.Point(321, 3);
            this.pw_txtEd.Name = "pw_txtEd";
            this.pw_txtEd.Size = new System.Drawing.Size(100, 21);
            this.pw_txtEd.TabIndex = 3;
            // 
            // hostPortBox
            // 
            this.hostPortBox.Controls.Add(this.host_txtLb);
            this.hostPortBox.Controls.Add(this.host_txtEd);
            this.hostPortBox.Controls.Add(this.port_txtLb);
            this.hostPortBox.Controls.Add(this.port_txtEd);
            this.hostPortBox.Controls.Add(this.connect_btn);
            this.hostPortBox.Location = new System.Drawing.Point(0, 31);
            this.hostPortBox.Name = "hostPortBox";
            this.hostPortBox.Size = new System.Drawing.Size(531, 30);
            this.hostPortBox.TabIndex = 1;
            // 
            // host_txtLb
            // 
            this.host_txtLb.Location = new System.Drawing.Point(3, 0);
            this.host_txtLb.Name = "host_txtLb";
            this.host_txtLb.Size = new System.Drawing.Size(100, 23);
            this.host_txtLb.TabIndex = 0;
            this.host_txtLb.Text = "Host";
            // 
            // host_txtEd
            // 
            this.host_txtEd.Location = new System.Drawing.Point(109, 3);
            this.host_txtEd.Name = "host_txtEd";
            this.host_txtEd.Size = new System.Drawing.Size(100, 21);
            this.host_txtEd.TabIndex = 1;
            // 
            // port_txtLb
            // 
            this.port_txtLb.Location = new System.Drawing.Point(215, 0);
            this.port_txtLb.Name = "port_txtLb";
            this.port_txtLb.Size = new System.Drawing.Size(100, 23);
            this.port_txtLb.TabIndex = 2;
            this.port_txtLb.Text = "Port";
            // 
            // port_txtEd
            // 
            this.port_txtEd.Location = new System.Drawing.Point(321, 3);
            this.port_txtEd.Name = "port_txtEd";
            this.port_txtEd.Size = new System.Drawing.Size(100, 21);
            this.port_txtEd.TabIndex = 3;
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(427, 3);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(100, 23);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(10, 120);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(541, 16);
            this.line.TabIndex = 1;
            // 
            // topicMessageBox
            // 
            this.topicMessageBox.Controls.Add(this.topicBox);
            this.topicMessageBox.Controls.Add(this.messageBox);
            this.topicMessageBox.Location = new System.Drawing.Point(10, 140);
            this.topicMessageBox.Name = "topicMessageBox";
            this.topicMessageBox.Size = new System.Drawing.Size(531, 71);
            this.topicMessageBox.TabIndex = 2;
            // 
            // topicBox
            // 
            this.topicBox.Controls.Add(this.tpc_txtLb);
            this.topicBox.Controls.Add(this.tpc_txtEd);
            this.topicBox.Controls.Add(this.sub_btn);
            this.topicBox.Location = new System.Drawing.Point(0, 0);
            this.topicBox.Name = "topicBox";
            this.topicBox.Size = new System.Drawing.Size(531, 23);
            this.topicBox.TabIndex = 0;
            // 
            // tpc_txtLb
            // 
            this.tpc_txtLb.Location = new System.Drawing.Point(3, 0);
            this.tpc_txtLb.Name = "tpc_txtLb";
            this.tpc_txtLb.Size = new System.Drawing.Size(100, 23);
            this.tpc_txtLb.TabIndex = 0;
            this.tpc_txtLb.Text = "Topic";
            // 
            // tpc_txtEd
            // 
            this.tpc_txtEd.Location = new System.Drawing.Point(109, 3);
            this.tpc_txtEd.Name = "tpc_txtEd";
            this.tpc_txtEd.Size = new System.Drawing.Size(200, 21);
            this.tpc_txtEd.TabIndex = 1;
            // 
            // sub_btn
            // 
            this.sub_btn.Location = new System.Drawing.Point(0, 0);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(75, 23);
            this.sub_btn.TabIndex = 2;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(0, 0);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(200, 100);
            this.messageBox.TabIndex = 1;
            // 
            // textbrowser
            // 
            this.textbrowser.Location = new System.Drawing.Point(291, 170);
            this.textbrowser.Name = "textbrowser";
            this.textbrowser.Size = new System.Drawing.Size(100, 96);
            this.textbrowser.TabIndex = 3;
            this.textbrowser.Text = "";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(85, 243);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 4;
            // 
            // msg_txtLb
            // 
            this.msg_txtLb.Location = new System.Drawing.Point(0, 0);
            this.msg_txtLb.Name = "msg_txtLb";
            this.msg_txtLb.Size = new System.Drawing.Size(100, 23);
            this.msg_txtLb.TabIndex = 0;
            // 
            // msg_txtEd
            // 
            this.msg_txtEd.Location = new System.Drawing.Point(0, 0);
            this.msg_txtEd.Name = "msg_txtEd";
            this.msg_txtEd.Size = new System.Drawing.Size(100, 21);
            this.msg_txtEd.TabIndex = 0;
            // 
            // pub_btn
            // 
            this.pub_btn.Location = new System.Drawing.Point(0, 0);
            this.pub_btn.Name = "pub_btn";
            this.pub_btn.Size = new System.Drawing.Size(75, 23);
            this.pub_btn.TabIndex = 0;


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.id_txtLb);
            this.Controls.Add(this.textbrowser);
            this.Controls.Add(this.close_btn);
            this.Name = "mqtt_messenger";
            this.Text = "Messenger";
            this.groupBox.ResumeLayout(false);
            this.connectingBox.ResumeLayout(false);
            this.idPwBox.ResumeLayout(false);
            this.idPwBox.PerformLayout();
            this.hostPortBox.ResumeLayout(false);
            this.hostPortBox.PerformLayout();
            this.topicMessageBox.ResumeLayout(false);
            this.topicBox.ResumeLayout(false);
            this.topicBox.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
    }
}

