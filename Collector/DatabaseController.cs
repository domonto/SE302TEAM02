using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Newtonsoft.Json.Linq;

namespace Collector
{
    class DatabaseController
    {
        private LiteDatabase db = new LiteDatabase("data.db");

        public string RemoveTurkishCharacters(string text)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("Cyrillic").GetBytes(text);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        public IEnumerable<CustomCollection> getCollections()
        {

            var customCollections = db.GetCollection<CustomCollection>("customCollections");
            var results = customCollections.FindAll();
            return results;

        }

        public LiteCollection<CustomCollection> getCustomCollection()
        {

            var col = db.GetCollection<CustomCollection>("customCollections");
            return col;
        }

        public List<dynamic> getDocuments(CustomCollection collection)
        {

            var col = db.GetCollection(collection.name);
            var results = col.Find(Query.All(Query.Descending));

            List<dynamic> resultsList = new List<dynamic>();

            foreach (BsonDocument doc in results)
            {
                dynamic d = JObject.Parse(doc.ToString());
                resultsList.Add(d);
            }
            return resultsList;

        }

        public void createCollection(String collectionName, List<Attribute> attributes)
        {

            var col = db.GetCollection<CustomCollection>("customCollections");
            var results = col.FindAll();

            var customCollection = new CustomCollection
            {
                name = RemoveTurkishCharacters(collectionName),
                aliase = collectionName,
                attributes = attributes,
            };

            col.Insert(customCollection);

        }

        public void updateCollection(CustomCollection collection, List<Attribute> attributes)
        {

            var col = db.GetCollection<CustomCollection>("customCollections");

            CustomCollection result = col.FindOne(Query.EQ("name", collection.name));
            result.attributes = attributes;
            col.Update(result);

        }

        public void deleteCollection(CustomCollection collection)
        {

            var col = db.GetCollection<CustomCollection>("customCollections");
            col.Delete(Query.EQ("name", collection.name));
            db.DropCollection(collection.name);

        }

        public List<dynamic> searchCollection(CustomCollection collection, String field, String key)
        {

            var col = db.GetCollection(collection.name);
            var results = col.Find(Query.Contains(field, key));

            List<dynamic> searchResults = new List<dynamic>();

            foreach (BsonDocument doc in results)
            {
                dynamic d = JObject.Parse(doc.ToString());
                searchResults.Add(d);
            }

            return searchResults;

        }

        public void createDocument(CustomCollection collection, BsonDocument item)
        {

            var col = db.GetCollection(collection.name);
            col.Insert(item);

        }

        public void updateDocument(CustomCollection collection, BsonDocument item)
        {

            var col = db.GetCollection(collection.name);
            col.Update(item);

        }


        public void deleteDocument(CustomCollection collection, List<ObjectId> documentIds)
        {

            var col = db.GetCollection(collection.name);

            foreach (ObjectId id in documentIds)
            {
                col.Delete(id);
            }

        }
    }
}
