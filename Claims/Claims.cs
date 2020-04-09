using System;
using System.Collections.Generic;
using System.Text;

namespace Claims
{
    public enum ClaimType {Car, Home, Theft }
class Claim
    {       
        public int ClaimID { get; set; }
        public ClaimType Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime TimeOfIncident { get; set; }
        public DateTime TimeOfClaim { get; set; }
        public bool IsValid { get; set; }
        public Claim() { }

        public Claim(int claimid, ClaimType type, string description, decimal amount, DateTime timeofincident, DateTime timeofclaim, bool isvalid)
        {
            ClaimID = claimid;
            Type = type;
            Description = description;
            Amount = amount;
            TimeOfIncident = timeofincident;
            TimeOfClaim = timeofclaim;
            IsValid = isvalid;
        }
    }
}
