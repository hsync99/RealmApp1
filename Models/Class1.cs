using System;
using System.Collections.Generic;
using System.Text;
using Realms;
namespace RealmApp3.Models
{
    public class Class1:RealmObject
    {
        [PrimaryKey]
        public int id { get; set; }
        public string name { get; set; }
    }

}
