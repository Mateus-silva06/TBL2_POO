class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("pagamento efetuado");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento efetuado via Cartão de Crédito");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento efetuado via Boleto Bancario");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento efetuado via Pix");
    }
}

class Program
{
    public static void Main()
    {
        List<Pagamento> pagamentos = new List<Pagamento>();


        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());

        

        foreach (Pagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
            
        }
        
    }
}