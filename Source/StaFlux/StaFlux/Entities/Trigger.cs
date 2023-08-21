using StaFlux.Contracts.Entities;
using StaFlux.Core;

namespace StaFlux.Entities;
internal class Trigger : Entity, ITrigger
{
    public string Name
    {
        get;
        set;
    }

    public string Title
    {
        get;
        set;
    }

    public Machine Machine
    {
        get;
        set;
    }
}