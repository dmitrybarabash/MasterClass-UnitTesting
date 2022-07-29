namespace Thing.Domain;

// Class we want to test in isolation of ThingDependency
public class ThingBeingTested
{
    private readonly IThingDependency _thingDependency;

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ThingBeingTested(IThingDependency thingDependency) =>
        _thingDependency = thingDependency;

    public string MakeThingPurpose() =>
        $"{_thingDependency.JoinUpper(FirstName, LastName)} = {_thingDependency.Meaning}";
}
