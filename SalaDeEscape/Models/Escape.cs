class Escape{

    private static string [] incognitasSalas = new string[6];
    private static int estadoJuego;

    private static void InicializarJuego()
    {
        incognitasSalas[0] = "WORDS-LET";
        incognitasSalas[1] = "42135";
        incognitasSalas[2] = "13";
        incognitasSalas[3] = "NIRVANA";
        incognitasSalas[4] = "BRITNEY";
        incognitasSalas[5] = "GACHDBEF";
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