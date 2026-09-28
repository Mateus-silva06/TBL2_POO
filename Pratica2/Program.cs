public abstract class Funcionario
{
    public abstract decimal CalcularSalario();
}
class Gerente : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 10000;
    }
}
class Programador : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 8000;
    }
}
class Program
{
    public static void Main()
    {
        Gerente gerente = new Gerente();
        Console.WriteLine($"Salario de gerente:R${ gerente.CalcularSalario()}");

        Programador dev = new Programador();
        Console.WriteLine($"Salario de programador:R$ {dev.CalcularSalario()}");

        //Adicional:

        List<Funcionario> funcionarios = new List<Funcionario>();

        funcionarios.Add(new Gerente());
        funcionarios.Add(new Programador());

        foreach(Funcionario funcionario in funcionarios)
        {
            Console.WriteLine(funcionario.CalcularSalario());
        }
    }
}