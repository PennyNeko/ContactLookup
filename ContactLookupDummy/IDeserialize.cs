namespace ContactLookupDummy
{
    interface IDeserialize<Type>
    {
        Type Load(string fileName, string path = "./../../../data/");
    }
}