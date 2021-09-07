using System.Collections.Generic;

namespace Series.DIO.Domain.Entities
{
    public class GeneroEntity : BaseEntity
    {
        public string Descricao { get; set; }
        public IReadOnlyList<string> Validar()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(Descricao))
                errors.Add("Gênero não especificado");

            return errors;
        }
    }
}
