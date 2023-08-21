using System;
using System.ComponentModel.DataAnnotations;
using StaFlux.Structure.Base;

namespace StaFlux.Structure.Entities;

public class MachineState : Entity
{
    [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(FluxSource))]
    public int Level
    {
        get;
        set;
    }

    [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(FluxSource))]
    public string Title
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }
}
