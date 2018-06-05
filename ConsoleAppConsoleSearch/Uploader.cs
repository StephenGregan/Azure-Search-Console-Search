using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppConsoleSearch
{
    class Uploader
    {

        private List<Welcome> PrepareDocuments()
        {
            List<Welcome> allContactsDocuments = new List<Welcome>();

            Welcome welcome = JsonConvert.DeserializeObject<Welcome>(File.ReadAllText("allcontacts.json"));

            using (StreamReader file = File.OpenText("allcontacts.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Welcome welcome2 = (Welcome)serializer.Deserialize(file, typeof(Welcome));
            }

            Welcome welcome5 = new Welcome()
            {


            };


            return allContactsDocuments;
            //List<Welcome> contactsDocuments = new List<Welcome>();

            //Welcome w1 = new Welcome();

            //string allcontacts = 

            //JsonConvert.PopulateObject(, w1);



            //Contacts m1 = new Contacts
            //{
            //    Id = "",
            //    Name = "",
            //    Active = false

            //};

            //Contacts m2 = new Contacts
            //{
            //    Id = "",
            //    Name = "",
            //    Active = true

            //};

            //Contacts m3 = new Contacts
            //{
            //    Id = "",
            //    Name = "",
            //    Active = false

            //};

            //Contacts m4 = new Contacts
            //{
            //    Id = "",
            //    Name = "",
            //   Active = true

            //};

            //contactsDocuments.Add(m1);
            //contactsDocuments.Add(m2);
            //contactsDocuments.Add(m3);
            //contactsDocuments.Add(m4);

            //return contactsDocuments;
            //return allContactsDocuments;
            

        }

        public void Upload(ISearchIndexClient indexClient)
        {
            try
            {
                var documents = PrepareDocuments();
                var batch = IndexBatch.Upload(documents);
                indexClient.Documents.Index(batch);
                Thread.Sleep(2000);
            }
            catch (IndexBatchException e)
            {
                Console.WriteLine($"Opps The Following index failed...\n { e.IndexingResults.Where(r => !r.Succeeded).Select(r => r.Key)}");

            }

        }
    }
}
