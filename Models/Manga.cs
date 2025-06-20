namespace MiMangaBot.Models
{
    public class Manga
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public int GeneroId { get; set; }
        public int Anio { get; set; }

        public Genero? Genero { get; set; }  // <--- Ahora opcional
    }
}
