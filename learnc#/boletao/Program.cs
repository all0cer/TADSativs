using System;

namespace boleto
{
    class Program
    {
        static void Main(string[] args)
        {
             Boleto b = new Boleto("1234", DateTime.Parse("2023-05-01"), 248.43);
             Console.WriteLine(b);
             b.Pagar(100.43);
             Console.WriteLine(b);

        }
    }
}


enum Pagamento{EmAberto,
                    Pago,
                    ParcialmentePago};
class Boleto {
    private string codBarras;
    private DateTime dataEmissao;
    private DateTime dataVencimento;
    private DateTime dataPagmto;
    private double valorBoleto;
    private double ValorPago;
    private Pagamento situacaoPagamento;

    public Boleto(string cod, DateTime emissao,
    double valor){
        this.codBarras = cod;
        this.dataEmissao = emissao;
        this.valorBoleto = valor;
        this.dataVencimento = this.dataEmissao.AddDays(15);
    }

    public void Pagar(double val){
        if (val > 0){this.ValorPago = val; this.dataPagmto = DateTime.Now;}
        if(this.valorBoleto-val>0){ this.situacaoPagamento = Pagamento.ParcialmentePago; this.valorBoleto -= val;}
        else this.situacaoPagamento = this.situacaoPagamento = Pagamento.Pago;
    }

    public Pagamento Situacao(){
        return situacaoPagamento;
    }

    public override string ToString(){
        return  $"Data de emissão: {dataEmissao: dd/MM/yyyy}\nData de Vencimento: {dataVencimento: dd/MM/yyyy}\nSituacao do boleto: {situacaoPagamento}\nValor para pagar: {valorBoleto}";
    }
}