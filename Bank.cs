// Knocking over banks isn't going to be easy. Alarms... Vaults... Security Guards.... Each of these safeguards is something we'll have to handle for a successful heist. First things first. Let's create a Bank class to represent the security we're up against. Give the Bank class the following properties:

using System;

  public class Bank
    {

        public string? BankName { get; set; }
        public int? CashOnHand {get; set; }
        public int? AlarmScore {get; set; }
        public int? VaultScore {get; set; }
        public int? SecurityGuardScore {get; set;}
        public bool IsSecure (){
    if (AlarmScore  <= 0 || VaultScore <= 0 || SecurityGuardScore <=0) {// A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true

              return false;
        }
      else {return true;}  }
    }
        

// An integer property for CashOnHand
// An integer property for AlarmScore
// An integer property for VaultScore
// An integer property for SecurityGuardScore

