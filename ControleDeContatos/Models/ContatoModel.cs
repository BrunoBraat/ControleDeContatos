namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        //Incrementa o código do contato e gera um id automaticamente 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
