using System;

namespace Lp2Trab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Licensa rwindols = new Licensa("Michaelsóft Rwildols", 699.90, "SUAA-HE52-W6WG-B8Y9");
            Assinatura alface123 = new Assinatura("Michaelsóft Alface", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");
            Assinatura cottonshopi =
                new Assinatura("Aldobo Cottonshopi", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");
            Assinatura premillere =
                new Assinatura("Aldobo Premillere", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM");
            Licensa corehul = new Licensa("Corehul Dreus", 2999.90, "XZLT-CXL9-SLHV-99UM");

            ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99);
            ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45);

            Carrinho carrinho = new Carrinho();

            carrinho.Adicionar(rwindols);
            carrinho.Adicionar(alface123, 3);
            carrinho.Adicionar(cottonshopi);
            carrinho.Adicionar(premillere);
            carrinho.Adicionar(corehul);
            carrinho.Adicionar(mausi, 3);
            carrinho.Adicionar(lepetope);
            carrinho.ImprimirCarrinho();

            Relatorio relatorioArtistico = new Relatorio("Relatorio Artístico",
                "Este relatório apresenta todos os softwares artisticos vendidos na loja.");
            relatorioArtistico.AdicionarItem(cottonshopi);
            relatorioArtistico.AdicionarItem(premillere);
            relatorioArtistico.AdicionarItem(corehul);
            relatorioArtistico.ImprimirRelatorio();

            Cliente hermenegildo = new Cliente("Hermenegildo Benevides", "123.456.789-10");
            Cliente zoroastra = new Cliente("Zoroastra Muad'dib", "109.876.543-21");

            Relatorio relatorioClientes = new Relatorio("Relatório de Clientes",
                "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
            relatorioClientes.AdicionarItem(hermenegildo);
            relatorioClientes.AdicionarItem(zoroastra);
            relatorioClientes.ImprimirRelatorio();


            Compra comprinhas = new Compra(hermenegildo, carrinho);
            Compra compronas = new Compra(zoroastra, carrinho);
            Relatorio relatorioCompras = new Relatorio("Relatório de Compras", "Este relatório apresenta uma lista de todas as compras no mês de abril");
            relatorioCompras.AdicionarItem(comprinhas);
            relatorioCompras.AdicionarItem(compronas);
            relatorioCompras.ImprimirRelatorio();


            List<Produto> Obj = new List<Produto>();
            Obj.Add(corehul);
            Obj.Add(lepetope);
            Fornecedor michaelsofit = new Fornecedor("Michaelsófit", " 4002.89.22", Obj);
            List<Produto> Obj = new List<Produto>();
            Obj.Add(corehul);
            Obj.Add(lepetope);
            Fornecedor epou = new Fornecedor("Épou", "1221.04.99", Obj);
            Relatorio relatorioFornecedores = new Relatorio("Relatório de Fornecedores", "Este relatório apresenta com os nossos Fornecedores");
            relatorioFornecedores.AdicionarItem(michaelsofit);
            relatorioFornecedores.AdicionarItem(epou);
            relatorioFornecedores.ImprimirRelatorio();

            Dictionary<Produto, int> artefatos = new Dictionary<Produto, int>();
            artefatos.Add(rwindols, 2000);
            artefatos.Add(alface123, 8000);
            artefatos.Add(cottonshopi, 50000);
            artefatos.Add(premillere, 90000);
            artefatos.Add(corehul, 1100);
            artefatos.Add(mausi, 5100);
            artefatos.Add(lepetope, 3300);
            
            Estoque estoque = new Estoque(artefatos);
            
            estoque.Atz_Estoque(carrinho);
            estoque.Atz_Estoque(carrinho);
         
            Relatorio estocamento = new Relatorio("Estoque de Produtos", " Este relatório apresenta o estoque dos produtos");
            estocamento.AdicionarItem(estoque);
            estocamento.ImprimirRelatorio();
        
        }
    }
}
