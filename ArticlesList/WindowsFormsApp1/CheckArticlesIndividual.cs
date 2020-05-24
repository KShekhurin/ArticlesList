using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CheckArticlesIndividual
    {
        public bool OneIsIndividual(ArticleInformation article, List<ArticleInformation> articles, ArticleInformation ignore)
        {
            foreach (ArticleInformation i in articles)
            {
                if (!i.Equals(ignore))
                {
                    if (i.id == article.id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool OneIsIndividual(ArticleInformation article, List<ArticleInformation> articles)
        {
            foreach (ArticleInformation i in articles)
            {
                if (i.id == article.id)
                {
                    return false;
                }
            }
            return true;
        }

        public bool HasntEmptyParametrs(ArticleInformation article)
        {
            if (article.name == "" || article.count == "" || article.prise == "" || article.productionDate == "" || article.shelfLife == "")
            {
                return false;
            }
            return true;
        }
    }
}
