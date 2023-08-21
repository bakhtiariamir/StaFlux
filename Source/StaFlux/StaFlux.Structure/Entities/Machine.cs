using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StaFlux.Structure.Base;

namespace StaFlux.Structure.Entities;
[Table(nameof(Machine), Schema = "Flow")]
public class Machine : Entity
{
    [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(FluxSource))]
    [StringLength(1024, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(FluxSource), MinimumLength = 5)]
    public string Name
    {
        get;
        set;
    } = string.Empty;

    [StringLength(1024, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(FluxSource))]
    public string Title
    {
        get;
        set;
    } = string.Empty;


    [Required(AllowEmptyStrings = false, ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(FluxSource))]
    [StringLength(1024, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(FluxSource), MinimumLength = 5)]
    public string Version
    {
        get;
        set;
    } = "1.0";

    public string Source
    {
        get;
        set;
    } = string.Empty;


    public string? LastVersionSupport
    {
        get;
        set;
    }

    [Required]
    public ResultType ResultType
    {
        get;
        set;
    } = ResultType.None;

    [Required]
    public IEnumerable<LinkedList<MachineState>>? States
    {
        get;
        set;
    }

    [Required]
    public IEnumerable<MachineTrigger>? Triggers
    {
        get;
        set;
    }
}

public class MachineConfiguration : IEntityTypeConfiguration<Machine>
{
    public void Configure(EntityTypeBuilder<Machine> builder)
    {
        builder.HasIndex(p => p.Name).IsUnique();
    }
}

public class MachineTrigger
{
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


public enum ResultType
{
    None,
    Scalar,
    Records
}