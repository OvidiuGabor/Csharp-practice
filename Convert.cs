using System.Collections.Generic;
using System.IO;

namespace Practice_algo
{
    public class Convert
    { 
        
        public static IEnumerable<int> InputFile(string path)
        {
            using (TextReader text = File.OpenText(path))
            {
                string lastline;

                while ((lastline = text.ReadLine()) != null)
                {
                    yield return int.Parse(lastline);
                }
            }
        }

    }
}
