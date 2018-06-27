using Microsoft.Azure.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConsoleSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            string serviceName = "[USERNAME]";

            string apiKey = "[PASSWORD]";

            SearchServiceClient serviceClientApi = Helper.Initialize(serviceName, apiKey);
            ISearchIndexClient indexClientApi = serviceClientApi.Indexes.GetClient(Helper.IndexName);

            Uploader uploader = new Uploader();
            uploader.Upload(indexClientApi);

            Searcher searcher = new Searcher();

            Console.WriteLine("Search by name....\n");
            searcher.SearchDocuments(indexClientApi, "NAME");
            Console.WriteLine(string.Empty);

            //Console.WriteLine("Search for status active....\n");
            //searcher.SearchDocuments(indexClientApi, "*", "Active eq 'true'");
            //Console.WriteLine(string.Empty);

            //Console.WriteLine("Begin searching by ..... facet\n");
            List<string> facets = new List<string>();
            facets.Add("Category");
            //apiKey.SearchDocuments(indexClientApi, "*", null, facets);

            Console.ReadLine();
        }
    }
}
