using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private GroupBox groupBox;
        private Panel connectingBox;
        private FlowLayoutPanel idPwBox;
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

        public Form1()
        {
            InitializeComponent();
        }
     
        public void button1_Click()
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
