using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    class XmlImporterToUsers
    {
        public Articles Import(string path)
        {
            Articles users = new Articles();
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Articles));
            users = (Articles)xs.Deserialize(fs);
            fs.Close();
            return users;
        }
    }
}
