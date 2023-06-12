// Before we start trying to assemble the perfect crew, we need to know who our options are. Let's build out a robbersList of possible recruits first. We'll pick the team and plan out the actual operation later.


using System;

using System.Collections.Generic;

using System.Linq;

    class Program
    {
        static void Main()
{

  
// In the Main method, create a List<IRobber> and store it in a variable named robbersList. This list will contain all possible operatives that we could employ for future heists. We want to give the user the opportunity to add new operatives to this list, but for now let's pre-populate the list with 5 or 6 robbers (give it a mix of Hackers, Lock Specialists, and Muscle).  
List<IRobbers> robbersList = new List <IRobbers>();
         robbersList.Add(new Hacker() 

         {
        Name = "Hoagie", 
        SkillLevel = 72, 
        PercentageCut = 40,

        });

         robbersList.Add(new Hacker() 
         {
        Name = "Wilbur", 
        SkillLevel = 30, 
        PercentageCut = 15,

         });

        robbersList.Add(new Muscle() 
        {  
        Name = "Birdie", 
        SkillLevel = 60, 
        PercentageCut = 30,
        });
      
       robbersList.Add(new Muscle() 
        {  
        Name = " Mother", 
        SkillLevel = 25, 
        PercentageCut = 5,
        });

        robbersList.Add(new LockSpecialist() 
        {  
        Name = "Dilly", 
        SkillLevel = 50, 
        PercentageCut = 30,
        });

        robbersList.Add(new LockSpecialist() 
        {     
        Name = "Bonnie", 
        SkillLevel = 40, 
        PercentageCut = 30,
        });


// When the program starts, print out the number of current operatives in the robbersList. Then prompt the user to enter the name of a new possible crew member. Once the user has entered a name, print out a list of possible specialties and have the user select which specialty this operative has. The list should contain the following options

// Hacker (Disables alarms)
// Muscle (Disarms guards)
// Lock Specialist (cracks vault)
// Once the user has selected a specialty, prompt them to enter the crew member's skill level as an integer between 1 and 100. Then prompt the user to enter the percentage cut the crew member demands for each mission. Once the user has entered the crew member's name, specialty, skill level, and cut, you should instantiate the appropriate class for that crew member (based on their specialty) and they should be added to the robbersList.
while (true){
 Console.WriteLine($"There are currently {robbersList.Count} criminals on the roster.");

 Console.WriteLine("Enter the name of a new crew member.");
 string Name = Console.ReadLine();

Console.WriteLine($"What is {Name}'s speciality? Choose 1 for hacker (Disables alarms), 2 for muscle (Disarms guards), or 3 for lock specialist (cracks vault)");

int Speciality= Convert.ToInt32(Console.ReadLine());


            if (Speciality == 1)
            {
                robbersList.Add(new Hacker()); 
            }

            else if (Speciality == 2) 
            {
                robbersList.Add(new Muscle()); 
            }

            else if (Speciality == 3)
            {
                robbersList.Add(new LockSpecialist()); 
            }

Console.WriteLine($"How skilled of a criminal is {Name}? Enter a number between 1 and 100 with 100 being the most skilled:");
int SkillLevel = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"What is {Name}'s cut of the stolen $$?");
int PercentageCut =  Convert.ToInt32(Console.ReadLine());
}

// Once the user is finished with their rolodex, it's time to begin a new heist

// The program should create a new bank object and randomly assign values for these properties:
Random random = new Random();

// AlarmScore (between 0 and 100)
// VaultScore (between 0 and 100)
// SecurityGuardScore (between 0 and 100)
// CashOnHand (between 50,000 and 1 million)

    Bank bank = new Bank(){      

    BankName = "Bank of Treatos",
    AlarmScore = random.Next(0, 100),
    VaultScore = random.Next(0, 100),
    SecurityGuardScore = random.Next(0, 100),
    CashOnHand = random.Next(50000, 1000000),};

    
// Let's do a little recon next. Print out a Recon Report to the user. This should tell the user what the bank's most secure system is, and what its least secure system is (don't print the actual integer scores--just the name, i.e. Most Secure: Alarm Least Secure: Vault
{
    if(bank.AlarmScore > bank.VaultScore && bank.AlarmScore > bank.SecurityGuardScore)
    {
        Console.WriteLine($"The {bank.BankName}'s most secure system is the Alarm System"); 

    }

    else if(bank.VaultScore > bank.AlarmScore && bank.VaultScore > bank.SecurityGuardScore )
    {
    Console.WriteLine($"The {bank.BankName}'s most secure system is the Vault System");  

    }
    else if(bank.SecurityGuardScore > bank.AlarmScore && bank.SecurityGuardScore > bank.VaultScore)
    {
        Console.WriteLine($"The {bank.BankName}'s most secure system is the Security Guard Team");

    }

// Print out a report of the rolodex that includes each person's name, specialty, skill level, and cut. Include an index in the report for each operative so that the user can select them by that index in the next step. (You may want to update the IRobber interface and/or the implementing classes to be able to print out the specialty)
Console.WriteLine("Select your robbery team"); 
int totalCut = 0;
List<IRobbers> team = new List<IRobbers>();


while(true){

for(int i = 0; i< robbersList.Count; i++){
if(!team.Contains(robbersList[i]) && ( robbersList[i].PercentageCut + totalCut) < 100){
Console.WriteLine("**********************");    
Console.WriteLine($"Press {i+1} to choose robber");
Console.WriteLine($"{robbersList[i].Name}");
Console.WriteLine($"{robbersList[i].Type}");
Console.WriteLine($"{robbersList[i].SkillLevel}");
Console.WriteLine($"{robbersList[i].PercentageCut}");
Console.WriteLine("**********************");
}}

string? selection = Console.ReadLine();
team.Add(robbersList[int.Parse(selection) - 1]);
totalCut = team.Sum(x => x.PercentageCut);
Console.WriteLine(totalCut); 
if(selection == ""){
    break;

}

foreach (IRobbers robber in team){
    robber.PerformSkill(bank);
}
if (bank.IsSecure())
{
    Console.WriteLine("Failure");
}
    else {
        Console.WriteLine("The heist was a success");
        int myCut = 100- team.Sum(x => x.PercentageCut);
        team.ForEach(x => Console.WriteLine($"Well done {x.Name}. Your take is {(bank.CashOnHand * x.PercentageCut/100)}"));
        Console.WriteLine($"Our take is {(bank.CashOnHand * myCut)/100}");
}}}}}



// Now that we have a clue what kind of security we're working with, we can try to built out the perfect crew.

// Print out a report of the rolodex that includes each person's name, specialty, skill level, and cut. Include an index in the report for each operative so that the user can select them by that index in the next step. (You may want to update the IRobber interface and/or the implementing classes to be able to print out the specialty)

// Create a new List<IRobber> and store it in a variable called crew. Prompt the user to enter the index of the operative they'd like to include in the heist. Once the user selects an operative, add them to the crew list.

// Allow the user to select as many crew members as they'd like from the rolodex. Continue to print out the report after each crew member is selected, but the report should not include operatives that have already been added to the crew, or operatives that require a percentage cut that can't be offered.

// Once the user enters a blank value for a crew member, we're ready to begin the heist. Each crew member should perform his/her skill on the bank. Afterwards, evaluate if the bank is secure. If not, the heist was a success! Print out a success message to the user. If the bank does still have positive values for any of its security properties, the heist was a failure. Print out a failure message to the user.

// If the heist was a success, print out a report of each members' take, along with how much money is left for yourself.