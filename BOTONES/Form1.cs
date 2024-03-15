using System.Windows.Forms;

namespace BOTONES
{
    public partial class Form1 : Form
    {
        private EventHandler ListBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sad Girl");
            listBox1.Items.Add("Sumertime Sadness");
            listBox1.Items.Add("ART DECO");
            listBox1.Items.Add("Cherry");
            listBox1.SelectedIndexChanged += ListBox1;
            linkLabel1.Text = "My favorite song is";
            linkLabel1.LinkArea = new LinkArea(0, linkLabel1.Text.Length);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            CheckedListBox checkedListBox1 = new CheckedListBox();
            foreach (object itemChckedm in checkedListBox1.CheckedItems)
            {

                txtBox1.AppendText(itemChckedm.ToString() + Environment.NewLine);
            }
       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/TdrL3QxjyVw?si=16JVjjmSdB2nu4OX");

           
            linkLabel1.LinkVisited = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elementoSeleccionado = listBox1.SelectedItem.ToString();
            MessageBox.Show($"Has seleccionado: {elementoSeleccionado}");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
