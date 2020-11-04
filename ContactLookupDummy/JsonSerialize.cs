using Newtonsoft.Json;
using System.IO;

namespace ContactLookupDummy
{
    class JsonSerialize<Type> : ISerialize<Type>
    {
        private string JsonStringExport(Type objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }

        private bool FileExists(string path)
        {
            return File.Exists(path);
        }
        private void JsonStringSave(string jsonString, string fileName, string path)
        {
            path = path + fileName + ".json";
            if (!FileExists(path))
            {

            }
            File.WriteAllText(path, jsonString);
        }

        public void Save(Type objectToSerialize, string fileName, string path = @"./../../../data/")
        {
            JsonStringSave(JsonStringExport(objectToSerialize), fileName, path);
        }
    }
}
