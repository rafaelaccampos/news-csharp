namespace news_csharp.PrimaryConstructor.Struct
{
    //Construtor Primário
    public readonly struct Distancia(double dx, double dy)
    {
        public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
        public readonly double Direction { get; } = Math.Atan2(dy, dx);
    }

    //Código acima é equivalente ao código abaixo:
    public readonly struct Distancia2
    {
        public readonly double Magnitude { get; }

        public readonly double Direction { get; }

        public Distancia2(double dx, double dy)
        {
            Magnitude = Math.Sqrt(dx * dx + dy * dy);
            Direction = Math.Atan2(dy, dx);
        }
    }
}
