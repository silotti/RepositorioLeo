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
        

        public static void CriarPlanilhaClientes(IEnumerable<Cliente> cliente, String caminho)
        {
            BancosSapataria ctx = new BancosSapataria();

            //Criar um Workbook. Um arquvio excel.
            var workbook = new XLWorkbook();
            int ListaSapatosLinhaInicio = 1;
            int ListaSapatosLinhaInicio1 = 2;
            var worksheet = workbook.Worksheets.Add("Lista de Clientes");
            foreach (Cliente t in cliente)
            {
                var ped = ctx.BdCliente.Find(t.id_Cliente);

                //Um arquivo excel pode conter várias planilhas. 
                var columnId = worksheet.Column("A");
                var columnNome = worksheet.Column("B");
                //var columnEndereco = worksheet.Column("C");

                columnId.Cell(ListaSapatosLinhaInicio).
                    Value = "Id";
                columnNome.Cell(ListaSapatosLinhaInicio).
                    Value = "Nome do Cliente";
                //columnEndereco.Cell(ListaSapatosLinhaInicio).
                //    Value = "Endereco";


                columnId.Cell(ListaSapatosLinhaInicio1).
                   Value = t.id_Cliente;
                columnNome.Cell(ListaSapatosLinhaInicio1).
                    Value = t.nome;
                //columnEndereco.Cell(ListaSapatosLinhaInicio1).
                //    Value = t.enderecoPF;
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
