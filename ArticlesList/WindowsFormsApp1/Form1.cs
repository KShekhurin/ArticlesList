using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Thread thisThread = Thread.CurrentThread;
        Articles articlesList = new Articles();

        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Thread LBUpdater = new Thread(UpdateLB);
            LBUpdater.Start();
        }
        private void UpdateLB()
        {
            while (true)
            {
                if (!thisThread.IsAlive)
                {
                    Thread.CurrentThread.Abort();
                }
                if (FormsComunication.changed)
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < FormsComunication.articles.Count; i++)
                    {
                        listBox1.Items.Add(FormsComunication.articles[i]);
                    }
                    FormsComunication.changed = false;
                    articlesList.articles = FormsComunication.articles;
                }
            }
        }
        private void BtnAddToList(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Text = "Add new article";
            form.Show();
        }
        private void LbSelect(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < FormsComunication.articles.Count)
            {
                Form2 form = new Form2();
                form.Text = "Remake article's information";
                FormsComunication.selectedArticleIndex = listBox1.SelectedIndex;
                listBox1.ClearSelected();
                form.Show();
            }
        }

        private void BtnClearArticlesList(object sender, EventArgs e)
        {
            FormsComunication.articles.Clear();
            FormsComunication.changed = true;
        }

        private void FSaveInformation(object sender, FormClosingEventArgs e)
        {
            XmlExporter<Articles> exporter = new XmlExporter<Articles>();
            exporter.ExportList("ArticlesList.xml", articlesList);
        }

        private void FOpenFile(object sender, EventArgs e)
        {
            try
            {
                XmlImporterToUsers importer = new XmlImporterToUsers();
                FormsComunication.articles = importer.Import("ArticlesList.xml").articles;
                FormsComunication.changed = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open file");
            }
        }
    }
}
