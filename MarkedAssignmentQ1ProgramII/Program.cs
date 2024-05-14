using MarkedAssignmentQ1ProgramII;

class Program
{
    static void Main(string[] args)
    {
        Rock rock = new Rock(5);
        Paper paper = new Paper(7);
        Scissors scissors = new Scissors(8);

        Console.WriteLine("Rock vs Paper: " + (rock.Fight(paper) ? "Rock wins" : "Paper wins"));
        Console.WriteLine("Rock vs Scissors: " + (rock.Fight(scissors) ? "Rock wins" : "Scissors wins"));
        Console.WriteLine("Paper vs Scissors: " + (paper.Fight(scissors) ? "Paper wins" : "Scissors wins"));
    }
}