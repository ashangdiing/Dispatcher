using Dispatcher.Custom_Controls;
using System.Collections.Generic;
using System.Windows.Forms.Samples;
namespace Dispatcher
{
    partial class mainForm
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogBox_FormClosed);
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainerZhenTI = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.roomRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerZhenTI)).BeginInit();
            this.splitContainerZhenTI.Panel1.SuspendLayout();
            this.splitContainerZhenTI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.AllowDrop = true;
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.Color.Red;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainerZhenTI);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(924, 509);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(924, 534);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.White;
            // 
            // splitContainerZhenTI
            // 
            this.splitContainerZhenTI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerZhenTI.Location = new System.Drawing.Point(0, 0);
            this.splitContainerZhenTI.Name = "splitContainerZhenTI";
            // 
            // splitContainerZhenTI.Panel1
            // 
            this.splitContainerZhenTI.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerZhenTI.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainerZhenTI.Panel2
            // 
            this.splitContainerZhenTI.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerZhenTI.Size = new System.Drawing.Size(924, 509);
            this.splitContainerZhenTI.SplitterDistance = 249;
            this.splitContainerZhenTI.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AllowDrop = true;
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Size = new System.Drawing.Size(380, 560);
            this.splitContainer2.SplitterDistance = 254;
            this.splitContainer2.TabIndex = 0;

            // 
            // personControl1
            // 

            this.personControl1 = new Dispatcher.Custom_Controls.PersonControl();
            this.personControl1.AutoScroll = true;
            this.personControl1.Location = new System.Drawing.Point(1, 3);
            this.personControl1.Name = "personControl1";
            this.personControl1.Size = new System.Drawing.Size(380, 560);
            this.personControl1.TabIndex = 0;
            this.splitContainerZhenTI.Panel2.Controls.Add(personControl1);
            // 
            // roomRightClick
            // 
            this.roomRightClick.AllowDrop = true;
            this.roomRightClick.Name = "roomRightClick";
            this.roomRightClick.ShowImageMargin = false;
            this.roomRightClick.Size = new System.Drawing.Size(36, 4);


         
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 534);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "mainForm";
            this.Text = "调度系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainerZhenTI.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerZhenTI)).EndInit();
            this.splitContainerZhenTI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            Dispatcher.Custom_Controls.Room.mf = this;
            roomRightClick.Opening += roomRightClick_Opening;
          //  roomRightClick.Opened+=roomRightClick_Opened;
          /*
            Room cacheRoom = new Room("     ", "大厅", "rooms.bmp");
            cacheRoom.personOfRoom = new List<Person>() { new Person("001", cacheRoom, "13419506744"), new Person("002", cacheRoom, "18627283312") };
           
            
            Room cacheRoom1 = new Room("0003", "大厅2", "rooms.bmp");
            cacheRoom1.personOfRoom = new List<Person>() { new Person("004", cacheRoom1, "12312231"), new Person("005", cacheRoom1, "56876777"), new Person("003", cacheRoom, "sdaasd") };
            Room cacheRoom3 = new Room("0004", "大厅3", "rooms.bmp");
            cacheRoom3.personOfRoom = new List<Person>() { };
           
            panel2AddRoom(cacheRoom);
            panel2AddRoom(cacheRoom3);
            panel2AddRoom(cacheRoom1);
           */
            updataRoomFromDB();
            initEsunnetMeet();
        }

        private void initEsunnetMeet()
        {
            if (esunnetX != null && esunnetX.IsConnect)
            esunnetX.CREATEGROUPMEETING+=getMeetingInfoEvent;
        }

        private void getMeetingInfoEvent(int roomid, string called, string adminpwd, string djpwd, string saypwd, string listenpwd, int addflag, int leaveflag, int maxcount, int roomstatus, string owner, string callid)
        {
            
        }

   
        #endregion
        /*
        Room cacheRoom = new Room("0000", "大厅", "rooms.bmp");
            panel2AddRoom(cacheRoom);
        
        */
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainerZhenTI;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button roomButton;
        private List<Room> rooms=new List<Room>();
        private Room[] RA;
        public void updataRoomFromDB(){
          
            Room cacheRoom;
            /* 
           cacheRoom = new Room("", "大厅", "rooms.bmp");
           cacheRoom.personOfRoom = new List<Person>() { new Person("001", cacheRoom, "13419506744"), new Person("002", cacheRoom, "18627283312") };
           this.splitContainer2.Panel2.Controls.Add(cacheRoom);
           rooms.Add(cacheRoom);
           * */
            System.Util.DataBase db=Login.db;
            if (!db.init())
            {
                System.Windows.Forms.MessageBox.Show("登陆失败", "数据库访问失败....请检查数据库配置");
                return;
            }
           // db.command.Parameters.Add("@AgentID", System.Data.SqlDbType.NChar);
            //db.command.Parameters["@AgentID"].Value = this.agent;
            //查询所有数据库有的房间信息
            System.Data.SqlClient.SqlDataReader roomInfo = db.queryData("SELECT  g.[GROUPID] ,[GROUPEXT] ,[GROUPNAME],[adminpwd],[djpwd],[saypwd],[listenpwd],[AddFalg],[LeaveFlag],[groupright],[PASSWORD],[MaxCount],ga.USERID FROM MIT_T_GROUP as g left join MIT_T_GROUP_ADMIN ga on g.GROUPID=ga.GROUPID  order by GROUPID desc ");
            if (!roomInfo.HasRows) return;

            while (roomInfo.Read())
            {
             cacheRoom = new Room(roomInfo["GROUPID"].ToString(), roomInfo["GROUPNAME"].ToString(), "rooms.bmp");
             this.splitContainer2.Panel2.Controls.Add(cacheRoom);
               rooms.Add(cacheRoom);
            }


           RA = new Room[rooms.Count];
          // System.Windows.Forms.MessageBox.Show(RA.Length.ToString(), "ss");
           db.closeDataBase();
            //查询房间的人的信息
           db.command.Parameters.Add("@GROUPID", System.Data.SqlDbType.NChar);
            foreach(Room r in rooms){
                int i = 0; RA[i] = r;
                //添加右键
                r.ContextMenuStrip = roomRightClick;               
                db.command.Parameters["@GROUPID"].Value =r.roomNumber;
                System.Data.SqlClient.SqlDataReader personInfo = db.queryData("SELECT m.[MEMBERID] ,[MEMBEREXT] ,[MEMBERNAME],[sex],[CTILINE],[extline],[dept],[msequence],[email],[fax],[mobile],gm.GROUPID,gm.STATUS,gm.sequence FROM [Esunnet].[dbo].[MIT_T_MEMBER] m left join MIT_T_GROUPMEMBER gm on m.MEMBERID=gm.MEMBERID where gm.GROUPID=@GROUPID");
                if (!personInfo.HasRows) {
                    db.closeDataBase();
                    continue; }
                while (personInfo.Read())
                {
                  
                    r.personOfRoom.Add(new Person(personInfo["extline"].ToString(), personInfo["MEMBERNAME"].ToString(), personInfo["mobile"].ToString(), r));
                    //添加房间的人的事

                    if (Room.personControl == null)
                    {
                        Room.personControl = personControl1;
                        personControl1.showPerson(r);
                    }
                }
                db.closeDataBase();
            }
            panel2AddRoom();
        }
        public void panel2AddRoom() {
         
         
            //   右键菜单打开之前需要查询状态
          //  this.splitContainer2.Panel2.Controls.Add(r);
           //System.Windows.Forms.MessageBox.Show(RA.Length.ToString(),"ss");
            //this.splitContainer2.Panel2.Controls.AddRange(RA);        
        }

        private void roomRightClick_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            System.Windows.Forms.ContextMenuStrip cms = sender as System.Windows.Forms.ContextMenuStrip;
          Room r=cms.SourceControl as Room;
        //  System.Windows.Forms.MessageBox.Show(System.Convert.ToString(r.creatItem().Length), "ss");
         // if (roomRightClick.Items != null){ }
           
            roomRightClick.Items.Clear();
            roomRightClick.Items.AddRange(r.creatItem());
            e.Cancel = false;//为true时不会出现了就马上消失了
         //   roomRightClick.Items.Clear();
         //  System.Windows.Forms.MessageBox.Show(System.Convert.ToString(r.creatItem().Length), "ss");
        }

        public void panel2UpdataRoom(Room r)
        {
            this.roomButton = r;       
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roomButton.Image = r.getImage();
            this.roomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomButton.Location = new System.Drawing.Point(0, 330);
            this.roomButton.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.roomButton.Name = r.getRoomtext();
            this.roomButton.Size = new System.Drawing.Size(232, 55);
            this.roomButton.TabIndex = System.Convert.ToInt32(r.roomNumber);
            this.roomButton.Text = r.getRoomtext();
            this.roomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomButton.UseVisualStyleBackColor = true;
        }
        public void panel2RemoveRoom(Room r) {            
            this.splitContainer2.Panel2.Controls.Remove(r);
        
        }
     
        private System.Windows.Forms.ContextMenuStrip roomRightClick;
        private Custom_Controls.PersonControl personControl1;
      //  public  EsunnetX.MainFormClass esunnetX;
    }
}