public class UserInfo {
  public string Name;
  public string Surname;
  public string IdNumber;
  public string Score;
 
  
  public void PrintUserInformation(UserInfo info){
    Console.WriteLine("Name: {0}",info.Name);
    
    Console.WriteLine("Surname: {0}",info.Surname);
    
    Console.WriteLine("ID Number: {0}",info.IdNumber);
    
    Console.WriteLine("Score: {0}",info.Score);
    
   
    }
    public void UserInput() {
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
