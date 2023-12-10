namespace TestDemo.API.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }


        public void IsimYaz()
        {
            Console.WriteLine("Fatih ALKAN");
        }

    }
}
