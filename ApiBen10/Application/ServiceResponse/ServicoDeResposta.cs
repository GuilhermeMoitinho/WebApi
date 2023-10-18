namespace ApiBen10.Application.ServiceResponse
{
    public class ServicoDeResposta<T>
    {
        public bool Sucesso { get; set; }
        public Object Dados { get; set; }
        public Object Mensagem { get; set; }
    }
}
