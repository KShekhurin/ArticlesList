using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Articles
    {
        public List<ArticleInformation> articles = new List<ArticleInformation>();
        public Articles()
        {
        }
        public Articles(List<ArticleInformation> articles)
        {
            this.articles = articles;
        }
    }
}
