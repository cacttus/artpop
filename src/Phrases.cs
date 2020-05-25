using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPop
{
    public class Phrases
    {
        public static Dictionary<LanguageCode, Dictionary<int, Phrase>> Lexicon = new Dictionary<LanguageCode, Dictionary<int, Phrase>>();

        public static Phrase Settings = new Phrase("Settings", "Configuraciones");
        public static Phrase EditSession = new Phrase("Session", "Sesión");
        public static Phrase FullscreenMode = new Phrase("Fullscreen Mode", "Modo de pantalla completa");
        public static Phrase ShowDetails = new Phrase("Show Details", "Mostrar detalles");

    }
}
