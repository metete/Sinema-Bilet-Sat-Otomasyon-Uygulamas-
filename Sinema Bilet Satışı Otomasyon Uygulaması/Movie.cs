using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Bilet_Satışı_Otomasyon_Uygulaması
{
    public class Movie
    {
        String movieTitle;
        String movieGenre;
        DateTime movieVisionDate;
        DateTime movieFinalScreeningDate;
        TimeOnly movieDuration;
        List<String> SaloonsAndSessions;
    }
}
