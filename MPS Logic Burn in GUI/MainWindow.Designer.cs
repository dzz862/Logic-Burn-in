using System;
using System.Windows.Forms;

namespace MP6422_Test_Controller
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.waveviwer1 = new MP6422_Test_Controller.waveviwer();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new CCWin.SkinControl.SkinButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new CCWin.SkinControl.SkinComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button8 = new CCWin.SkinControl.SkinButton();
            this.button7 = new CCWin.SkinControl.SkinButton();
            this.button6 = new CCWin.SkinControl.SkinButton();
            this.button5 = new CCWin.SkinControl.SkinButton();
            this.button4 = new CCWin.SkinControl.SkinButton();
            this.menuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new CCWin.SkinControl.SkinButton();
            this.button2 = new CCWin.SkinControl.SkinButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AnimationStart = true;
            this.tabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.HeadBack = null;
            this.tabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 25);
            this.tabControl1.Location = new System.Drawing.Point(7, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowDown")));
            this.tabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowHover")));
            this.tabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseHover")));
            this.tabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseNormal")));
            this.tabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageDown")));
            this.tabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageHover")));
            this.tabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl1.PageNorml = null;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 509);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.waveviwer1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(0, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.TabItemImage = null;
            this.tabPage1.Text = "Logic Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // waveviwer1
            // 
            this.waveviwer1.Location = new System.Drawing.Point(4, 54);
            this.waveviwer1.Name = "waveviwer1";
            this.waveviwer1.SelectedIndex = 0;
            this.waveviwer1.Size = new System.Drawing.Size(893, 421);
            this.waveviwer1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "ms ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last for:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "ms, ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(798, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 20);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(483, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 20);
            this.panel5.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button3.DownBack = null;
            this.button3.Location = new System.Drawing.Point(816, 16);
            this.button3.MouseBack = null;
            this.button3.Name = "button3";
            this.button3.NormlBack = null;
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(546, 17);
            this.textBox2.MaxLength = 2147483647;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 21);
            this.textBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "High Voltage will Start at:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(692, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 21);
            this.textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(185, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 20);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(483, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 20);
            this.panel3.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(311, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(54, 22);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.WaterText = "";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Operation:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(119, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "0";
            this.comboBox1.WaterText = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Pin Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(0, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.TabItemImage = null;
            this.tabPage2.Text = "Sequence Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage3.Location = new System.Drawing.Point(0, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(903, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.TabItemImage = null;
            this.tabPage3.Text = "I2C Generator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(0, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(903, 484);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Temp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button8.DownBack = null;
            this.button8.Location = new System.Drawing.Point(27, 226);
            this.button8.MouseBack = null;
            this.button8.Name = "button8";
            this.button8.NormlBack = null;
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button7.DownBack = null;
            this.button7.Location = new System.Drawing.Point(27, 175);
            this.button7.MouseBack = null;
            this.button7.Name = "button7";
            this.button7.NormlBack = null;
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button6.DownBack = null;
            this.button6.Location = new System.Drawing.Point(27, 128);
            this.button6.MouseBack = null;
            this.button6.Name = "button6";
            this.button6.NormlBack = null;
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button5.DownBack = null;
            this.button5.Location = new System.Drawing.Point(27, 79);
            this.button5.MouseBack = null;
            this.button5.Name = "button5";
            this.button5.NormlBack = null;
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button4.DownBack = null;
            this.button4.Location = new System.Drawing.Point(27, 33);
            this.button4.MouseBack = null;
            this.button4.Name = "button4";
            this.button4.NormlBack = null;
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Arrow = System.Drawing.Color.Black;
            this.menuStrip1.Back = System.Drawing.Color.White;
            this.menuStrip1.BackRadius = 4;
            this.menuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.menuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.menuStrip1.BaseFore = System.Drawing.Color.Black;
            this.menuStrip1.BaseForeAnamorphosis = false;
            this.menuStrip1.BaseForeAnamorphosisBorder = 4;
            this.menuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.menuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.menuStrip1.BaseItemAnamorphosis = true;
            this.menuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.BaseItemBorderShow = true;
            this.menuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BaseItemDown")));
            this.menuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BaseItemMouse")));
            this.menuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.BaseItemRadius = 4;
            this.menuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menuStrip1.Fore = System.Drawing.Color.Black;
            this.menuStrip1.HoverFore = System.Drawing.Color.White;
            this.menuStrip1.ItemAnamorphosis = true;
            this.menuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.ItemBorderShow = true;
            this.menuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menuStrip1.ItemRadius = 4;
            this.menuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menuStrip1.Size = new System.Drawing.Size(910, 25);
            this.menuStrip1.SkinAllColor = true;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TitleAnamorphosis = true;
            this.menuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menuStrip1.TitleRadius = 4;
            this.menuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveWaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveWaveToolStripMenuItem
            // 
            this.saveWaveToolStripMenuItem.Name = "saveWaveToolStripMenuItem";
            this.saveWaveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveWaveToolStripMenuItem.Text = "Save wave";
            this.saveWaveToolStripMenuItem.Click += new System.EventHandler(this.saveWaveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button1.DownBack = null;
            this.button1.Location = new System.Drawing.Point(742, 571);
            this.button1.MouseBack = null;
            this.button1.Name = "button1";
            this.button1.NormlBack = null;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button2.DownBack = null;
            this.button2.Location = new System.Drawing.Point(834, 571);
            this.button2.MouseBack = null;
            this.button2.Name = "button2";
            this.button2.NormlBack = null;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 601);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MPS Logic Burn in";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ComboBox2_BindingContextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private CCWin.SkinControl.SkinTabControl tabControl1;
        //private System.Windows.Forms.CSkinTabControl tabControl1;
        private CCWin.SkinControl.SkinTabPage tabPage1;
        private CCWin.SkinControl.SkinTabPage tabPage2;
        private CCWin.SkinControl.SkinTabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private CCWin.SkinControl.SkinComboBox comboBox1;
        private CCWin.SkinControl.SkinComboBox comboBox2;
        private CCWin.SkinControl.SkinButton button1;
        private CCWin.SkinControl.SkinButton button2;
        private CCWin.SkinControl.SkinButton button3;
        private CCWin.SkinControl.SkinButton button8;
        private CCWin.SkinControl.SkinButton button7;
        private CCWin.SkinControl.SkinButton button6;
        private CCWin.SkinControl.SkinButton button5;
        private CCWin.SkinControl.SkinButton button4;
        private CCWin.SkinControl.SkinMenuStrip menuStrip1;
        private Label label5;
        private Label label3;
        private waveviwer waveviwer1;
        private ToolStripMenuItem saveWaveToolStripMenuItem;
    }
}

