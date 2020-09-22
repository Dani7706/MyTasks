using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyTasks
{
    partial class MyTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTasks));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.taskTabControl = new System.Windows.Forms.TabControl();
            this.workTabPage = new System.Windows.Forms.TabPage();
            this.homeTabPage = new System.Windows.Forms.TabPage();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.personalTabPage = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.taskTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1082, 100);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(181, 27);
            this.toolStripButton1.Text = "Add to My Work Tasks";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(159, 27);
            this.toolStripButton2.Text = "Add New WorkTask";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(188, 27);
            this.toolStripButton3.Text = "Add to My Home Tasks";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(171, 27);
            this.toolStripButton4.Text = "Add New Home Task";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(206, 27);
            this.toolStripButton5.Text = "Add to My Personal Tasks";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(189, 27);
            this.toolStripButton6.Text = "Add New Personal Task";
            // 
            // taskTabControl
            // 
            this.taskTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskTabControl.Controls.Add(this.workTabPage);
            this.taskTabControl.Controls.Add(this.homeTabPage);
            this.taskTabControl.Controls.Add(this.personalTabPage);
            this.taskTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTabControl.Location = new System.Drawing.Point(0, 70);
            this.taskTabControl.Name = "taskTabControl";
            this.taskTabControl.SelectedIndex = 0;
            this.taskTabControl.Size = new System.Drawing.Size(1082, 457);
            this.taskTabControl.TabIndex = 1;
            // 
            // workTabPage
            // 
            this.workTabPage.AutoScroll = true;
            this.workTabPage.Location = new System.Drawing.Point(4, 34);
            this.workTabPage.Name = "workTabPage";
            this.workTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.workTabPage.Size = new System.Drawing.Size(1074, 419);
            this.workTabPage.TabIndex = 0;
            this.workTabPage.Text = "Work Tasks";
            this.workTabPage.UseVisualStyleBackColor = true;
            // 
            // homeTabPage
            // 
            this.homeTabPage.AutoScroll = true;
            this.homeTabPage.Controls.Add(this.domainUpDown2);
            this.homeTabPage.Location = new System.Drawing.Point(4, 34);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.homeTabPage.Size = new System.Drawing.Size(1074, 419);
            this.homeTabPage.TabIndex = 1;
            this.homeTabPage.Text = "Home Tasks";
            this.homeTabPage.UseVisualStyleBackColor = true;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainUpDown2.Location = new System.Drawing.Point(223, 98);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(362, 26);
            this.domainUpDown2.TabIndex = 0;
            this.domainUpDown2.Text = "domainUpDown2";
            // 
            // personalTabPage
            // 
            this.personalTabPage.AutoScroll = true;
            this.personalTabPage.Location = new System.Drawing.Point(4, 34);
            this.personalTabPage.Name = "personalTabPage";
            this.personalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.personalTabPage.Size = new System.Drawing.Size(1074, 419);
            this.personalTabPage.TabIndex = 2;
            this.personalTabPage.Text = "Personal Tasks";
            this.personalTabPage.UseVisualStyleBackColor = true;
            // 
            // MyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 539);
            this.Controls.Add(this.taskTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MyTasks";
            this.Text = "My Tasks";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.taskTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void MyInitialize()
        {


            domainUpDownsList = new List<DomainUpDown>();

            //readFile.Close();

            int x = 100;
            int y = 50;
            for (int i = 1; i <= 10; i++)
            {
                labelBox = new System.Windows.Forms.Label();
                labelBox.Location = new System.Drawing.Point(30, y);
                labelBox.Text = i.ToString();
                labelBox.Size = new System.Drawing.Size(40, 20);
                domainUpDown = new System.Windows.Forms.DomainUpDown();
                
                domainUpDown.Location = new System.Drawing.Point(x, y);
                domainUpDown.Name = "domainUpDown" + i;
                domainUpDown.Size = new System.Drawing.Size(500, 100);
                domainUpDown.AllowDrop = true;
                //domainUpDown.AutoSize = true;
                domainUpDown.TabIndex = i;
                domainUpDown.Text = "";
                domainUpDownsList.Add(domainUpDown);
                if (workTasks != null)
                {
                    domainUpDown.Items.AddRange(workTasks);
                }
                checkBox = new System.Windows.Forms.CheckBox();
                checkBox.Location = new System.Drawing.Point(650, y);
                checkBox.Checked = false;
                checkBox.Size = new System.Drawing.Size(20, 20);
                y += 50;
                workTabPage.Controls.Add(labelBox);
                workTabPage.Controls.Add(domainUpDown);
                workTabPage.Controls.Add(checkBox);
            }
        }

        private void HomeTasksInitialize()
        {
            domainUpDownsHomeList = new List<DomainUpDown>();

            //readFile.Close();

            int x = 100;
             int y = 50;
            for (int i = 1; i <= 10; i++)
            {
                labelBox = new System.Windows.Forms.Label();
                labelBox.Location = new System.Drawing.Point(30, y);
                labelBox.Text = i.ToString();
                labelBox.Size = new System.Drawing.Size(40, 20);
                domainUpDown = new System.Windows.Forms.DomainUpDown();
                
                domainUpDown.Location = new System.Drawing.Point(x, y);
                domainUpDown.Name = "domainUpDown" + i;
                domainUpDown.Size = new System.Drawing.Size(500, 100);
                domainUpDown.AllowDrop = true;
                //domainUpDown.AutoSize = true;
                domainUpDown.TabIndex = i;
                domainUpDown.Text = "";
                domainUpDownsHomeList.Add(domainUpDown);
                if (homeTasks != null)
                {
                    domainUpDown.Items.AddRange(homeTasks);
                }
                checkBox = new System.Windows.Forms.CheckBox();
                checkBox.Location = new System.Drawing.Point(650, y);
                checkBox.Checked = false;
                checkBox.Size = new System.Drawing.Size(20, 20);
                y += 50;
                homeTabPage.Controls.Add(labelBox);
                homeTabPage.Controls.Add(domainUpDown);
                homeTabPage.Controls.Add(checkBox);
            }
        }
        private void PersonalTasksInitialize()
        {
            domainUpDownsPersonalList = new List<DomainUpDown>();

            //readFile.Close();

            int x = 100;
            int y = 50;
            for (int i = 1; i <= 10; i++)
            {
                labelBox = new System.Windows.Forms.Label();
                labelBox.Location = new System.Drawing.Point(30, y);
                labelBox.Text = i.ToString();
                labelBox.Size = new System.Drawing.Size(40, 20);
                domainUpDown = new System.Windows.Forms.DomainUpDown();

                domainUpDown.Location = new System.Drawing.Point(x, y);
                domainUpDown.Name = "domainUpDown" + i;
                domainUpDown.MinimumSize = new System.Drawing.Size(500, 100);
                //domainUpDown.Size = new System.Drawing.Size(500, 100);
                domainUpDown.AllowDrop = true;
                //domainUpDown.AutoSize = true;
                domainUpDown.TabIndex = i;
                domainUpDown.Text = "";
                domainUpDownsPersonalList.Add(domainUpDown);
                if (personalTasks != null)
                {
                    domainUpDown.Items.AddRange(personalTasks);
                }
                checkBox = new System.Windows.Forms.CheckBox();
                checkBox.Location = new System.Drawing.Point(650, y);
                checkBox.Checked = false;
                checkBox.Size = new System.Drawing.Size(20, 20);
                y += 50;
                personalTabPage.Controls.Add(labelBox);
                personalTabPage.Controls.Add(domainUpDown);
                personalTabPage.Controls.Add(checkBox);
            }
        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl taskTabControl;
        private System.Windows.Forms.TabPage workTabPage;
        private System.Windows.Forms.TabPage homeTabPage;
        private System.Windows.Forms.TabPage personalTabPage;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private DomainUpDown domainUpDown2;
    }
}

