using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher.Custom_Controls
{
    public class Person : System.Windows.Forms.DataGridViewRow
    {
        public static System.Windows.Forms.DataGridViewRow previousMoveRow;
        public String phoneNumber;
        public String noteName;
        public String channel;
        public String imageName;
        public Room room;
        public int channelStatus;
        public System.Windows.Forms.DataGridViewRow dr;

        DataGridViewImageCell DGVTBCimage;
        DataGridViewTextBoxCell DGVTBCPH;
        DataGridViewTextBoxCell DGVTBCnoteName;
        DataGridViewTextBoxCell DGVTBCchannel;
        public System.Drawing.Image getImage()
        {
            if (imageName!= null)
                return System.Drawing.Image.FromFile("../../images/" + imageName);
            else return System.Drawing.Image.FromFile("../../images/defaultpersons.bmp");
        }
       public String getNoteName(){
           if (noteName != null) { return noteName;}
           else return phoneNumber;
       }
        
       #region  通道右键菜单
       public System.Windows.Forms.ToolStripItem[] creatItem()
       {
           //添加一个会议人
           System.Windows.Forms.ToolStripMenuItem addMeeter = new System.Windows.Forms.ToolStripMenuItem();
           addMeeter.Name = "addMeeter";
           addMeeter.Text = "添加会议员";
           addMeeter.Size = new System.Drawing.Size(200, 20);
           addMeeter.Enabled = true;

           //挂断
           System.Windows.Forms.ToolStripMenuItem dropMeeter = new System.Windows.Forms.ToolStripMenuItem();
           dropMeeter.Name = "dropMeeter";
           dropMeeter.Text = "挂断呼叫";
           dropMeeter.Size = new System.Drawing.Size(200, 20);
           dropMeeter.Enabled = true;


           //剔除会议室
           System.Windows.Forms.ToolStripMenuItem rejectMeeting = new System.Windows.Forms.ToolStripMenuItem();
           rejectMeeting.Name = "rejectMeeting";
           rejectMeeting.Text = "剔除会议室";
           rejectMeeting.Size = new System.Drawing.Size(200, 20);
           rejectMeeting.Enabled = true;

           //设为旁听
           System.Windows.Forms.ToolStripMenuItem set2manager = new System.Windows.Forms.ToolStripMenuItem();
           set2manager.Name = "set2manager";
           set2manager.Text = "设为管理员";
           set2manager.Size = new System.Drawing.Size(200, 20);
           set2manager.Enabled = true;

           //设为旁听
           System.Windows.Forms.ToolStripMenuItem set2compere = new System.Windows.Forms.ToolStripMenuItem();
           set2compere.Name = "set2compere";
           set2compere.Text = "设为主持";
           set2compere.Size = new System.Drawing.Size(200, 20);
           set2compere.Enabled = true;

           //设为旁听
           System.Windows.Forms.ToolStripMenuItem set2listening = new System.Windows.Forms.ToolStripMenuItem();
           set2listening.Name = "set2listening";
           set2listening.Text = "设为旁听";
           set2listening.Size = new System.Drawing.Size(200, 20);
           set2listening.Enabled = true;

           //设为参与
           System.Windows.Forms.ToolStripMenuItem set2enter = new System.Windows.Forms.ToolStripMenuItem();
           set2enter.Name = "set2enter";
           set2enter.Text = "设为参与";
           set2enter.Size = new System.Drawing.Size(200, 20);
           set2enter.Enabled = true;


           System.Windows.Forms.ToolStripItem[] item = new System.Windows.Forms.ToolStripItem[] { 
              addMeeter,
              dropMeeter,
              rejectMeeting,
              set2manager,
             set2compere ,
             set2listening,
             set2enter
           };

           return item;
       }
       #endregion  房间右键菜单
   

        public void initPersonRow(){
            DGVTBCimage = new DataGridViewImageCell(); 
            DGVTBCPH = new DataGridViewTextBoxCell();
               DGVTBCnoteName = new DataGridViewTextBoxCell();
                 DGVTBCchannel = new DataGridViewTextBoxCell();
               DGVTBCimage.Value =getImage();
               DGVTBCPH.Value =phoneNumber;
               DGVTBCnoteName.Value =getNoteName();
               DGVTBCchannel.Value =channel;
              this.Cells.AddRange(new DataGridViewCell[]{
              DGVTBCimage,
              DGVTBCnoteName,
              DGVTBCPH,           
              DGVTBCchannel
        });
         
        }

        public Person(String channel, String noteName, Room room)
            : base()
        {           
           this.channel = channel;
            this.noteName = noteName;
           this.room = room;
           initPersonRow();
       }
        public Person(String channel, String noteName,string p, Room room)
            : base()
        {
            this.channel = channel;
            this.noteName = noteName;
            this.phoneNumber = p;
            this.room = room;
            initPersonRow();
        }
       public Person(String channel, Room room,String phoneNumber) : base() {         
           this.phoneNumber = phoneNumber;
           this.channel = channel;         
           this.room = room;
           initPersonRow();
       }

       public Person()
       {
           // TODO: Complete member initialization
       }
       public void mouseOver(object sender, System.EventArgs e)
       {
           Person personRow = sender as Person;
           personRow.Selected = true;

       }
    }

}
