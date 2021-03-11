using System;
using System.Collections.Generic;
using System.Text;
using Realms;
namespace RealmApp3.Models
{
    public class ParamValue:RealmObject
    {
        public Param param { get; set; }
        public string value { get; set; }
    }
}
