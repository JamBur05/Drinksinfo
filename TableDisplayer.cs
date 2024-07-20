using ConsoleTableExt;
using DrinksInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo
{
    public class TableDisplayer
    {
        public static void DisplayTable<T>(List<T> tableInfo, string tableName) where T : class
        {
            Console.Clear();

            ConsoleTableBuilder
                .From(tableInfo)
                .WithColumn(tableName)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine(TableAligntment.Center);
        }
            
    }
}
