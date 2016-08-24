namespace FowlerDependencyInjection
{
    class Assembler
    {
        public static MovieLister CreateMovieLister() => new MovieLister(CreateMovieFinder());
        private static IMovieFinder CreateMovieFinder() => new ColonDelimitedMovieFinder("movies1.txt");
    }
}