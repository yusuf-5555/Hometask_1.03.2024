public class Teacher : Person
{
    public Teacher(string name):base(name)
    {

    }
        public void Explain()
        {
            System.Console.WriteLine("The teacher is explaining");
        }
}