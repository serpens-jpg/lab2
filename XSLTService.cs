using System.Xml;
using System.Xml.Xsl;

namespace _8xml
{
    public class XSLTService : IXSLTService
    {
        public void ToXSLT(string xmlPath, string xsltPath, string htmlPath)
        {
            var table = new XslCompiledTransform();
            table.Load(xsltPath);

            using (var w = XmlWriter.Create(htmlPath))
            {
                table.Transform(xmlPath, w);
            }
        }
    }
}
