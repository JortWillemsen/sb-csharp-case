﻿namespace SBAddressAPI.Controllers
{
    public class UpdateAddressDto
    {
        public string? Street { get; set; }
        public int HomeNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}