﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Fuen31HotelAPI.Models;

public partial class CarCartItem
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public string PickUpLongtitude { get; set; }

    public string PickUpLatitude { get; set; }

    public string DestinationLatitude { get; set; }

    public string DestinationLongtitude { get; set; }

    public decimal SubTotal { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime ActualStartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime ActualEndTime { get; set; }
}