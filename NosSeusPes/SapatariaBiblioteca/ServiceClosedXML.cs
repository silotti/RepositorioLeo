using ClosedXML.Excel;
using SapatariaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosSeusPes
{
    public class ServiceClosedXML
    {
        


        public static void CriarPlanilhaPedidos(IEnumerable<Pedido> pedido, String caminho)
        {
            BancosSapataria ctx = new BancosSapataria();

            //Criar um Workbook. Um arquvio excel.
            var workbook = new XLWorkbook();
            int ListaSapatosLinhaInicio = 1;
            int ListaSapatosLinhaInicio1 = 2;
            var worksheet = workbook.Worksheets.Add("Sapatos Em Estoque");
            foreach (Pedido t in pedido)
            {
                var ped = ctx.BdPedido.Find(t.id_Pedido);

                //Um arquivo excel pode conter várias planilhas. 



                var columnModelo = worksheet.Column("A");
                var columnPreco = worksheet.Column("B");
                var columnTamanho = worksheet.Column("C");
                var columnQntDisponivel = worksheet.Column("D");

                columnModelo.Cell(ListaSapatosLinhaInicio).
                    Value = "Modelo";
                columnPreco.Cell(ListaSapatosLinhaInicio).
                    Value = "Preco";
                columnTamanho.Cell(ListaSapatosLinhaInicio).
                    Value = "Tamanho";
                columnQntDisponivel.Cell(ListaSapatosLinhaInicio).
                    Value = "Cor";

                //columnModelo.Cell(ListaSapatosLinhaInicio1).
                 //  Value = pedido.nome;
                columnPreco.Cell(ListaSapatosLinhaInicio1).
                    Value = t.id_Cliente;
                columnTamanho.Cell(ListaSapatosLinhaInicio1).
                    Value = t.quantidade;
                columnQntDisponivel.Cell(ListaSapatosLinhaInicio1).
                    Value = t.precoTotal;
                worksheet.Row(ListaSapatosLinhaInicio).Style.Fill.BackgroundColor = XLColor.Gray;
                worksheet.Row(ListaSapatosLinhaInicio).Style.Font.Bold = true;
                ListaSapatosLinhaInicio1++;

            }
            //Excel pode utilizar a referência A1 [A1,B2...] ou R1C1
            //Se quiser ler mais sobre acesse o link: https://www.reddit.com/r/excel/comments/6tpgk3/reference_style_r1c1_vs_a1/
            workbook.ReferenceStyle = XLReferenceStyle.A1;
            //Calcular automaticamente os valores das fórmulas.
            workbook.CalculateMode = ClosedXML.Excel.XLCalculateMode.Auto;
            //Persistir o arquivo.
            workbook.SaveAs(caminho, true, evaluateFormulae: true);
        }
    }
}
