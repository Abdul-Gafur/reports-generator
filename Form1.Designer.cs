using System;
using System.Windows.Forms;

namespace Student_Reports_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathematics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Science = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dagaare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtstaverage = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtterm = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.laable = new System.Windows.Forms.Label();
            this.lblclasss = new System.Windows.Forms.Label();
            this.lblstudent = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdagaare = new System.Windows.Forms.TextBox();
            this.txtbdt = new System.Windows.Forms.TextBox();
            this.txtict = new System.Windows.Forms.TextBox();
            this.txtrme = new System.Windows.Forms.TextBox();
            this.txtscience = new System.Windows.Forms.TextBox();
            this.txtsocial = new System.Windows.Forms.TextBox();
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txtmathematics = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblstaverage = new System.Windows.Forms.Label();
            this.lblterm = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblposition = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnranking = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btntranscript = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblbdt = new System.Windows.Forms.Label();
            this.lblict = new System.Windows.Forms.Label();
            this.lblrme = new System.Windows.Forms.Label();
            this.lblsocial = new System.Windows.Forms.Label();
            this.lblscience = new System.Windows.Forms.Label();
            this.lblenglish = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblmathematics = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.lbldagaare = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblmr = new System.Windows.Forms.Label();
            this.lbler = new System.Windows.Forms.Label();
            this.lblisr = new System.Windows.Forms.Label();
            this.lblsr = new System.Windows.Forms.Label();
            this.lblrr = new System.Windows.Forms.Label();
            this.lblir = new System.Windows.Forms.Label();
            this.lblbr = new System.Windows.Forms.Label();
            this.lbldr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentname,
            this.Mathematics,
            this.English,
            this.Science,
            this.Social,
            this.RME,
            this.ICT,
            this.BDT,
            this.Dagaare,
            this.Total,
            this.Average,
            this.Position});
            this.dataGridView1.Location = new System.Drawing.Point(0, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 224);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentname
            // 
            this.studentname.HeaderText = "Student Name";
            this.studentname.Name = "studentname";
            this.studentname.ToolTipText = "Student Name";
            // 
            // Mathematics
            // 
            this.Mathematics.HeaderText = "Mathematics";
            this.Mathematics.Name = "Mathematics";
            // 
            // English
            // 
            this.English.HeaderText = "English";
            this.English.Name = "English";
            // 
            // Science
            // 
            this.Science.HeaderText = "Science";
            this.Science.Name = "Science";
            // 
            // Social
            // 
            this.Social.HeaderText = "Social";
            this.Social.Name = "Social";
            // 
            // RME
            // 
            this.RME.HeaderText = "RME";
            this.RME.Name = "RME";
            // 
            // ICT
            // 
            this.ICT.HeaderText = "ICT";
            this.ICT.Name = "ICT";
            // 
            // BDT
            // 
            this.BDT.HeaderText = "BDT";
            this.BDT.Name = "BDT";
            // 
            // Dagaare
            // 
            this.Dagaare.HeaderText = "Dagaare";
            this.Dagaare.Name = "Dagaare";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Average
            // 
            this.Average.HeaderText = "Average";
            this.Average.Name = "Average";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.txtstaverage);
            this.groupBox1.Controls.Add(this.txtgender);
            this.groupBox1.Controls.Add(this.txtterm);
            this.groupBox1.Controls.Add(this.txtclass);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.txtstudentname);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.laable);
            this.groupBox1.Controls.Add(this.lblclasss);
            this.groupBox1.Controls.Add(this.lblstudent);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 363);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(159, 265);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(193, 26);
            this.txttotal.TabIndex = 1;
            // 
            // txtstaverage
            // 
            this.txtstaverage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstaverage.Location = new System.Drawing.Point(159, 297);
            this.txtstaverage.Name = "txtstaverage";
            this.txtstaverage.Size = new System.Drawing.Size(193, 26);
            this.txtstaverage.TabIndex = 1;
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgender.Location = new System.Drawing.Point(159, 120);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(193, 26);
            this.txtgender.TabIndex = 3;
            // 
            // txtterm
            // 
            this.txtterm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtterm.Location = new System.Drawing.Point(159, 166);
            this.txtterm.Name = "txtterm";
            this.txtterm.Size = new System.Drawing.Size(193, 26);
            this.txtterm.TabIndex = 4;
            // 
            // txtclass
            // 
            this.txtclass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclass.Location = new System.Drawing.Point(159, 72);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(193, 26);
            this.txtclass.TabIndex = 2;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(55, 269);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 18);
            this.label29.TabIndex = 0;
            this.label29.Text = "Total Score :";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.Location = new System.Drawing.Point(159, 20);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(193, 26);
            this.txtstudentname.TabIndex = 1;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(14, 300);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(138, 18);
            this.a.TabIndex = 0;
            this.a.Text = "Student Average :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Term :";
            // 
            // laable
            // 
            this.laable.AutoSize = true;
            this.laable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laable.Location = new System.Drawing.Point(80, 118);
            this.laable.Name = "laable";
            this.laable.Size = new System.Drawing.Size(73, 18);
            this.laable.TabIndex = 0;
            this.laable.Text = "Gender :";
            // 
            // lblclasss
            // 
            this.lblclasss.AutoSize = true;
            this.lblclasss.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclasss.Location = new System.Drawing.Point(99, 72);
            this.lblclasss.Name = "lblclasss";
            this.lblclasss.Size = new System.Drawing.Size(54, 18);
            this.lblclasss.TabIndex = 0;
            this.lblclasss.Text = "Class :";
            // 
            // lblstudent
            // 
            this.lblstudent.AutoSize = true;
            this.lblstudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudent.Location = new System.Drawing.Point(34, 23);
            this.lblstudent.Name = "lblstudent";
            this.lblstudent.Size = new System.Drawing.Size(119, 18);
            this.lblstudent.TabIndex = 0;
            this.lblstudent.Text = "Student Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtdagaare);
            this.groupBox3.Controls.Add(this.txtbdt);
            this.groupBox3.Controls.Add(this.txtict);
            this.groupBox3.Controls.Add(this.txtrme);
            this.groupBox3.Controls.Add(this.txtscience);
            this.groupBox3.Controls.Add(this.txtsocial);
            this.groupBox3.Controls.Add(this.txtenglish);
            this.groupBox3.Controls.Add(this.txtmathematics);
            this.groupBox3.Controls.Add(this.d);
            this.groupBox3.Controls.Add(this.b);
            this.groupBox3.Controls.Add(this.i);
            this.groupBox3.Controls.Add(this.r);
            this.groupBox3.Controls.Add(this.sc);
            this.groupBox3.Controls.Add(this.s);
            this.groupBox3.Controls.Add(this.e);
            this.groupBox3.Controls.Add(this.m);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(414, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 363);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // txtdagaare
            // 
            this.txtdagaare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdagaare.Location = new System.Drawing.Point(174, 294);
            this.txtdagaare.Name = "txtdagaare";
            this.txtdagaare.Size = new System.Drawing.Size(155, 26);
            this.txtdagaare.TabIndex = 12;
            // 
            // txtbdt
            // 
            this.txtbdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbdt.Location = new System.Drawing.Point(174, 257);
            this.txtbdt.Name = "txtbdt";
            this.txtbdt.Size = new System.Drawing.Size(155, 26);
            this.txtbdt.TabIndex = 11;
            // 
            // txtict
            // 
            this.txtict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtict.Location = new System.Drawing.Point(174, 224);
            this.txtict.Name = "txtict";
            this.txtict.Size = new System.Drawing.Size(155, 26);
            this.txtict.TabIndex = 10;
            // 
            // txtrme
            // 
            this.txtrme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrme.Location = new System.Drawing.Point(174, 182);
            this.txtrme.Name = "txtrme";
            this.txtrme.Size = new System.Drawing.Size(155, 26);
            this.txtrme.TabIndex = 9;
            // 
            // txtscience
            // 
            this.txtscience.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscience.Location = new System.Drawing.Point(174, 109);
            this.txtscience.Name = "txtscience";
            this.txtscience.Size = new System.Drawing.Size(155, 26);
            this.txtscience.TabIndex = 7;
            // 
            // txtsocial
            // 
            this.txtsocial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsocial.Location = new System.Drawing.Point(174, 149);
            this.txtsocial.Name = "txtsocial";
            this.txtsocial.Size = new System.Drawing.Size(155, 26);
            this.txtsocial.TabIndex = 8;
            // 
            // txtenglish
            // 
            this.txtenglish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenglish.Location = new System.Drawing.Point(174, 64);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(155, 26);
            this.txtenglish.TabIndex = 6;
            // 
            // txtmathematics
            // 
            this.txtmathematics.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmathematics.Location = new System.Drawing.Point(174, 26);
            this.txtmathematics.Name = "txtmathematics";
            this.txtmathematics.Size = new System.Drawing.Size(155, 26);
            this.txtmathematics.TabIndex = 5;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(72, 297);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(87, 19);
            this.d.TabIndex = 0;
            this.d.Text = "Dagaare :";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(106, 260);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(52, 19);
            this.b.TabIndex = 0;
            this.b.Text = "B.D.T :";
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i.Location = new System.Drawing.Point(111, 227);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(48, 19);
            this.i.TabIndex = 0;
            this.i.Text = "I.C.T :";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(102, 190);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(56, 19);
            this.r.TabIndex = 0;
            this.r.Text = "R.M.E :";
            this.r.Click += new System.EventHandler(this.lblrme_Click);
            // 
            // sc
            // 
            this.sc.AutoSize = true;
            this.sc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc.Location = new System.Drawing.Point(38, 152);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(121, 19);
            this.sc.TabIndex = 0;
            this.sc.Text = "Social Studies :";
            this.sc.Click += new System.EventHandler(this.label11_Click);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(57, 109);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(101, 19);
            this.s.TabIndex = 0;
            this.s.Text = "Int.Science :";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(4, 67);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(155, 19);
            this.e.TabIndex = 0;
            this.e.Text = "English Language :";
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.Location = new System.Drawing.Point(42, 28);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(117, 19);
            this.m.TabIndex = 0;
            this.m.Text = "Mathematics :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.FormattingEnabled = true;
            this.groupBox2.Location = new System.Drawing.Point(793, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 732);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1014, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "GHAFCODES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(977, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "POST OFFICE BOX 636";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(999, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telephone : 0200957200";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(957, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail : abdulgafurshaattir@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(963, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "STUDENT\'S REPORT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(821, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 3);
            this.panel1.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.White;
            this.lable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(835, 187);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(58, 19);
            this.lable.TabIndex = 7;
            this.lable.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(835, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.White;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(899, 187);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 19);
            this.lblname.TabIndex = 7;
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.BackColor = System.Drawing.Color.White;
            this.lblclass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.Location = new System.Drawing.Point(887, 221);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(0, 19);
            this.lblclass.TabIndex = 7;
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.BackColor = System.Drawing.Color.White;
            this.lble.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lble.Location = new System.Drawing.Point(1145, 183);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(68, 19);
            this.lble.TabIndex = 7;
            this.lble.Text = "Gender :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.White;
            this.lblgender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(1210, 183);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(0, 19);
            this.lblgender.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(835, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Student\'s Average Mark :";
            // 
            // lblstaverage
            // 
            this.lblstaverage.AutoSize = true;
            this.lblstaverage.BackColor = System.Drawing.Color.White;
            this.lblstaverage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaverage.Location = new System.Drawing.Point(1014, 253);
            this.lblstaverage.Name = "lblstaverage";
            this.lblstaverage.Size = new System.Drawing.Size(0, 19);
            this.lblstaverage.TabIndex = 7;
            // 
            // lblterm
            // 
            this.lblterm.AutoSize = true;
            this.lblterm.BackColor = System.Drawing.Color.White;
            this.lblterm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblterm.Location = new System.Drawing.Point(1195, 220);
            this.lblterm.Name = "lblterm";
            this.lblterm.Size = new System.Drawing.Size(0, 19);
            this.lblterm.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1145, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Term :";
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.BackColor = System.Drawing.Color.White;
            this.lblposition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblposition.Location = new System.Drawing.Point(1268, 253);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(0, 19);
            this.lblposition.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1238, 646);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(979, 569);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 19);
            this.label23.TabIndex = 0;
            this.label23.Text = "Total :";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.White;
            this.lbltotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(1027, 569);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 19);
            this.lbltotal.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(839, 619);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 65);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(284, 60);
            this.label24.TabIndex = 0;
            this.label24.Text = resources.GetString("label24.Text");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1197, 665);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 19);
            this.label25.TabIndex = 0;
            this.label25.Text = "(HEADMASTER)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1186, 627);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(145, 19);
            this.label26.TabIndex = 0;
            this.label26.Text = "..................................";
            // 
            // btnranking
            // 
            this.btnranking.BackColor = System.Drawing.Color.LightGray;
            this.btnranking.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnranking.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnranking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnranking.Location = new System.Drawing.Point(123, 18);
            this.btnranking.Name = "btnranking";
            this.btnranking.Size = new System.Drawing.Size(90, 45);
            this.btnranking.TabIndex = 14;
            this.btnranking.Text = "Ranking";
            this.btnranking.UseVisualStyleBackColor = false;
            this.btnranking.Click += new System.EventHandler(this.btnranking_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightGray;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(219, 18);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(98, 46);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightGray;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Location = new System.Drawing.Point(438, 19);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(109, 47);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.AccessibleDescription = "btnexit";
            this.btnexit.AccessibleName = "btnexit";
            this.btnexit.BackColor = System.Drawing.Color.LightGray;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(670, 19);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 46);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightGray;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(323, 17);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(111, 47);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.LightGray;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(555, 17);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(109, 45);
            this.btnreset.TabIndex = 18;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btntranscript
            // 
            this.btntranscript.BackColor = System.Drawing.Color.LightGray;
            this.btntranscript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntranscript.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntranscript.Location = new System.Drawing.Point(12, 17);
            this.btntranscript.Name = "btntranscript";
            this.btntranscript.Size = new System.Drawing.Size(105, 46);
            this.btntranscript.TabIndex = 15;
            this.btntranscript.Text = "Report";
            this.btntranscript.UseVisualStyleBackColor = false;
            this.btntranscript.Click += new System.EventHandler(this.btntranscript_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnclear);
            this.groupBox4.Controls.Add(this.btntranscript);
            this.groupBox4.Controls.Add(this.btnranking);
            this.groupBox4.Controls.Add(this.btnreset);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btnexit);
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Location = new System.Drawing.Point(0, 646);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(787, 91);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // lblbdt
            // 
            this.lblbdt.AutoSize = true;
            this.lblbdt.BackColor = System.Drawing.Color.White;
            this.lblbdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbdt.Location = new System.Drawing.Point(206, 176);
            this.lblbdt.Name = "lblbdt";
            this.lblbdt.Size = new System.Drawing.Size(0, 19);
            this.lblbdt.TabIndex = 7;
            // 
            // lblict
            // 
            this.lblict.AutoSize = true;
            this.lblict.BackColor = System.Drawing.Color.White;
            this.lblict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblict.Location = new System.Drawing.Point(206, 152);
            this.lblict.Name = "lblict";
            this.lblict.Size = new System.Drawing.Size(0, 19);
            this.lblict.TabIndex = 7;
            // 
            // lblrme
            // 
            this.lblrme.AutoSize = true;
            this.lblrme.BackColor = System.Drawing.Color.White;
            this.lblrme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrme.Location = new System.Drawing.Point(206, 128);
            this.lblrme.Name = "lblrme";
            this.lblrme.Size = new System.Drawing.Size(0, 19);
            this.lblrme.TabIndex = 7;
            // 
            // lblsocial
            // 
            this.lblsocial.AutoSize = true;
            this.lblsocial.BackColor = System.Drawing.Color.White;
            this.lblsocial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsocial.Location = new System.Drawing.Point(206, 103);
            this.lblsocial.Name = "lblsocial";
            this.lblsocial.Size = new System.Drawing.Size(0, 19);
            this.lblsocial.TabIndex = 7;
            // 
            // lblscience
            // 
            this.lblscience.AutoSize = true;
            this.lblscience.BackColor = System.Drawing.Color.White;
            this.lblscience.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscience.Location = new System.Drawing.Point(206, 77);
            this.lblscience.Name = "lblscience";
            this.lblscience.Size = new System.Drawing.Size(0, 19);
            this.lblscience.TabIndex = 7;
            // 
            // lblenglish
            // 
            this.lblenglish.AutoSize = true;
            this.lblenglish.BackColor = System.Drawing.Color.White;
            this.lblenglish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenglish.Location = new System.Drawing.Point(206, 51);
            this.lblenglish.Name = "lblenglish";
            this.lblenglish.Size = new System.Drawing.Size(0, 19);
            this.lblenglish.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 19);
            this.label18.TabIndex = 0;
            this.label18.Text = "B.D.T";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "I.C.T";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "R.M.E";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Social Studies";
            this.label15.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblmathematics
            // 
            this.lblmathematics.AutoSize = true;
            this.lblmathematics.BackColor = System.Drawing.Color.White;
            this.lblmathematics.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmathematics.Location = new System.Drawing.Point(206, 26);
            this.lblmathematics.Name = "lblmathematics";
            this.lblmathematics.Size = new System.Drawing.Size(0, 19);
            this.lblmathematics.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Int.Science";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(206, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 19);
            this.label20.TabIndex = 7;
            this.label20.Text = "Score";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "English Language";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mathematics";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Subjects";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblmathematics, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label30, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblenglish, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblscience, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblsocial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblrme, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblict, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblbdt, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbldagaare, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblmr, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbler, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblisr, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblsr, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblrr, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblir, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblbr, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbldr, 2, 8);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(809, 301);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 242);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(4, 199);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 19);
            this.label30.TabIndex = 0;
            this.label30.Text = "Dagaare";
            // 
            // lbldagaare
            // 
            this.lbldagaare.AutoSize = true;
            this.lbldagaare.BackColor = System.Drawing.Color.White;
            this.lbldagaare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldagaare.Location = new System.Drawing.Point(206, 199);
            this.lbldagaare.Name = "lbldagaare";
            this.lbldagaare.Size = new System.Drawing.Size(0, 19);
            this.lbldagaare.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(260, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 19);
            this.label21.TabIndex = 7;
            this.label21.Text = "Remarks";
            // 
            // lblmr
            // 
            this.lblmr.AutoSize = true;
            this.lblmr.BackColor = System.Drawing.Color.White;
            this.lblmr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmr.Location = new System.Drawing.Point(260, 26);
            this.lblmr.Name = "lblmr";
            this.lblmr.Size = new System.Drawing.Size(0, 19);
            this.lblmr.TabIndex = 7;
            // 
            // lbler
            // 
            this.lbler.AutoSize = true;
            this.lbler.BackColor = System.Drawing.Color.White;
            this.lbler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbler.Location = new System.Drawing.Point(260, 51);
            this.lbler.Name = "lbler";
            this.lbler.Size = new System.Drawing.Size(0, 19);
            this.lbler.TabIndex = 7;
            // 
            // lblisr
            // 
            this.lblisr.AutoSize = true;
            this.lblisr.BackColor = System.Drawing.Color.White;
            this.lblisr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisr.Location = new System.Drawing.Point(260, 77);
            this.lblisr.Name = "lblisr";
            this.lblisr.Size = new System.Drawing.Size(0, 19);
            this.lblisr.TabIndex = 7;
            // 
            // lblsr
            // 
            this.lblsr.AutoSize = true;
            this.lblsr.BackColor = System.Drawing.Color.White;
            this.lblsr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsr.Location = new System.Drawing.Point(260, 103);
            this.lblsr.Name = "lblsr";
            this.lblsr.Size = new System.Drawing.Size(0, 19);
            this.lblsr.TabIndex = 7;
            // 
            // lblrr
            // 
            this.lblrr.AutoSize = true;
            this.lblrr.BackColor = System.Drawing.Color.White;
            this.lblrr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrr.Location = new System.Drawing.Point(260, 128);
            this.lblrr.Name = "lblrr";
            this.lblrr.Size = new System.Drawing.Size(0, 19);
            this.lblrr.TabIndex = 7;
            // 
            // lblir
            // 
            this.lblir.AutoSize = true;
            this.lblir.BackColor = System.Drawing.Color.White;
            this.lblir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblir.Location = new System.Drawing.Point(260, 152);
            this.lblir.Name = "lblir";
            this.lblir.Size = new System.Drawing.Size(0, 19);
            this.lblir.TabIndex = 7;
            // 
            // lblbr
            // 
            this.lblbr.AutoSize = true;
            this.lblbr.BackColor = System.Drawing.Color.White;
            this.lblbr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbr.Location = new System.Drawing.Point(260, 176);
            this.lblbr.Name = "lblbr";
            this.lblbr.Size = new System.Drawing.Size(0, 19);
            this.lblbr.TabIndex = 7;
            // 
            // lbldr
            // 
            this.lbldr.AutoSize = true;
            this.lbldr.BackColor = System.Drawing.Color.White;
            this.lbldr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldr.Location = new System.Drawing.Point(260, 199);
            this.lbldr.Name = "lbldr";
            this.lbldr.Size = new System.Drawing.Size(0, 19);
            this.lbldr.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 749);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.lblterm);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblstaverage);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lble);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Reports System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label lblstudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdagaare;
        private System.Windows.Forms.TextBox txtbdt;
        private System.Windows.Forms.TextBox txtict;
        private System.Windows.Forms.TextBox txtrme;
        private System.Windows.Forms.TextBox txtsocial;
        private System.Windows.Forms.TextBox txtenglish;
        private System.Windows.Forms.TextBox txtmathematics;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.TextBox txtscience;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.Label lblclasss;
        private System.Windows.Forms.TextBox txtstaverage;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label laable;
        private System.Windows.Forms.ListBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblstaverage;
        private System.Windows.Forms.Label lblterm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label29;
        private Button btnranking;
        private Button btnupdate;
        private Button btndelete;
        private Button btnexit;
        private Button btnclear;
        private Button btnreset;
        private DataGridViewTextBoxColumn studentname;
        private DataGridViewTextBoxColumn Mathematics;
        private DataGridViewTextBoxColumn English;
        private DataGridViewTextBoxColumn Science;
        private DataGridViewTextBoxColumn Social;
        private DataGridViewTextBoxColumn RME;
        private DataGridViewTextBoxColumn ICT;
        private DataGridViewTextBoxColumn BDT;
        private DataGridViewTextBoxColumn Dagaare;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Average;
        private DataGridViewTextBoxColumn Position;
        private Button btntranscript;
        private GroupBox groupBox4;
        private Label lblbdt;
        private Label lblict;
        private Label lblrme;
        private Label lblsocial;
        private Label lblscience;
        private Label lblenglish;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label lblmathematics;
        private Label label14;
        private Label label20;
        private Label label13;
        private Label label12;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtgender;
        private TextBox txtterm;
        private Label label7;
        private Label label30;
        private Label lbldagaare;
        private Label label21;
        private Label lblmr;
        private Label lbler;
        private Label lblisr;
        private Label lblsr;
        private Label lblrr;
        private Label lblir;
        private Label lblbr;
        private Label lbldr;
    }
}

