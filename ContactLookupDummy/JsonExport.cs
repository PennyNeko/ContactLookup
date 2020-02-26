using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContactLookupDummy
{
    class JsonExport<Type>
    {
        private string JsonStringExport(Type objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
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

        protected void JsonSave(Type objectToSerialize, string fileName, string path = @"./../../../data/")
        {
            JsonStringSave(JsonStringExport(objectToSerialize),fileName, path);
        }
    }
}
