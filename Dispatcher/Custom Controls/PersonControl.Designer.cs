using System.Collections.Generic;
using System.Windows.Forms;
namespace Dispatcher.Custom_Controls
{
    partial class PersonControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.SuspendLayout();
           
            //标题栏的样式
            System.Windows.Forms.DataGridViewCellStyle dataGridViewHeaderCellStyle = new System.Windows.Forms.DataGridViewCellStyle();           
            dataGridViewHeaderCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewHeaderCellStyle.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewHeaderCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewHeaderCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewHeaderCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewHeaderCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerson.ColumnHeadersDefaultCellStyle = dataGridViewHeaderCellStyle;
            // 
            // dataGridViewPerson
            // 
          
            this.dataGridViewPerson.AllowUserToAddRows = false;
            this.dataGridViewPerson.AllowUserToDeleteRows = false;
            this.dataGridViewPerson.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.name,
            this.phoneNumber,
            this.chanel});
            this.dataGridViewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerson.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPerson.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.AllowDrop = true;
            this.dataGridViewPerson.ReadOnly = true;
            this.dataGridViewPerson.RowHeadersVisible = false;
            this.dataGridViewPerson.RowTemplate.Height = 23;
            this.dataGridViewPerson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPerson.ShowEditingIcon = false;
            this.dataGridViewPerson.Size = new System.Drawing.Size(380, 560);
            this.dataGridViewPerson.TabIndex = 0;
          //  this.dataGridViewPerson.MouseMove += mouseOver;
            //this.dataGridViewPerson.dr;
            // 
            // Status
            // 
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "名字";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "电话号码";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Width = 150;
            // 
            // chanel
            // 
            this.chanel.HeaderText = "通道号";
            this.chanel.Name = "chanel";
            this.chanel.ReadOnly = true;
            this.chanel.Width = 80;
            // 
            // personRightClick
            // 
            
            this.components = new System.ComponentModel.Container();
            this.personRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personRightClick.AllowDrop = true;
            this.personRightClick.Name = "personRightClick";
            this.personRightClick.ShowImageMargin = false;
            this.personRightClick.Size = new System.Drawing.Size(36, 4);           
            

            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dataGridViewPerson);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(380, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.ResumeLayout(false);
          
        }

        #endregion

       //  Room r = new Room("001", "rooms.bmp");
         //   r.personOfRoom = new List<Person>() { new Person("001",r,"13419506744"), new Person("002", r,"18627283312") };
           // showPerson(r);
        public void showPerson(Room r)
        {
            if( dataGridViewPerson.Rows.Count!=0){
                dataGridViewPerson.Rows.Clear();
            }
            if (r.personOfRoom == null || r.personOfRoom.Count==0)
            {

                return;
            }
           persons=r.personOfRoom;
           // 
           // dataGridView1
           // 
           DataGridViewRow dr;
      
              for (int i = 0; i < persons.Count; i++)
               {
                   dr = persons[i];
             //添加右键事件
                  if (personRightClick.Items != null)
               {
                   personRightClick.Items.Clear();
               }
               personRightClick.Items.AddRange(persons[i].creatItem()); 
               dr.ContextMenuStrip = personRightClick;
                  //添加到面板中
              
               dataGridViewPerson.Rows.Add(dr);
                 }
              dataGridViewPerson.CellMouseMove += cellMouseMove;
            // dataGridViewPerson.CellMouseLeave += cellMouseLeave;
        }

        private void cellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridView DataGridViePerson = sender as DataGridView;
           if (DataGridViePerson.Rows[e.RowIndex].Selected == true) return;
           DataGridViePerson.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
        }


        public void cellMouseMove(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
           // System.Windows.Forms.DataGridViewRow previousMoveRow;
            if (e.RowIndex < 0)
                return;
            
            DataGridView DataGridViePerson = sender as DataGridView;
        
           // DataGridViePerson.Rows[e.RowIndex].Selected =true;

            //鼠标移动到上面拖动代码 
           // Person p = DataGridViePerson.Rows[e.RowIndex] as Person;
            if (e.Button == MouseButtons.Left)
                  DataGridViePerson.DoDragDrop(DataGridViePerson.Rows[e.RowIndex], DragDropEffects.All);

           // DataGridViePerson.DoDragDrop(p, DragDropEffects.All);
            //鼠标移动拖动结束代码
           if (DataGridViePerson.Rows[e.RowIndex].Selected == true)return;
           if (Person.previousMoveRow != null)
           {
               Person.previousMoveRow.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               
           }
           Person.previousMoveRow = DataGridViePerson.Rows[e.RowIndex];
           DataGridViePerson.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            //变色结束
      
        }
      
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn chanel;
        private List<Person> persons;
        private System.Windows.Forms.ContextMenuStrip personRightClick;
    }
}
