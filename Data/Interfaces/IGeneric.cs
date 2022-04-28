namespace Data.Interfaces
{
    public interface IGeneric<T> where T : class
    {
        Task<List<T>> ListarTudo();

        Task Adicionar(T Objeto);

        Task Atualizar(T Objeto);

        Task Excluir(T Objeto);

        Task<T> BuscarPorCodigo(int Id);
    }
}
