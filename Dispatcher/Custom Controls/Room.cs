using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher.Custom_Controls
{
    public class Room : System.Windows.Forms.Button
    {
        public static mainForm mf;
        public static System.Windows.Forms.Button previousClickButton;
        public static System.Windows.Forms.Button previousMoveButton;
        public static Custom_Controls.PersonControl personControl;
        public  String roomNumber;
        public String roomName;
        public  DateTime creatTime;
        public DateTime StartTime;
        public int maxPersonOfNumber;
        public int currentNumberOfPerson;
        public String managerPassword;
        public String comperePassword;
        public String enterPassword;
        public String listeningPassword;
        public int level;
        public String imageName;
     //   public System.Windows.Forms.Button roomButton;
        public List<Person> personOfRoom=new List<Person>();
        public int stuts;
        public int addModel;
        public int leavelModel;
        public bool meetClicked=false;
        public bool meetLocked=false;
        public bool meetDormancy = false;
        public  System.Drawing.Image getImage(){
            if (imageName==null)
            return System.Drawing.Image.FromFile("../../images/" + imageName);
            else return System.Drawing.Image.FromFile("../../images/defaultrooms.bmp");
        }
        public String getRoomtext(){
          
          //  MessageBox.Show(roomNumber, "ss");
            if (Convert.ToInt32(roomNumber)==0)
            {
                return "      大厅";
            }
            if (roomName != null)
            {
                return roomNumber + "------->" + roomName;
            }else  return roomNumber + "------->" + roomNumber;
        }
        public Room(String roomNumber, String imageName) :base(){
            
            this.roomNumber = roomNumber;
            this.imageName = imageName;
            initRoomButton();
        }
        public Room(String roomNumber, String roomName, String imageName) : base()
        {
            this.roomNumber = roomNumber;
            this.imageName = imageName;
            this.roomName = roomName;
            initRoomButton();
        }
        #region  房间事件
        public void initRoomButton(){
          //  this = new System.Windows.Forms.Button();
            this.Click +=buttonClick;
            this.MouseMove+= buttonMove;
           this.DragEnter +=personDragEnter;
            this.DragDrop += personDragDrop;
           // this.DragLeave += personDragDrop;
         //   this.DragDrop += person2ThisButton;
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Image =getImage();
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Location = new System.Drawing.Point(0, 330);
            this.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Name = roomNumber;
            this.Size = new System.Drawing.Size(232, 55);
            this.Text = "休息区";
            if (roomNumber.Trim()!="") {    
                this.TabIndex = System.Convert.ToInt32(roomNumber);
                this.Text = getRoomtext();
            }
           
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UseVisualStyleBackColor = true;
            this.AllowDrop = true;
        }

        
        //房间单击选中
        public void buttonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (previousMoveButton != null)
            {
                previousMoveButton.BackColor = System.Drawing.Color.Transparent;
                previousMoveButton =null;
            }
            if (previousClickButton != null)
            {
                previousClickButton.BackColor = System.Drawing.Color.Transparent;
            }
            //作更新房间的人的事
            Room.personControl.showPerson(this);
                previousClickButton = button;
            button.BackColor = System.Drawing.SystemColors.Highlight;
       }
        //鼠标移动到房间上
        public void buttonMove(object sender, EventArgs e){
            Button button = sender as Button;
            if (button.Equals(previousClickButton)) 
                return;
            if (previousMoveButton != null)
            {
                previousMoveButton.BackColor = System.Drawing.Color.Transparent;
            }
            previousMoveButton = button;
            button.BackColor = System.Drawing.Color.Aquamarine; 
    }

        //拖动到这个房间的进入
        public void personDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            
         //  MessageBox.Show("进入了？","mb");
   
        }
        //拖动到这个房间的完成
        public void personDragDrop(object sender, DragEventArgs e)
        {
          //  e.Effect = DragDropEffects.Move;
            Button button = sender as Button;
      
            System.Windows.Forms.DataObject ido = e.Data as System.Windows.Forms.DataObject;
         
            Person person = new Person(); 
            person = ido.GetData(person.GetType()) as Person;
      
        // MessageBox.Show(person.getNoteName(), "测试");
           
        }
        #endregion
        #region  房间右键菜单
        //房间右键按钮菜单
        public System.Windows.Forms.ToolStripItem[] creatItem() {            
            //创建会议
            System.Windows.Forms.ToolStripMenuItem meetingOpen = new System.Windows.Forms.ToolStripMenuItem();
            meetingOpen.Name = "meetingOpen";
            meetingOpen.Text = "创建会议室";
            meetingOpen.Size = new System.Drawing.Size(200, 20);
            meetingOpen.Enabled = true;
            meetingOpen.Click += meetingOpenClick;
            //会议关闭
            System.Windows.Forms.ToolStripMenuItem meetingClose = new System.Windows.Forms.ToolStripMenuItem();
            meetingClose.Name = "meetingClose";
            meetingClose.Text = "关闭会议室";
            meetingClose.Size = new System.Drawing.Size(200, 20);
            //会议加锁
            System.Windows.Forms.ToolStripMenuItem meetingLock = new System.Windows.Forms.ToolStripMenuItem();
            meetingLock.Name = "meetingLock";
            meetingLock.Text = "锁定会议";
            meetingLock.Size = new System.Drawing.Size(200, 20);
            //解锁
            System.Windows.Forms.ToolStripMenuItem meetingUnlock = new System.Windows.Forms.ToolStripMenuItem();
            meetingUnlock.Name = "meetingUnlock";
            meetingUnlock.Text = "解锁会议";
            meetingUnlock.Size = new System.Drawing.Size(200, 20);
            //休眠会议
            System.Windows.Forms.ToolStripMenuItem meetingDormancy = new System.Windows.Forms.ToolStripMenuItem();
            meetingDormancy.Name = "meetingDormancy";
            meetingDormancy.Text = "休眠会议";
            meetingDormancy.Size = new System.Drawing.Size(200, 20);
            //会议激活
            System.Windows.Forms.ToolStripMenuItem meetingActive= new System.Windows.Forms.ToolStripMenuItem();
            meetingActive.Name = "meetingActive";
            meetingActive.Text = "激活会议";
            meetingActive.Size = new System.Drawing.Size(200, 20);
            //分割线
            System.Windows.Forms.ToolStripSeparator ToolStripSeparator1= new System.Windows.Forms.ToolStripSeparator();
            //设置会议最大人数
           System.Windows.Forms.ToolStripMenuItem  setMeetMaxPerson=new System.Windows.Forms.ToolStripMenuItem();
           setMeetMaxPerson.Name = "setMeetMaxPerson";
           setMeetMaxPerson.Text = "设置会议室最大人数";
           setMeetMaxPerson.Size = new System.Drawing.Size(200, 20);
            //设置会议密码
           System.Windows.Forms.ToolStripMenuItem setMeetPassword = new System.Windows.Forms.ToolStripMenuItem();
           setMeetPassword.Name = "setMeetPassword";
           setMeetPassword.Text = "设置会议室密码";
           setMeetPassword.Size = new System.Drawing.Size(200, 20);
           setMeetPassword.Click += this.setMeetPasswordClick;



           System.Windows.Forms.ToolStripItem[] item = new System.Windows.Forms.ToolStripItem[] { 
               meetingOpen,
               meetingClose,
               meetingUnlock,
               meetingLock,
               meetingDormancy,
               meetingActive,
               ToolStripSeparator1,
               setMeetMaxPerson,
               setMeetPassword
           };
            
            return item;
        }

        //房间右键菜单添加房间事件
        public void meetingOpenClick(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem meetingOpen = sender as System.Windows.Forms.ToolStripMenuItem;
            Room roomTemp = new Room("0001", "大厅1", "rooms.bmp");
            //mf.panel2AddRoom(roomTemp);
          //  MessageBox.Show(this.roomName, "ssd");
        }
        public void meetingClose(object sender, EventArgs e) {
      
        }
        public void meetingUnlock(object sender, EventArgs e) { }
        public void meetingLock(object sender, EventArgs e) { }
        public void meetingDormancy(object sender, EventArgs e) { }
        public void meetingActive(object sender, EventArgs e) { }
        public void setMeetMaxPerson(object sender, EventArgs e) { }
        public DialogBox pwdb;
        
        public void setMeetPasswordClick(object sender, EventArgs e)
        {
            if (pwdb == null)
                pwdb = new DialogBox();
            pwdb.Text = "修改会议室信息-----房号:" + this.roomNumber;
           // if (pwdb.Controls.Find("PassWordDialogBox", true).Length==0) {MessageBox.Show("das", "ss"); }
            PassWordDialogBox pwdbc = pwdb.Controls.Find("passWordDialogBoxPanel", true)[0] as PassWordDialogBox;
        //   MessageBox.Show(pwdbc.Controls.Find("roomInfoSubmit", true)[0], "呵呵");
          Button submitButton= pwdbc.Controls.Find("roomInfoSubmit", true)[0] as Button;
          submitButton.Text = "修改";
          submitButton.Click += submitButton_Click;
          Button cancelButton = pwdbc.Controls.Find("cancelButton", true)[0] as Button;
          cancelButton.Text = "取消";

          //queryRoomInfo();
           TextBox tbrn= pwdbc.Controls.Find("roomNameText", true)[0] as TextBox ;
           tbrn.Text = this.roomName;
           TextBox tbpw = pwdbc.Controls.Find("managerPasswordBox", true)[0] as TextBox;
           tbpw.Text = "管理密码";
           TextBox tbcpb = pwdbc.Controls.Find("comperePasswordBox", true)[0] as TextBox;
           tbcpb.Text = "默认值";
           TextBox tbepb = pwdbc.Controls.Find("enterPasswordBox", true)[0] as TextBox;
           tbepb.Text = "进入的密码";
           TextBox tblpb = pwdbc.Controls.Find("listeningPasswordBox", true)[0] as TextBox;
           tblpb.Text = "旁听密码";
           TextBox tbmponb = pwdbc.Controls.Find("maxPersonOfNumbertextBox", true)[0] as TextBox;
           tbmponb.Text = "最大人数";
            
           
          //  MessageBox.Show(this.roomNumber,"ss");
           pwdb.ShowDialog();
          //  pwdb.Show();
         /*  System.Threading.Thread t = new System.Threading.Thread(DialBoxThread);
           Control.CheckForIllegalCrossThreadCalls = false;
              t.Start();
          */
            //  MessageBox.Show("xxx","呵呵");
           
            /*
            DialogBox pwdb = new DialogBox();
             pwdb.ShowDialog();
             mf.Visible = false;
             mf.Show(pwdb);
        */
            //pwdb.TopMost = true;
            
          
        }
        private void updataOrCreateRoomToServer() {}
        private void submitButton_Click(object sender, EventArgs e)
        {
            PassWordDialogBox pwdbc = pwdb.Controls.Find("passWordDialogBoxPanel", true)[0] as PassWordDialogBox;
            TextBox tbrn = pwdbc.Controls.Find("roomNameText", true)[0] as TextBox;
            tbrn.Text = this.roomName;
            TextBox tbpw = pwdbc.Controls.Find("managerPasswordBox", true)[0] as TextBox;
            tbpw.Text = "管理密码";
            TextBox tbcpb = pwdbc.Controls.Find("comperePasswordBox", true)[0] as TextBox;
            tbcpb.Text = "默认值";
            TextBox tbepb = pwdbc.Controls.Find("enterPasswordBox", true)[0] as TextBox;
            tbepb.Text = "进入的密码";   
            TextBox tblpb = pwdbc.Controls.Find("listeningPasswordBox", true)[0] as TextBox;
            tblpb.Text = "旁听密码";
            TextBox tbmponb = pwdbc.Controls.Find("maxPersonOfNumbertextBox", true)[0] as TextBox;
            tbmponb.Text = "最大人数";

        }
   
        public void DialBoxThread()
        {
            DialogBox pwdb = new DialogBox();
            pwdb.ShowDialog();
            //mf.Visible = false;
            //mf.Show(pwdb);
          //  DialogBox pwdb = new DialogBox();

            //pwdb.ShowDialog();
            //mf.Visible = false;
            //pwdb.Show();
            // pwdb.Visible = false;
            //    pwdb.TopMost = true;
            //   pwdb.ShowDialog();
            //mf.Show(pwdb);
            // pwdb.Hide();
        }
        #endregion  
    }
}
