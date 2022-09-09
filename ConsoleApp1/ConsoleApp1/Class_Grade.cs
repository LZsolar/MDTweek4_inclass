public class Class_Grade
{
    public string grade;
    public int score;

    public void changeStringToInt()
    {
        this.score = int.Parse(this.grade);
    }

    public void printScore()
    {
        Console.WriteLine(this.grade);
    }

    public void printGrade()
    {
        changeStringToInt();
        if (ifA(this.score)) { Console.WriteLine("A"); }
        if (ifBp(this.score)) { Console.WriteLine("B+"); }
        if (ifB(this.score)) { Console.WriteLine("B"); }
        if (ifCp(this.score)) { Console.WriteLine("C+"); }
        if (ifC(this.score)) { Console.WriteLine("C"); }
        if (ifDp(this.score)) { Console.WriteLine("D+"); }
        if (ifD(this.score)) { Console.WriteLine("D"); }
        if (ifF(this.score)) { Console.WriteLine("F"); }
    }

    public bool ifA(int g)
    {
        if (g >= 80) { return true; }
        return false;
    }
    public bool ifBp(int g)
    {
        if (g >= 75 && g < 80) { return true; }
        return false;
    }
    public bool ifB(int g)
    {
        if (g >= 70 && g < 75) { return true; }
        return false;
    }
    public bool ifCp(int g)
    {
        if (g >= 65 && g < 70) { return true; }
        return false;
    }
    public bool ifC(int g)
    {
        if (g >= 60 && g < 65) { return true; }
        return false;
    }
    public bool ifDp(int g)
    {
        if (g >= 55 && g < 60) { return true; }
        return false;
    }
    public bool ifD(int g)
    {
        if (g >= 50 && g < 55) { return true; }
        return false;
    }
    public bool ifF(int g)
    {
        if (g < 50) { return true; }
        return false;
    }
}