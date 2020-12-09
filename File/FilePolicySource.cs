using System.IO;

namespace OopPrinciple
{
    public class FilePolicySource : IPolicySource
    {
        private readonly string _filePath;

        public FilePolicySource(string filePath)
        {
            _filePath = filePath;
        }

        public string GetPolicyFromSource()
        {
            return File.ReadAllText(_filePath);
        }
    }
}
