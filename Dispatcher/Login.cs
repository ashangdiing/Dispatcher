
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Samples;
namespace Dispatcher
{
    public partial class Login : Form
    {
        Dispatcher.mainForm mf;
        public static System.Util.DataBase db;
        EsunnetX.MainFormClass esunnetX;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.label2.Text = "        logining.......   Please wait ";
            loginHandel();
        //    MessageBox.Show("ss", "kon");
            if (!loginReadDB()) {
                MessageBox.Show("登陆失败","数据库访问失败....请检查数据库配置");
                return;    
            }
            db.command.Parameters.Add("@AgentID",SqlDbType.NChar);
            db.command.Parameters["@AgentID"].Value = this.agent;
            System.Data.SqlClient.SqlDataReader userInfo = db.queryData("SELECT  * FROM [Esunnet].[dbo].[TS_ADMIN] where TS_ADMIN_ID=@AgentID");
           if (!userInfo.HasRows)
           {
               MessageBox.Show("用户名不存在", "警告");
             return ;}
           userInfo.Read();
           string PWFromDB = userInfo["TS_PASSWORD"].ToString();
           db.closeDataBase();
           if (!PWFromDB.Equals(agentPassword)) {
               MessageBox.Show("密码错误","警告");
               return;
           }
          
          
            esunnetX = new EsunnetX.MainFormClass();
             
            esunnetX.EsunnetMetConnect(meetServIP,int.Parse(meetServPort));
            if (esunnetX.IsConnect) {
                esunnetX.ConnectReady += esunnetX_ConnectReady;
            }
            
            this.Visible = false;
            mf = new Dispatcher.mainForm();
          //  mf.Owner = this;
            mf.ShowDialog();
          //  this.Show(mf);
        }
        

        private void esunnetX_ConnectReady()
        {      
            esunnetX.EsunnetLogin(agent);
           mf.esunnetX=esunnetX;   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // 关闭
        private void process1_Exited(object sender, EventArgs e)
        {
            this.label2.Text = "++++";
           
        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            if(esunnetX!=null){
                esunnetX.EsunnetMetShutdown();
            }
            this.Close();
        }
        public void loginHandel()
        {
            this.agent = this.agentTextBox.Text;
            this.agentPassword =this. agentPasswordTextBox.Text;
            this.dataBaseType = this.DBTypeComboBox.ValueMember;
            this.dataBaseServerIP = this.DBServerIPTextBox.Text;
            this.dataBaseUser = this.DBUserTextBox.Text;
            this.dataBasePassword = this.DBPasswordTextBox.Text;
            this.meetServIP = this.meetServIPTextBox.Text;
            this.meetServPort = this.meetServPortTextBox.Text;
            this.dataBase = this.DBTextBox.Text;
        }
        public bool loginReadDB(){
            db = new System.Util.DataBase(dataBaseServerIP, dataBase, dataBaseUser, dataBasePassword);  
            return db.init();
        }
    }
}
