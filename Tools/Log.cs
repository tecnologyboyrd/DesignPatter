namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;

        private string fileLog;

        public static Log GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new Log(path);
            }

            return _instance;
        }
        private Log(string path)
        {

            fileLog = path;

        }

        public void Save(string message)
        {
            File.AppendAllText(fileLog, message + Environment.NewLine);
        }
    }
}