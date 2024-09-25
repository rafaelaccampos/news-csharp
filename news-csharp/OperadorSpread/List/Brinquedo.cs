namespace news_csharp.OperadorSpread.List
{
    public class Brinquedo
    {
        public List<string> CombinarBrinquedos()
        {
            var listaBrinquedos1 = new List<string> { "Boneca", "Bola" };
            var listaBrinquedos2 = new List<string> { "Nerf", "Patinete" };

            List<string> todosBrinquedos = [.. listaBrinquedos1, .. listaBrinquedos2, "Patins"];
            return todosBrinquedos;
        }
    }
}
