namespace news_csharp.OperadorSpread.Span
{
    public class SpreadOperatorSpan
    {
        public void CombinarSpans()
        {
            Span<int> numerosSpan = [1, 2, 3];
            Span<int> numerosCombinados = [0, .. numerosSpan, 4, 5];// 0, 1, 2, 3, 4, 5
        }

        public ReadOnlySpan<char> CombinarReadonlySpans()
        {
            ReadOnlySpan<char> texto = "Hello, world!";
            ReadOnlySpan<char> subtexto = texto[7..]; // "world!
            return subtexto;
        }
    }
}
