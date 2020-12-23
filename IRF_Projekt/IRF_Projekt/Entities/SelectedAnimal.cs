using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Projekt.Entities
{
    public class SelectedAnimal
    {
        public DateTime Date { get; set; }
        public string AnimType { get; set; }
        public string AnimName { get; set; }
        public Nullable<int> AnimPrice { get; set; }
        public Nullable<int> AnimQuantity { get; set; }
    }
}
