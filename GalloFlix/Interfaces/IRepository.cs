namespace GalloFlix.Interfaces;

//Interface genérica : te permite trabalhar com qualquer classe
public interface IRepository<T> where T : class 
{
    //Métodos de CRUD: CREATE, READ, UPDATE, DELETE

    //CREATE - Adicionar novo dado
    //VOID = função sem retorno (é um procedimento)
    //() = Informação necessária que passa pro procedimento realizar algo (NOME E TIPO)
    void Create(T model); //ADD

    // READ - Leitura de Dados
    List<T> ReadAll(); // GET
    T ReadById(int? id);

    //UPDATE - Atualizar um Dado
    void Update(T model);

    //DELETE - Excluir Dado
    void Delete(int? id);
    
}
