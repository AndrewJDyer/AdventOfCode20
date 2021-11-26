using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace One
{
    class Parser
    {
        private readonly string filename;

        public Parser(string filename) => this.filename = filename;

        public IEnumerable<int> Parse()
        {
            foreach (var line in ReadAllLines())
            {
                if (Int32.TryParse(line, out var number))
                    yield return number;
            }
        }

        private IEnumerable<string> ReadAllLines()
        {
            try
            {
                return File.ReadAllLines(filename);
            }
            catch (IOException)
            {
                return Enumerable.Empty<string>();
            }
        }
    }
}