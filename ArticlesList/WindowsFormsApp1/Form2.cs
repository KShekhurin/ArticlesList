using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Text == "Add new article")
            {
                button2.Location = button3.Location;
                button3.Visible = false;
            }
            else if (Text == "Remake article's information")
            {
                textBox1.Text = FormsComunication.articles[FormsComunication.selectedArticleIndex].name;
                textBox2.Text = FormsComunication.articles[FormsComunication.selectedArticleIndex].count;
                textBox3.Text = FormsComunication.articles[FormsComunication.selectedArticleIndex].prise;
                textBox4.Text = FormsComunication.articles[FormsComunication.selectedArticleIndex].productionDate;
                textBox5.Text = FormsComunication.articles[FormsComunication.selectedArticleIndex].shelfLife;
            }
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Text == "Add new article")
            {
                CheckArticlesIndividual check = new CheckArticlesIndividual();
                ArticleInformation toAdd = new ArticleInformation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                if (check.OneIsIndividual(toAdd, FormsComunication.articles))
                {
                    if (check.HasntEmptyParametrs(toAdd))
                    {
                        FormsComunication.articles.Add(toAdd);
                        FormsComunication.changed = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Some text boxes are empty");
                    }
                }
                else
                {
                    MessageBox.Show("User with this number of phone or email in the list!");
                }
            }
            else if (Text == "Remake article's information")
            {
                CheckArticlesIndividual check = new CheckArticlesIndividual();
                ArticleInformation toAdd = new ArticleInformation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                if (check.OneIsIndividual(toAdd, FormsComunication.articles, FormsComunication.articles[FormsComunication.selectedArticleIndex]))
                {
                    if (check.HasntEmptyParametrs(toAdd))
                    {
                        FormsComunication.articles[FormsComunication.selectedArticleIndex] = toAdd;
                        FormsComunication.changed = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Some text boxes are empty");
                    }
                }
                else
                {
                    MessageBox.Show("User with this number of phone or email in the list!");
                }
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            FormsComunication.articles.RemoveAt(FormsComunication.selectedArticleIndex);
            FormsComunication.changed = true;
            Close();
        }
    }
}
