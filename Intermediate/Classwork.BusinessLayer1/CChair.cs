using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork.UI
{
    class CChair
    {
        //Private Fields
        private string design;
        private string material;
        private bool wheeled;

        
        public bool Wheeled
        {
            get { return wheeled; }
            set { wheeled = value; }
        }



        public string Material
        {
            get { return material; }
            set { material = value; }
        }


        public string Design
        {
            get { return design; }
            set { design = value; }
        }

    }
}
