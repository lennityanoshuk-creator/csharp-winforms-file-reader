using System;
using System.IO;
using System.Windows.Forms;

namespace hw7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFileContent_Click(object sender, EventArgs e)
        {
            string filePath = txtMyInput.Text.Trim().Trim('"');
            
            if (filePath == "")
            {
                MessageBox.Show("Ви не вказали шлях до файлу!");
                return;
            }

            try
            {
                string fileContent = File.ReadAllText(filePath);
                textBox1.Text = fileContent;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не знайдено! Перевірте назву файлу");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Невірний шлях! Такої папки не існує:(");
            }
            catch (Exception)
            {
                MessageBox.Show("Не вдалося відкрити файл. Перевірте шлях до файлу");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMyInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}