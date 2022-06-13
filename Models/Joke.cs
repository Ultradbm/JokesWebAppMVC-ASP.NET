using System.ComponentModel;

namespace JokesWebAppMVC.Models
{
    public class Joke
    {
        public int Id { get; set; }

        [DisplayName("Joke Set Up")]
        public string? JokeQuestion { get; set; }
        [DisplayName("Punchline")]
        public string? JokeAnswer { get; set; }

        public Joke()
        {

        }


     
    }
}
