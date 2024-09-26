namespace news_csharp.OperadorSpread.Span
{
    public class SpreadOperatorSpan
    {
        public ReadOnlySpan<char> CombinarReadonlySpans()
        {
            ReadOnlySpan<char> texto = "Hello, world!";
            ReadOnlySpan<char> subtexto = texto[7..]; // "world!
            return subtexto;
        }
    }
}
