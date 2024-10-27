namespace Model.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }

        public Autor() { }

    }
}
