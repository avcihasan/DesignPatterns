using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections;
using System.Data;

namespace DesignPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public class ExcelProcessHandler: ProcessHandler
    {
        private DataTable GetTable(Object o, Type T)
        {
            var table = new DataTable();


            T.GetProperties().ToList().ForEach(x => table.Columns.Add(x.Name, x.PropertyType));

            //var list = o as List<T>;

            foreach (var item in o as IEnumerable)
            {
                var values = T.GetProperties().Select(propertyInfo => propertyInfo.GetValue(item, null)).ToArray();
                table.Rows.Add(values);

            };

            //list.ForEach(x =>
            //{
            //    var values = T.GetProperties().Select(propertyInfo => propertyInfo.GetValue(x, null)).ToArray();

            //    table.Rows.Add(values);
            //});

            return table;
        }

        public override object Handler(object o, Type T)
        {
            var wb = new XLWorkbook();
            var ds = new DataSet();

            ds.Tables.Add(GetTable(o,T));

            wb.Worksheets.Add(ds);

            var excelMemoryStream = new MemoryStream();

            wb.SaveAs(excelMemoryStream);

            return base.Handler(excelMemoryStream, T);
        }
    }
}
