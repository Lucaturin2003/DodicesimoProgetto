using Extension;

string post = "This is supposed to be a very long post bla bla bla ...";
var shortenedPost = post.Shorten(5);
Console.WriteLine(shortenedPost);

namespace Extension
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords) 
        {
            if(numberOfWords < 0) throw new ArgumentOutOfRangeException("Number of words should be greater or equal than 0");

            if(numberOfWords == 0) return str;

            var words = str.Split(' ');

            if(words.Length <= numberOfWords) return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}
