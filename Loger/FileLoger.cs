namespace OopPrinciple
{
    public class FileLoger : ILoger
    {
        private readonly string _filePath;

        public FileLoger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string msg)
        {
            try
            {
                System.IO.File.WriteAllText(_filePath, msg);
            }
            catch (System.Exception)
            {


            }
        }
    }
}
