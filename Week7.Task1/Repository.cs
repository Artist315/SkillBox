
namespace Week7.Task1
{
    public class Repository
    {
        private List<Worker> _workers = new List<Worker>();
        private string _fileName;

        public Worker[] GetAllWorkers()
        {
            var input = ReadFile();

            return input.ToArray();
        }

        public Worker GetWorkerById(int id)
        {
            var input = ReadFile();

            return input.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteWorker(int id)
        {
            var input = ReadFile();

            try
            {
                var worker = input.FirstOrDefault(x => x.Id == id);
                input.Remove(worker);

                _workers = input;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddWorker(Worker worker)
        {
            CreateIfFileNotExists();

            WriteToFile(worker);
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            var input = ReadFile();

            return input.Where(x => x.CreatedAt > dateFrom && x.CreatedAt < dateTo).ToArray();
        }

        #region PrivateFunctions

        private void CreateIfFileNotExists()
        {
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName).Close();
            }
        }

        private List<Worker> ReadFile()
        {
            CreateIfFileNotExists();

            if (_workers != null && _workers.Any())
            {
                return _workers;
            }

            List<string> stringResult = new List<string>();

            using (StreamReader reader = new StreamReader(_fileName))
            {
                string line;
                do
                {
                    line = reader.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        stringResult.Add(line);
                    }
                } while (!string.IsNullOrEmpty(line));
            }

            return stringResult?.Select(x => new Worker(x)).ToList() ?? new List<Worker>();
        }

        private void WriteToFile(Worker worker)
        {
            using (StreamWriter writer = new StreamWriter(_fileName, true))
            {
                writer.WriteLine(worker.ToString());
                writer.Flush();
            }

            _workers = GetAllWorkers().ToList();
        }

        public void SetDirectory(string fileName)
        {
            if (string.IsNullOrEmpty(_fileName))
            {
                _fileName = fileName;
            }
        }

        #endregion
    }
}
