using System.Collections.Generic;
using No5.Solution.DocumentParts;

namespace No5.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
            {
                new BoldText {Text = "some boldText"},
                new HyperLink {Text = "some hyperlink", Url = "url"},
                new PlainText {Text = "some plain text"},
                new HyperLink {Text = "some hyperlink2"}
            };

            var doc = new Document(parts);
            System.Console.WriteLine(doc.ConvertToHtml());
            System.Console.WriteLine(doc.ConvertToLaTeX());
            System.Console.WriteLine(doc.ConvertToPlainText());
        }
    }
}
