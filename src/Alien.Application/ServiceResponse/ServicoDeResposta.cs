namespace ServiceResponse
{
    public class ServicoDeResposta<T>
    {
        public bool Sucesso { get; set; }
        public object Dados { get; set; }
        public object Mensagem { get; set; }
    }
}
