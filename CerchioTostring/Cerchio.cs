using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CerchioTostring
{
    internal class Cerchio
    {
        

        public float Raggio { get; set; }
        

        public Cerchio(float raggio)
        {
            Raggio = raggio;
        }

        public float Area()
        {
            return (float)(Math.PI*Raggio*Raggio);
        }
        public float Perimetro()
        {
            return (float)(Math.PI * (Raggio * 2));
        }

        public override string ToString()
        {
            return string.Format(" {0} ", Raggio);
        }
    }
}
