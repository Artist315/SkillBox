using System.Text.Json;
using Week12.Storage.Data.BankClient;

namespace Week12.Storage.Storage
{
    public static class DataStorage
    {
        private const string Path = "TestStorageWeek12.json";
        private static List<BankClient> clients; 
        public static void AddClient(string name)
        {

            BankClient client = new BankClient()
            {
                Id = Guid.NewGuid(),
                Name = name,

            };
            clients.Add(client);

            Save();
        }

        public static bool CheckExistingClients(string name)
        {
            if (clients == null)
            {
                clients = GetClients();
            }
            return clients.Any(x => x.Name == name);
        }

        public static List<BankClient> GetClients()
        {
            var json = File.Exists(Path) ? File.ReadAllText(Path) : string.Empty;

            var result = new List<BankClient>();

            if (!string.IsNullOrEmpty(json))
            {
                result = JsonSerializer.Deserialize<List<BankClient>>(json);
            }
            return result;
        }

        private static bool Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(clients);

                File.WriteAllText(Path, json);

                clients = GetClients();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
