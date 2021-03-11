using System;
using System.Collections.Generic;
using System.Text;
using Realms;
namespace RealmApp3.Models
{
   public class ItemObject:RealmObject
    {
       
        public string id { get; } =Guid.NewGuid().ToString();
        public string name { get; set; }
        public ItemType type { get; set; }
        public Manufactorer manufactorer { get; set; }
        public string model { get; set; }
        public string serial { get; set; }
        //public IList<ParamValue> values { get; }
        public ParamValue paramvalue { get; set; }
        public Param param { get; set; }
    }
}
