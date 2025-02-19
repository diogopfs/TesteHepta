namespace TesteHepta.Models
{
    public class BaseModel<T>
    {
        public bool Sucesso { get; set; }

        public string Mensagem { get; set; }
        public T? Dados { get; set; }

        public BaseModel(bool sucesso, string mensagem, T? dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }
    }
}
