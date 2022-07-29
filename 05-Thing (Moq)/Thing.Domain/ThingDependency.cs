using System;

namespace Thing.Domain;

// "Real" implementation
public class ThingDependency : IThingDependency
{
    public string JoinUpper(string a, string b) =>
        throw new NotImplementedException();

    public int Meaning =>
        throw new NotImplementedException();
}
