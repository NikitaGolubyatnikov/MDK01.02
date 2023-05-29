using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace текстовый_редактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                string fileName = openFileDialog1.FileName;
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));

            }
            richTextBox1.Clear();

        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(richTextBox1.SelectedText);

                // Удаляем выделенный текст из richTextBox
                richTextBox1.SelectedText = "";
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) // Проверяем, содержит ли буфер обмена текст
            {
                // Получаем текст из буфера обмена
                string clipboardText = Clipboard.GetText();

                // Вставляем текст в текущую позицию курсора в richTextBox
                richTextBox1.SelectedText = clipboardText;
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                richTextBox1.Clear();
            }
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello world!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(richTextBox1.SelectedText);

                // Удаляем выделенный текст из richTextBox
                richTextBox1.SelectedText = "";
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Clipboard.ContainsText()) // Проверяем, содержит ли буфер обмена текст
            {
                // Получаем текст из буфера обмена
                string clipboardText = Clipboard.GetText();

                // Вставляем текст в текущую позицию курсора в richTextBox
                richTextBox1.SelectedText = clipboardText;
            }
        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                richTextBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(richTextBox1.SelectedText);

                // Удаляем выделенный текст из richTextBox
                richTextBox1.SelectedText = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                // Копируем выделенный текст в буфер обмена
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) // Проверяем, содержит ли буфер обмена текст
            {
                // Получаем текст из буфера обмена
                string clipboardText = Clipboard.GetText();

                // Вставляем текст в текущую позицию курсора в richTextBox
                richTextBox1.SelectedText = clipboardText;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "") // Проверяем, есть ли выделенный текст
            {
                richTextBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора цвета
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный пользователем цвет
                Color selectedColor = colorDialog.Color;

                // Устанавливаем цвет выделенному тексту в richTextBox
                richTextBox1.SelectionColor = selectedColor;

                // Снимаем выделение текста
                richTextBox1.SelectionLength = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора шрифта
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный пользователем шрифт
                Font selectedFont = fontDialog.Font;

                // Применяем шрифт к выделенному тексту в richTextBox
                richTextBox1.SelectionFont = selectedFont;

                // Снимаем выделение текста
                richTextBox1.SelectionLength = 0;
            }
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 Form = new AboutBox1();
            Form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора цвета
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный пользователем цвет
                Color selectedColor = colorDialog.Color;

                // Устанавливаем цвет выделенному тексту в richTextBox
                richTextBox1.SelectionColor = selectedColor;

                // Снимаем выделение текста
                richTextBox1.SelectionLength = 0;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора шрифта
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем выбранный пользователем шрифт
                Font selectedFont = fontDialog.Font;

                // Применяем шрифт к выделенному тексту в richTextBox
                richTextBox1.SelectionFont = selectedFont;

                // Снимаем выделение текста
                richTextBox1.SelectionLength = 0;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
