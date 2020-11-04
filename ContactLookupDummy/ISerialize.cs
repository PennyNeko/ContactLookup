namespace ContactLookupDummy
{
    interface ISerialize<Type>
    {
        void Save(Type objectToSerialize, string fileName, string path = "./../../../data/");
    }
}