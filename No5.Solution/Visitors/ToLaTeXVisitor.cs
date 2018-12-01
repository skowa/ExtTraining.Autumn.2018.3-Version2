using No5.Solution.DocumentParts;

namespace No5.Solution.Visitors
{
    internal class ToLaTeXVisitor : DocumentPartVisitor
    {
        protected override string Visit(BoldText boldText) => "\\textbf{" + boldText.Text + "}";

        protected override string Visit(HyperLink hyperLink) => "\\href{" + hyperLink.Url + "}{" + hyperLink.Text + "}";

        protected override string Visit(PlainText plainText) => plainText.Text;
    }
}