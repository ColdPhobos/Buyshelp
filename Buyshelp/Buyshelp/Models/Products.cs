using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Buyshelp.Models
{
    [Table("Products")]
    public class Products
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
