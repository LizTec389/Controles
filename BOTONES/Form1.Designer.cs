namespace BOTONES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            monthCalendar1 = new MonthCalendar();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            txtBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            notifyIcon1 = new NotifyIcon(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(336, 274);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Bien", "Mal", "Normal", "Enferma", "Al borde del sui" });
            checkedListBox1.Location = new Point(46, 199);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(638, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 181);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "¿Como Estas?";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Cyan;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkVisited = true;
            linkLabel1.Location = new Point(323, 147);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "My favorit song is";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(323, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(541, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(710, 55);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(-4, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(235, 286);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Cover_LanaDel;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(449, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 355);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(541, 173);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 13;
            progressBar1.Click += progressBar1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(710, 108);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(704, 162);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(12, 330);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(100, 23);
            txtBox1.TabIndex = 16;
            txtBox1.TextChanged += textBox1_TextChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(235, 330);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 17;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.Location = new Point(256, 9);
            label2.Name = "label2";
            label2.Size = new Size(254, 15);
            label2.TabIndex = 18;
            label2.Text = "Selecciona la cancion que mas te guste de lana";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(890, 512);
            Controls.Add(label2);
            Controls.Add(treeView1);
            Controls.Add(txtBox1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private MaskedTextBox maskedTextBox1;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private TextBox txtBox1;
        private ToolTip toolTip1;
        private TreeView treeView1;
        private NotifyIcon notifyIcon1;
        private Label label2;
    }
}
