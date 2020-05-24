using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ArticleInformation
    {
        public int id = IdCreator.CreateId();
        public string name;
        public string count;
        public string prise;
        public string productionDate;
        public string shelfLife;

        public ArticleInformation()
        {

        }

        public ArticleInformation(string name, string count, string prise, string productionDate, string shelfLife)
        {
            this.name = name;
            this.count = count;
            this.prise = prise;
            this.productionDate = productionDate;
            this.shelfLife = shelfLife;
        }

        public override string ToString()
        {
            return $"Name: {name}, Count: {count}, Prise: {prise}, Production date: { productionDate}, Shelf life: {shelfLife}";
        }
    }
}
