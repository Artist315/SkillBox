
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

        public bool GetWorkerById(int id, out Worker worker)
        {
            var input = ReadFile();

            if (input.Any(x => x.Id == id))
            {
                worker = input.FirstOrDefault(x => x.Id == id);
                return true;
            }
            worker = new Worker();
            return false;
        }

        public void DeleteWorkerById(int id)
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

            _workers.Clear();
            _workers = GetAllWorkers().ToList();
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            var input = ReadFile();

            return input.Where(x => x.CreatedAt > dateFrom && x.CreatedAt < dateTo).ToArray();
        }

        public void Clear()
        {
            _workers.Clear();
            File.Delete(_fileName);

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

        public List<Worker> GetWorkerByCreatedAt(string dateFromRaw, string dateToRaw)
        {
            try
            {
                DateTime dateFrom = Convert.ToDateTime(dateFromRaw);
                DateTime dateTo = Convert.ToDateTime(dateToRaw);

                return GetByDate(dateFrom, dateTo);
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильный формат дат");
                return new List<Worker>();
            }
        }

        private List<Worker> GetByDate(DateTime dateFrom, DateTime dateTo)
        {
            var input = ReadFile();
            var result = input.Where(x => x.CreatedAt > dateFrom && x.CreatedAt < dateTo).ToList();
            return result;
        }

        private void WriteToFile(Worker worker)
        {
            using (StreamWriter writer = new StreamWriter(_fileName, true))
            {
                writer.WriteLine(worker.ToStoreFormat());
                writer.Flush();
            }
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
