using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp1
{
    class XmlExporter<T>
    {
        public void ExportList(string path, T toXml)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(T));
            xs.Serialize(fs, toXml);
            fs.Close();
        }
    }
}
