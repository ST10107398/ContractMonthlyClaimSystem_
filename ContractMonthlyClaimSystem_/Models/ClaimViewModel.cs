﻿namespace ContractMonthlyClaimSystem_.Models
{
    public class ClaimViewModel
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Notes { get; set; }
        public IFormFile SupportingDocument { get; set; }
    }

}
