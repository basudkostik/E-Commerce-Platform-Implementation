using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace
{

       public class Node
        {
        public ArrayList Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(ArrayList data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }

    }
}
