using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtendedTextEditor
{
    class ClassFinder
    {
        private string request = null;
        private int indexActiveRequest = -2;
        private List<RequestIndexes> requestIndexesArray = new List<RequestIndexes>();
        private bool isMatchWholeWordOnly = false;
        private bool isMatchCase = false;

        public ClassFinder(string text, string request, bool isMatchWholeWordOnly, bool isMatchCase)
        {
            this.request = request;
            this.isMatchWholeWordOnly = isMatchWholeWordOnly;
            this.isMatchCase = isMatchCase;
            requestIndexesArray = Find(text);
            if (requestIndexesArray.Count != 0) indexActiveRequest = -1;
        }

        public int Length { get => requestIndexesArray.Count; }
        public RequestIndexes[] RequestIndexesArray { get => requestIndexesArray.ToArray(); }

        public bool IsEmpty() { return Length == 0; }

        public RequestIndexes Next()
        {
            if (requestIndexesArray.Count == 0) return null;

            if ((indexActiveRequest + 1) == requestIndexesArray.Count) indexActiveRequest = -1;
            return requestIndexesArray[++indexActiveRequest];
        }

        public RequestIndexes Prev()
        {
            if (requestIndexesArray.Count == 0) return null;

            if ((indexActiveRequest - 1) <= -1) indexActiveRequest = requestIndexesArray.Count;
            return requestIndexesArray[--indexActiveRequest];
        }

        private List<RequestIndexes> Find(string text)
        {
            if (request == null) return null;

            string pattern;
            if (isMatchWholeWordOnly) pattern = @"\b" + request + @"\b";
            else pattern = request;

            RegexOptions regexOptions;
            if (isMatchCase) regexOptions = RegexOptions.None;
            else regexOptions = RegexOptions.IgnoreCase;

            Regex regex = new Regex(pattern, regexOptions);
            MatchCollection matchCollection = regex.Matches(text);

            List<RequestIndexes> requests = new List<RequestIndexes>();
            foreach (Match m in matchCollection) requests.Add(new RequestIndexes(m.Index, m.Index + request.Length));

            return requests;
        }

        public void RemoveCurrentMatch()
        {
            if (indexActiveRequest >= 0) requestIndexesArray.RemoveAt(indexActiveRequest--);
        }

        public void RemoveAllMatch()
        {
            requestIndexesArray.RemoveRange(0, Length);
        }
    }

    public class RequestIndexes
    {
        private int indexStartOfRequest;
        private int indexEndOfRequest;

        public RequestIndexes(int indexStart, int indexEnd)
        {
            indexStartOfRequest = indexStart;
            indexEndOfRequest = indexEnd;
        }

        public int IndexStart { get => indexStartOfRequest; }
        public int IndexEnd { get => indexEndOfRequest; }
    }
}
