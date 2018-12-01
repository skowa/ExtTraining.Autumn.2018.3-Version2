using System;
using System.Collections.Generic;
using No5.Solution.DocumentParts;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this.parts = new List<DocumentPart>(parts);
        }

        public IEnumerable<DocumentPart> Parts
        {
            get
            {
                foreach (var part in parts)
                {
                    yield return part;
                }
            }
        }
    }
}