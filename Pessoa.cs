using System;

namespace Cadastros 
{
  public class Pessoa 
  {
    public string Nome {get; set;}

    public string Sobrenome {get; set;}
    
    public DateTime DataNascimento {get; set;}

    public Pessoa ()
    {
      //TODO:Construtor
    }

    public Pessoa(string nome, string sobrenome, DateTime datanascimento)
    {
      this.Nome=nome;
      this.Sobrenome=sobrenome;
      this.DataNascimento=datanascimento;
    }

    public void Andar()
    {
      this.Andar(1);
    }
    public void Andar(decimal metros)
    {
      //TODO
    }


  }
}