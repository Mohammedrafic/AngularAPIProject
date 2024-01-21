using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models.DB;

public partial class BusRoute
{
    public int Id { get; set; }

    public string? Tripcode { get; set; }

    public string? ViaRoute { get; set; }

    public string? RouteNo { get; set; }

    public int? BusId { get; set; }

    public string? Startpoint { get; set; }

    public string? Destination { get; set; }

    public TimeSpan? Timing { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Bus? Bus { get; set; }
}
