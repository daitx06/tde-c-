public class Empresa
{
    private List<Funcionario> Funcionarios; // ctor cria o construtor
    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario){
        Funcionarios.Add(funcionario);
    }

    public void ListarFuncionario(){
        foreach (var Funcionario in Funcionarios)
        {
            Console.WriteLine($"Nome: {Funcionario.Nome} \nSalário: {Funcionario.CalcularSalario()}");
            Console.WriteLine("");
        }
    }
}