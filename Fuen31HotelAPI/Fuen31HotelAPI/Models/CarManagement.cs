﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Fuen31HotelAPI.Models;

public partial class CarManagement
{
    public int Id { get; set; }

    public int Capacity { get; set; }

    public string Brand { get; set; }

    public string Goal { get; set; }

    public string CarModel { get; set; }

    public string CarIdentity { get; set; }

    public virtual ICollection<CarResponsible> CarResponsibles { get; set; } = new List<CarResponsible>();
}