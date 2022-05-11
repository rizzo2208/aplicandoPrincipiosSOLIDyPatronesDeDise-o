using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplicandoPrincipiosSOLIDyPatronesDeDiseño.clase


namespace aplicandoPrincipiosSOLIDyPatronesDeDiseño.clase
{
    internal class Terrestre : Robot
    {
        public Terrestre(string material, string tipoCarga, string sistemaDeControl, string codigoDeSerie) : base(string material, string tipoCarga, string sistemaDeControl, string codigoDeSerie)
        {
            
        }





        //METODOS HERENCIA

        public override void getCodigoDeSerie()
        {
            throw new NotImplementedException();
        }

        public override void getMaterial()
        {
            throw new NotImplementedException();
        }

        public override void getSistemaDeControl()
        {
            throw new NotImplementedException();
        }

        public override void getTipoCarga()
        {
            throw new NotImplementedException();
        }
    }
}
