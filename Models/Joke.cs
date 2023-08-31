using Microsoft.AspNetCore.Identity;

namespace JokeApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string? JokePrompt { get; set; }
        public string? JokeAnswer { get; set; }
        public string? AuthorId { get; set; }  // This is to link a joke to an IdentityUser.
        public IdentityUser? Author { get; set; }

    }
}