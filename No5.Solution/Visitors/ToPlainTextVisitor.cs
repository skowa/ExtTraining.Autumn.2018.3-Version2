using No5.Solution.DocumentParts;

namespace No5.Solution.Visitors
{
    internal class ToPlainTextVisitor : DocumentPartVisitor
    {
        protected override string Visit(BoldText boldText) => "**" + boldText.Text + "**";

        protected override string Visit(HyperLink hyperLink) => hyperLink.Text + " [" + hyperLink.Url + "]";

        protected override string Visit(PlainText plainText) => plainText.Text;
    }
}