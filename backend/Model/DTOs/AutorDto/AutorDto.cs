namespace Model.DTOs.MetaDto
{
    public class AutorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public string CriadoEm { get; set; }
    }

    public class CreateAutorDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public string CriadoEm { get; set; }
    }
}
