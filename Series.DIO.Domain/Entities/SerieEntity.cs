namespace Series.DIO.Domain.Entities
{
    public class SerieEntity : BaseEntity
    {
        public int IdGenero { get; set; }
        public  string Titulo { get; set; }
        public  string Descricao { get; set; }
        public  int Ano { get; set; }
        public  bool Excluido { get; set; }

        public virtual GeneroEntity Genero { get; set; }
    }
}
