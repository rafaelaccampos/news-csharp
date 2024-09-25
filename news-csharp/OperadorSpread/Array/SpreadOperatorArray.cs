namespace news_csharp.OperadorSpread.Array
{
    public class SpreadOperatorArray
    {
        public int[] CombinarArrays()
        {
            int[] linha0 = [1, 2, 3];
            int[] linha1 = [4, 5, 6];
            int[] linha2 = [7, 8, 9];
            int[] arrayCombinado = [.. linha0, .. linha1, .. linha2];

            return arrayCombinado;
        }
    }
}
