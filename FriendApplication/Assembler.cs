using MovieLibrary;

namespace FriendApplication
{
    class Assembler
    {
        public static MovieLister CreateMovieLister() => new MovieLister(CreateMovieFinder());
        private static IMovieFinder CreateMovieFinder() => new FriendMovieFinder();
    }
}