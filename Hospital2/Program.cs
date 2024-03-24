namespace Hospital2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("a",1,"ent");
         

            Doctor doctor2 = new Doctor("b",2,"ttt");
            

            Console.WriteLine(doctor2.Name);
            Console.WriteLine(doctor1.Id);
            doctor1.greeting(doctor1.Name);
        }
    }
}
