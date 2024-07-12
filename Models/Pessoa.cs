namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }
    // GPT: Este é um construtor padrão que não faz nada explicitamente. Ele permite criar uma instância da classe Pessoa sem fornecer nenhum argumento. Em outras palavras, ele cria um objeto Pessoa com os valores padrão para todas as propriedades (que no caso de strings é null).

    public Pessoa(string nome)
    {
        Nome = nome;
    }
    // Método construtor, ele é escrito logo no começo da classe, retomando o nome dela (no caso, Pessoa) e não tendo nenhum tipo de retorno especificado. As variáveis dele são as mesmas da classe.
    // A partir do momento que o construtor é criado, todas as instâncias precisam dos mesmos argumentos do método construtor, ou seja, se o construtor tem dois ints, todas as instâncias terão dois ints. Caso se queira outra possibilidade, como não ter que passar dois ints, por exemplo, será preciso criar um novo construtor. 

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        // A primeira variável se refere à propriedade, a segunda aos parâmetros
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}