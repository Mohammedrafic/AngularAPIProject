using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models.DB;

public partial class State
{
    public Guid StateId { get; set; }

    public string? StateName { get; set; }

    public Guid? CountryId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
