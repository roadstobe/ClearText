using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClearText
{
    public partial class MainForm : Form
    {
        string correctText;
        string originalText;
        List<string> notAllow = new List<string>();
        List<string> stat = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            originalText = "";
        }

        //завантаження словника заборонених слів
        private void buttonLoadDictionary_Click(object sender, EventArgs e)
        {
            notAllow = NotAllowed.LoadNotAllowedWord().ToList();
            try
            {
                notAllow.ForEach((i) => textBoxFilter.Text += $"{i} ");
            }
            catch { }
            
        }
        //завантаження тексту
        private void button1_Click(object sender, EventArgs e)
        {
            string path = NotAllowed.GetPath();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    originalText = reader.ReadToEnd();
                }
                textBoxMainText.Text = originalText;
                //correctText = NotAllowed.CheckWord(textBoxMainText.Text, notAllow, ref stat);
                //textBoxMainText.Text = correctText;
                RepeatCodeCheckWord();
            }
            catch { }
           
            
        }

        //приховує або показує оригінал
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(b.Name == "buttonHide")
            {
                textBoxMainText.Text = originalText;
            }
            else
            {
                correctText = NotAllowed.CheckWord(textBoxMainText.Text, notAllow, ref stat);

                textBoxMainText.Text = correctText;

            }
        }

        //зберігає у файл
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                string path = "";
                using (SaveFileDialog file = new SaveFileDialog())
                {
                    Invoke(new MethodInvoker(() => 
                    {
                        if (file.ShowDialog() == DialogResult.OK)
                        {
                            path = file.FileName;
                            File.WriteAllText(path, correctText);
                            MessageBox.Show("Дані записано", "Successe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }));
                    
                }
            });
            
            
        }

        //швидке редагування
        private async void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            await Task.Run(Splitting);

            RepeatCodeCheckWord();
            
        }
        //Repeatet code
        public async void RepeatCodeCheckWord()
        {
            stat.Clear();
            await Task.Run(() => correctText = NotAllowed.CheckWord(originalText, notAllow, ref stat));
            textBoxMainText.Text = correctText;
            textBoxStat.Text = NotAllowed.FillStatic(stat);
        }
        //розділяє 
        public void Splitting()
        {
            //MessageBox.Show("I am in Spliting");
            //Thread.Sleep(5000);
            string text = textBoxFilter.Text;
            string[] splitted = text.Split(new char[] { ' ', '/', ',' });
            notAllow.Clear();
            notAllow = splitted.ToList();
        }
    }
}
