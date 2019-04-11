using System.Collections.Generic;

public class Paciente
{


    public string Nome { get; set; }
    public string Cpf { get; set; }
    public List<Procedimento> Procedimentos { get; set; }

    public Paciente( string name, string cpf)
    {
 
        this.Nome = name;
        this.Cpf = cpf;
        this.Procedimentos = new List<Procedimento>();
    }

   



}