
namespace Exercicio7
{
    class QuartosPousada
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public QuartosPousada(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }


    }
}
