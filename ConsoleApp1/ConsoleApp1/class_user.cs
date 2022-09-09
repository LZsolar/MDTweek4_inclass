using System;

public class UserInfo {
  public string Name;
  public string Surname;
  public string IdNumber;
  public string Score;
 
  
  static void PrintUserInformation(UserInfo info){
    Console.Write("Name: {0}",info.Name);
    
    Console.Write("Surname: {0}",info.Surname);
    
    Console.Write("ID Number: {0}",info.IdNumber);
    
    Console.Write("Score: {0}",info.Score);
    
   
    }
    public static void UserInput() {
       Console.Write("Input Name: ");
       this.Name = Console.ReadLine();
       Console.Write("Input Surname: ");
       this.Surname = Console.ReadLine();
       Console.Write("Input ID Number: ");
       this.IdNumber = Console.ReadLine();
       Console.Write("Input Score: ");
       this.Score = Console.ReadLine();
       
    }
}
