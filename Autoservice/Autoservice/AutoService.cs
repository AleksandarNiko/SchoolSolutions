using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice
{
    public class AutoService
    {
        public  string Name { get; set; }

        private List<Client> clients;

        public AutoService(string name) 
        {
            Name= name;
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public Client FindClientByName(string name)
        {
            var currClient = clients
                .FirstOrDefault(c => c.Name == name);

            return currClient;
        }

        public Client FindClientByCar(string carName) 
        {
            var currClient = clients
                .FirstOrDefault(c=>c.Automobile==carName);

            return currClient;
        }

        public IEnumerable<Client> FindClientsByProblem(string problem)
        {
            var currClient = clients
                .Where(c => c.Problem == problem);

            return currClient;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Clients info:");

            foreach (var client in clients) 
            {
                sb.AppendLine(client.ToString());
            }

            return sb.ToString();
        }
    }
}
