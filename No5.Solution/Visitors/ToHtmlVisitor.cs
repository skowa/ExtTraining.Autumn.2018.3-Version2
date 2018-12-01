using No5.Solution.DocumentParts;

namespace No5.Solution.Visitors
{
    internal class ToHtmlVisitor : DocumentPartVisitor
    {
        protected override string Visit(BoldText boldText) => "<b>" + boldText.Text + "</b>";

        protected override string Visit(HyperLink hyperLink) => "<a href=\"" + hyperLink.Url + "\">" + hyperLink.Text + "</a>";

        protected override string Visit(PlainText plainText) => plainText.Text;
    }
}