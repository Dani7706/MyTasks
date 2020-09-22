using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTasks
{
   
    public partial class MyTasks : Form
    {
        List<string> workTasks;
        List<string> homeTasks;
        List<string> personalTasks;
        Label labelBox;
        DomainUpDown domainUpDown;
        CheckBox checkBox;
        List<DomainUpDown> domainUpDownsList;
        List<DomainUpDown> domainUpDownsHomeList;
        List<DomainUpDown> domainUpDownsPersonalList;
        const string PathHome = @"C:\Users\dell\Documents\Project\MyTasks\textHome.txt";
        StreamWriter writeFileHome;
        public MyTasks()
        {
            InitializeComponent();
            workTasks = new List<string>();
            homeTasks = new List<string>();
            personalTasks = new List<string>();
            writeFileHome = new System.IO.StreamWriter(PathHome, true);
            SetValue();
            MyInitialize();
            HomeTasksInitialize();
            PersonalTasksInitialize();
            
        }

        private void SetValue()
        {
            const string Path = @"C:\Users\dell\Documents\Project\MyTasks\text.txt";

            var readFile = new System.IO.StreamReader(Path);
            
            string strContent = readFile.ReadLine();


            while (strContent!= null)
            {
                workTasks.Add(strContent);
                strContent = readFile.ReadLine();
                if (strContent == null)
                {
                    readFile.Close();

                }


                
            };
            const string PathHome = @"C:\Users\dell\Documents\Project\MyTasks\textHome.txt";
            //var writeFileHome = new System.IO.StreamWriter(PathHome, true);
            writeFileHome.Close();
           
            var readFileHome = new System.IO.StreamReader(PathHome);

            string strContentHome = readFileHome.ReadLine();


            while (strContentHome != null)
            {
                homeTasks.Add(strContent);
                strContentHome = readFileHome.ReadLine();
                if (strContentHome == null)
                {
                    readFileHome.Close();

                }



            };
            const string PathPersonal = @"C:\Users\dell\Documents\Project\MyTasks\textPersonal.txt";
            var writeFilePersonal = new System.IO.StreamWriter(PathPersonal, true);
            writeFilePersonal.Close();
            var readFilePersonal = new System.IO.StreamReader(PathPersonal);

            string strContentPersonal = readFilePersonal.ReadLine();


            while (strContentPersonal != null)
            {
                personalTasks.Add(strContentPersonal);
                strContentPersonal = readFilePersonal.ReadLine();
                if (strContentPersonal == null)
                {
                    readFilePersonal.Close();

                }



            };
        }

        private void addWorkTaskBtn_Click(object sender, EventArgs e)
        {
            
            const string Path = @"C:\Users\dell\Documents\Project\MyTasks\text.txt";

            var writeFile = new System.IO.StreamWriter(Path, true);
            var task = Interaction.InputBox("Add Task", "Add Task");
            writeFile.WriteLine(task);
            workTasks.Add(task);
            writeFile.Close();
            foreach (var item in domainUpDownsList)
            {
                item.Items.Add(task);
            }
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            const string Path = @"C:\Users\dell\Documents\Project\MyTasks\text.txt";

            var writeFile = new System.IO.StreamWriter(Path, true);
            var task = Interaction.InputBox("Add Task", "Add Task");
            writeFile.WriteLine(task);
            workTasks.Add(task);
            writeFile.Close();
            foreach (var item in domainUpDownsList)
            {
                item.Items.Add(task);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int formsCount = domainUpDownsList.Count;
            int x = 100;
            int y = 35*formsCount+30;
            labelBox = new System.Windows.Forms.Label();
            labelBox.Location = new System.Drawing.Point(30, y);
            labelBox.Text = (formsCount+1).ToString();
            labelBox.Size = new System.Drawing.Size(40, 20);
            domainUpDown = new DomainUpDown();
            domainUpDown.Location = new Point(x, y);
            domainUpDown.Size = new Size(500, 100);
            domainUpDown.Name = "domainUpDown" + formsCount + 1;
            domainUpDown.TabIndex = formsCount + 1;
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
            
            workTabPage.Controls.Add(labelBox);
            workTabPage.Controls.Add(domainUpDown);
            workTabPage.Controls.Add(checkBox);
           
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //const string Path = @"C:\Users\dell\Documents\Project\MyTasks\textHome.txt";

            //var writeFileHome = new System.IO.StreamWriter(Path, true);
            var task = Interaction.InputBox("Add Task", "Add Task");
            writeFileHome.WriteLine(task);
            homeTasks.Add(task);
            writeFileHome.Close();
            foreach (var item in domainUpDownsHomeList)
            {
                item.Items.Add(task);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            int formsCount = domainUpDownsList.Count;
            int x = 100;
            int y = 35 * (formsCount - 1) + 50;
            labelBox = new System.Windows.Forms.Label();
            labelBox.Location = new System.Drawing.Point(30, y);
            labelBox.Text = (formsCount + 1).ToString();
            labelBox.Size = new System.Drawing.Size(40, 20);
            domainUpDown = new DomainUpDown
            {
                Location = new Point(x, y),
                Name = "domainUpDown" + formsCount + 1,
                Size = new Size(500, 100),
                AllowDrop = true,
                //AutoSize = true,
                TabIndex = formsCount + 1,
                Text = ""
            };
            domainUpDownsList.Add(domainUpDown);
            if (workTasks != null)
            {
                domainUpDown.Items.AddRange(workTasks);
            }

            checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Location = new System.Drawing.Point(650, y);
            checkBox.Checked = false;
            checkBox.Size = new System.Drawing.Size(20, 20);

            homeTabPage.Controls.Add(labelBox);
            homeTabPage.Controls.Add(domainUpDown);
            homeTabPage.Controls.Add(checkBox);


        }
    }
}
