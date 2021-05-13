using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_05
{
    public abstract class GadgetsBill : Gadgets
    {
        public int TotalSold { get; set; }

        private string _comment;
        public string CustomerComment
        {
            get
            {
                if(_comment == string.Empty)
                {
                    return _comment = "Ok";
                }
                else
                {
                    return _comment;
                }
            }
            set
            {
                if (_comment == string.Empty)
                {
                    _comment = "Ok";
                }
                else
                    _comment = value;
            }
        }
        public override void GadgetInfo(string name, string type)
        {
            Console.WriteLine($"Gadget Name : {GadgetName} || Gadget Type : {GadgetType}");
        }

        public abstract void Reviews();
        
    }
}
