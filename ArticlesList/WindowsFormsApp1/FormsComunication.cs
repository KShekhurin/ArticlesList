using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class FormsComunication
    {
        static public List<ArticleInformation> articles = new List<ArticleInformation>();
        static public int selectedArticleIndex;
        static public bool changed = false;
    }
}
