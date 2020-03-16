using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactLookupDummy
{
    class JsonImport<Type>
    {
        private bool FileExists(string path)
        {
            return File.Exists(path);
        }
        private string GetJsonString(string fileName, string path)
        {
            path = path + fileName + ".json";
            if (FileExists(path))
            {
                return File.ReadAllText(path);

            }
            throw new Exception($"File doesn't exist at path: {path}.");
        }

        private Type GetObject(string fileName, string path)
        {
            return JsonConvert.DeserializeObject<Type>(GetJsonString(fileName, path));
        }
        protected Type JsonSave(string fileName, string path = @"./../../../data/")
        {
            return GetObject(fileName, path);
        }
    }
}
