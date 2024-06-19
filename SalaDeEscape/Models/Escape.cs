class Escape{

    private static string [] incognitasSalas = new string[6];
    private static int estadoJuego;

    private static void InicializarJuego()
    {
        //incognitasSalas =;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if(Sala != estadoJuego)
        {
            return false;
        }
        else
        {
            if(incognitasSalas.Length == 0)
            {
                InicializarJuego();
            }
            if(Incognita == incognitasSalas[Sala])
            {
                estadoJuego++;
                return true;
            }
            else{return false;}
        }
    }

}