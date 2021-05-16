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

namespace WindowsFormsApp1
{
    public partial class Файл : Form
    {
        public Файл()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void згенеруватиМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rnd.Next(-10, 10);
            }
        }

        private void додатиЕлементиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                sum += Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            label2.Text = "Результат: " + $"{sum}";
        }

        private void добутокЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int prod = 1;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                prod *= Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            label2.Text = "Результат: " + $"{prod}";
        }

        private void максимальнийЕлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            label2.Text = "Результат: " + $"{arr.Max()}";
        }

        private void мінімальникйЕлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            label2.Text = "Результат: " + $"{arr.Min()}";
        }

        private void кількістьВідємнихЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }

            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] < 0)
                {
                    k++;
                }
            }
            label2.Text = "Результат: " + $"{k}";
        }

        private void кількістьДодатніхЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }

            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] > 0)
                {
                    k++;
                }
            }
            label2.Text = "Результат: " + $"{k}";
        }

        private void кільнмстьПарниїЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }

            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i]%2==0)
                {
                    k++;
                }
            }
            label2.Text = "Результат: " + $"{k}";
        }

        private void кількістьНепарнихЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }

            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i] % 2 != 0)
                {
                    k++;
                }
            }
            label2.Text = "Результат: " + $"{k}";
        }

        private void середнєАрифметичнеЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                s += Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            double sa = s / (double)numericUpDown1.Value;
            label2.Text = "Результат: " + $"{sa}";
        }

        private void середнєГеометричнеЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double prod = 1;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                prod *= Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            double sg = Math.Sqrt(prod);
            label2.Text = "Результат: " + $"{sg}";
        }

        private void елементЯкийЗустрічаєтьсяНайчастішеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] arr = new int[(int)numericUpDown1.Value];
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                arr[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
            }

            int count = 0;
            int index = -1;
            for (int i = 0; i < arr.Length; ++i)
            {
                int k = 1;
                for (int j = i + 1; j < arr.Length; ++j)
                    if (arr[i] == arr[j])
                        k++;
                if (k <= count)
                    continue;
                count = k;
                index = i;                
            }
            label2.Text = "Результат: " + $"{arr[index]}";
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    SW.WriteLine(dataGridView1[i, 0].Value);
                }
                SW.Close();
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                numericUpDown1.Value = Convert.ToInt32(System.IO.File.ReadAllLines(openFileDialog1.FileName).Length);
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1[i, 0].Value = SR.ReadLine();
                }
                SR.Close();
            }
        }
    }
}
