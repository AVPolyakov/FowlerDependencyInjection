using System.Linq;
using static FriendApplication.Assembler;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FriendApplication
{
    class Program
    {
        static void Main()
        {
            var movies = CreateMovieLister().MoviesDirectedBy("Friend");
            AreEqual("Once Upon a Time in the West", movies.First().Title);
        }
    }
}
