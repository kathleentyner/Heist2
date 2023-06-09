// Since bank security consists of alarms, vaults, and security guards; we'll need crew members that can deal with each of them. We'll need hackers to take care of the alarms; lock pick specialists to crack the vaults, and some good old fashion muscle to handle the security guards. Create three classes: Hacker, Muscle, and LockSpecialist. They should all implement the IRobber interface. Each implementation for PerformSkill should do three things:


using System;

public class Hacker : IRobbers
{
public string Name {get; set; }
public int SkillLevel {get; set; }
public int PercentageCut {get; set; }
//public void PerformSkill(Bank bank)
public void Report()
{ 

     Console.WriteLine($"{Name} is a hacker they have a skill level of {SkillLevel} and need to be paid {PercentageCut}% of the heist.");
//      bank.AlarmScore -= SkillLevel;

//     if (bank.AlarmScore <= 0 )
//     Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points"); 

//     else Console.WriteLine("");
}

}

public class Muscle : IRobbers

{
public string Name {get; set; }
public int SkillLevel {get; set; }
public int PercentageCut {get; set; }


//public void PerformSkill(Bank bank)
public void Report()

{    
       Console.WriteLine($"{Name}is the muscle they have a skill level of {SkillLevel} and need to be paid {PercentageCut}% of the heist.");
     //bank.SecurityGuardScore -= SkillLevel;

//      if (bank.SecurityGuardScore <= 0 )
//     Console.WriteLine($"{Name} brings the muscle and is intimidating everyone. Decreased security 50 points");

//      else Console.WriteLine("");
}

}


public class LockSpecialist : IRobbers

{
public string Name {get; set; }
public int SkillLevel {get; set; }
public int PercentageCut {get; set; }


//public void PerformSkill(Bank bank)
public void Report()

{ 
       Console.WriteLine($"{Name} is a lock specialist they have a skill level of {SkillLevel} and need to be paid {PercentageCut}% of the heist.");
//       bank.VaultScore -= SkillLevel;
//     if (bank.VaultScore <= 0 )
//     Console.WriteLine($"{Name} is picking the lock. Decreased security 30 points"); 

//      else Console.WriteLine("");
}

}

 public class NewMember : IRobbers
 {
public string? Name {get; set; }
int Speciality{get; set; } 
public int SkillLevel {get; set; }
public int PercentageCut{get; set; } 

//public void PerformSkill(Bank bank)
public void Report()

{

  Console.WriteLine($"{Name} is a {Speciality} they have a skill level of {SkillLevel} and need to be paid {PercentageCut}% of the heist.");

}
 }

// Take the Bank parameter and decrement its appropriate security score by the SkillLevel. i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
// Print to the console the name of the robber and what action they are performing. i.e. "Mr. Pink is hacking the alarm system. Decreased security 50 points"
// If the appropriate security score has be reduced to 0 or below, print a message to the console, i.e. "Mr Pink has disabled the alarm system!"