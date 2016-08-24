using System.Linq;
using static FowlerDependencyInjection.Assembler;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace FowlerDependencyInjection
{
    class Program
    {
        static void Main()
        {
            var movies = CreateMovieLister().MoviesDirectedBy("Sergio Leone");
            AreEqual("Once Upon a Time in the West", movies.First().Title);
        }
    }
}
