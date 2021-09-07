namespace Series.DIO.Domain.Models
{
    public class SerieModel
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public GeneroModel Genero { get; set; }
    }
}
