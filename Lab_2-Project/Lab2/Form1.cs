namespace Lab2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font("Monotype Corsiva", 24, FontStyle.Italic, GraphicsUnit.Point);
            label2.Font = new Font("Monotype Corsiva", 20, FontStyle.Italic, GraphicsUnit.Point);
            label3.Font = new Font("Monotype Corsiva", 20, FontStyle.Italic, GraphicsUnit.Point);
            label7.Font = new Font("Monotype Corsiva", 24, FontStyle.Italic, GraphicsUnit.Point);
            radioButton1.Checked = false;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(domainUpDown1.SelectedIndex == -1 || domainUpDown2.SelectedIndex == -1)
            {
                MessageBox.Show("Items don't selected");
            }
            else
            {
                listBox1.Items.Add(domainUpDown1.SelectedItem + "                      " + domainUpDown2.SelectedItem);
                listBox1.Text = listBox1.Text + (domainUpDown1.SelectedItem + "         " + domainUpDown2.SelectedItem + "\n");
            }

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(listBox1.SelectedIndex == listBox1.TopIndex)
                {
                    MessageBox.Show("Ви не можете видалити це");
                }
                else
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label8.Text = "ID_001";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label8.Text = "ID_002";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label8.Text = "ID_003";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                label8.Text = "ID_004";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            comboBox1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled=true;
            comboBox1.Enabled=false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int day = (int)System.DateTime.Now.DayOfWeek + 1;
            string id = "ID_00" + day.ToString();
            label8.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                richTextBox1.Text = "ID_CLIENT: " + label8.Text + "\nClient: " + comboBox1.Text + "\n\r\nOrder: \nTovar                  Number\n" + listBox1.Text;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Text = "ID_CLIENT: " + label8.Text + "\nClient: " + comboBox1.Text + "\n\r\nOrder: \nTovar                  Number\n" + listBox1.Text;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                richTextBox1.Text = "ID_CLIENT: " + label8.Text + "\nClient: " + comboBox1.Text + "\n\r\nOrder: \nTovar                  Number\n" + listBox1.Text;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                richTextBox1.Text = "ID_CLIENT: " + label8.Text + "\nClient: " + comboBox1.Text + "\n\r\nOrder: \nTovar                  Number\n" + listBox1.Text;
            }
            if (textBox1.Enabled == true)
            {
                richTextBox1.Text = "ID_CLIENT: " + label8.Text + "\nClient: " + textBox1.Text + "\n\r\nOrder: \nTovar                  Number\n" + listBox1.Text;
            }
        }

        private void s(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                DialogResult dr = MessageBox.Show("Choose", "You want to save?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Yes)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName);
                            MessageBox.Show("Saved!");
                        }
                }
                
            }

        }

        private void key_press(object sender, KeyPressEventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}