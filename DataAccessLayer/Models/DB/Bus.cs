using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models.DB;

public partial class Bus
{
    public int BusId { get; set; }

    public string? BusName { get; set; }

    public string? BusNo { get; set; }

    public int? NoOfSeates { get; set; }

    public int? InsurenceId { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<BusRoute> BusRoutes { get; set; } = new List<BusRoute>();
}
