using System;
using System.Collections.Generic;
using System.Text;

namespace Claims
{
    public class ClaimsRepository
    {
        protected readonly Queue<Claim> _claimQueue = new Queue<Claim>();

        public void ViewAll()
        {
            Console.WriteLine("ID...TYPE...DESCRIPTION...AMOUNT...DATE OF INCIDENT...DATE OF CLAIM...THIS IS A VALID CLAIM?");
            foreach (Claim loss in _claimQueue)
            {
                Console.WriteLine($"{loss.ClaimID}...{loss.Type}...{loss.Description}...{loss.Amount}...{loss.TimeOfIncident}" +
                    $"...{loss.TimeOfClaim}...{loss.IsValid}");
            }
        }

        public Claim NextClaim()   //Thank U, next!
        {
            Claim ariana = _claimQueue.Dequeue();
            Console.WriteLine("Here are the details for the next claim to be handled:");
            Console.WriteLine($"Claim ID: {ariana.ClaimID}\n" +
                $"Type: {ariana.Type}\n" +
                $"Description: {ariana.Description}\n" +
                $"Amount: {ariana.Amount}\n" +
                $"DateOfAccident: {ariana.TimeOfIncident}\n" +
                $"DateOfClaim: {ariana.TimeOfClaim}\n" +
                $"This is a Valid Claim: {ariana.IsValid}" );
            return ariana;
        }

        public void DealNow(Claim loss)
        {
            Console.WriteLine("Do you want to deal with this claim now? (y/n)");
            string input = Console.ReadLine();
            if (input == "y")
            {
                _claimQueue.Enqueue(loss);
            }
            else if (input =="n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Enter a 'y' or an 'n'");
                DealNow(loss);
            }
        }

        public bool AddClaim(Claim loss)

        {
            int startingCount = _claimQueue.Count;
            _claimQueue.Enqueue(loss);
            bool wasAdded = (_claimQueue.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public Claim CreateClaim()
        {
            Console.Clear();
            Claim loss = new Claim();
            Console.WriteLine("Please enter the Claim ID");
            loss.ClaimID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the description of claim:");
            loss.Description = Console.ReadLine();
            Console.WriteLine("Select Type of claim this is:");
            Console.WriteLine("0) Car \n" +
                "1) Home \n" +
                "2) Theft \n");
            int typeId = int.Parse(Console.ReadLine());
            loss.Type = (ClaimType)typeId;
            Console.WriteLine("Please enter damage amount");
            loss.Amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter date of incident (format mm/dd/yyyy");
            DateTime incidate = DateTime.Parse(Console.ReadLine());
            loss.TimeOfIncident = incidate;
            Console.WriteLine("Please enter date of claim (format mm/dd/yyyy");
            DateTime claim = DateTime.Parse(Console.ReadLine());
            loss.TimeOfClaim = claim;
             if ((loss.TimeOfIncident.Subtract(loss.TimeOfClaim).TotalDays) > 30)
            {
                loss.IsValid = false;
            }
            else
            {
                loss.IsValid = true;
            }
            return loss;

        }

        public void Data()
        {
            Claim loss1 = new Claim();
            loss1.ClaimID = 1;
            loss1.Type = (ClaimType)0;
            loss1.Description = "Car accident on 465";
            loss1.Amount = 400m;
            loss1.TimeOfIncident = DateTime.Parse("04/25/2018");
            loss1.TimeOfClaim = DateTime.Parse("04/27/2018");
            loss1.IsValid = true;
            AddClaim(loss1);
            Claim loss2 = new Claim();
            loss2.ClaimID = 2;
            loss2.Type = (ClaimType)1;
            loss2.Description = "House fire in kitchen";
            loss2.Amount = 4000m;
            loss2.TimeOfIncident = DateTime.Parse("04/11/2018");
            loss2.TimeOfClaim = DateTime.Parse("04/12/2018");
            loss2.IsValid = true;
            AddClaim(loss2);
            Claim loss3 = new Claim();
            loss3.ClaimID = 3;
            loss3.Type = (ClaimType)2;
            loss3.Description = "House fire in kitchen";
            loss3.Amount = 4m;
            loss3.TimeOfIncident = DateTime.Parse("04/27/2018");
            loss3.TimeOfClaim = DateTime.Parse("06/01/2018");
            loss3.IsValid = false;
            AddClaim(loss3);
        }
    }
}
