using System.Drawing.Imaging;

namespace WinForms_Wordpad_Killer_Homework {
    public partial class Form1 : Form {
        FontStyle style = FontStyle.Regular;
        public Form1() {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string text = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = text;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(folderBrowserDialog1.SelectedPath + "\\" + SaveBox.Text + ".txt", richTextBox1.Text);
                MessageBox.Show("File saved successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily fontFamily in fontFamilies) {
                comboBox1.Items.Add(fontFamily.Name);
            }
            comboBox1.Text = richTextBox1.Font.Name;
            for (int i = 1; i < 73; i++) {
                comboBox2.Items.Add(i.ToString());
            }
            comboBox2.Text = "9";
        }

        private void ColorButton_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.Font = new Font(comboBox1.Text, Convert.ToSingle(comboBox2.Text), style);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            richTextBox1.Font = new Font(comboBox1.Text, Convert.ToSingle(comboBox2.Text), style);
        }

        private void BoldButton_Click(object sender, EventArgs e) {
            if (style != FontStyle.Bold) style |= FontStyle.Bold;
            else style -= FontStyle.Bold;
            richTextBox1.Font = new Font(comboBox1.Text, Convert.ToSingle(comboBox2.Text), style);
        }

        private void UnderlineButton_Click(object sender, EventArgs e) {
            if (style != FontStyle.Underline) style |= FontStyle.Underline;
            else style -= FontStyle.Underline;
            richTextBox1.Font = new Font(comboBox1.Text, Convert.ToSingle(comboBox2.Text), style);
        }

        private void ItalicButton_Click(object sender, EventArgs e) {
            if (style != FontStyle.Italic) style |= FontStyle.Italic;
            else style -= FontStyle.Italic;
            richTextBox1.Font = new Font(comboBox1.Text, Convert.ToSingle(comboBox2.Text), style);
        }

        private void LeftAlignmentButton_Click(object sender, EventArgs e) {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlignmentButton_Click(object sender, EventArgs e) {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignmentButton_Click(object sender, EventArgs e) {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}