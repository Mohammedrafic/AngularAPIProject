using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models.DB;

public partial class Location
{
    public Guid LocationId { get; set; }

    public string? Lname { get; set; }

    public Guid? StateId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual State? State { get; set; }
}
