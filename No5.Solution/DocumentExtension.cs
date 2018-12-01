using No5.Solution.Visitors;

namespace No5.Solution
{
    /// <summary>
    /// The <see cref="Document"/> extension class.
    /// </summary>
    public static class DocumentExtension
    {
        /// <summary>
        /// Converts <paramref name="document"/> to html.
        /// </summary>
        /// <param name="document">
        /// The document to be converted.
        /// </param>
        /// <returns>
        /// The converted string.
        /// </returns>
        public static string ConvertToHtml(this Document document) => Convert(document, new ToHtmlVisitor());

        /// <summary>
        /// Converts <paramref name="document"/> to LaTeX.
        /// </summary>
        /// <param name="document">
        /// The document to be converted.
        /// </param>
        /// <returns>
        /// The converted string.
        /// </returns>
        public static string ConvertToLaTeX(this Document document) => Convert(document, new ToLaTeXVisitor());

        /// <summary>
        /// Converts <paramref name="document"/> to plain text.
        /// </summary>
        /// <param name="document">
        /// The document to be converted.
        /// </param>
        /// <returns>
        /// The converted string.
        /// </returns>
        public static string ConvertToPlainText(this Document document) => Convert(document, new ToPlainTextVisitor());

        private static string Convert(this Document document, DocumentPartVisitor visitor)
        {
            string output = string.Empty;

            foreach (var part in document.Parts)
            {
                output += $"{visitor.Visit(part)}\n";
            }

            return output;
        }
    }
}