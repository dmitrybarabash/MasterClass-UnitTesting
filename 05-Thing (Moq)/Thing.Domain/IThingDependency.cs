namespace Thing.Domain
{
    public interface IThingDependency
    {
        string JoinUpper(string a, string b);
        int Meaning { get; }
    }
}
