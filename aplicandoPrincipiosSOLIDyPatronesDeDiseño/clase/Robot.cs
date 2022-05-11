using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicandoPrincipiosSOLIDyPatronesDeDiseño.clase
{
    abstract class Robot
    {
        private string material;//METAL, PLASTICO O AMBAS
        private string tipoCarga;// INTERNA O EXTERNA
        private string sistemaDeControl; //AUTOMATICO O MANUAL 
        private string codigoDeSerie;//ID, CLAVE PRIMARIA

        //CONSTRUCTOR
        public Robot(string material, string tipoCarga, string sistemaDeControl, string codigoDeSerie)
        {
            this.material = material;
            this.tipoCarga = tipoCarga;
            this.sistemaDeControl = sistemaDeControl;
            this.codigoDeSerie = codigoDeSerie;
        }

        public Robot(string material, string tipoCarga, string sistemaDeControl, string codigoDeSerie, string v1, string sistemaDeControl1, string v2, string codigoDeSerie1) : this(material, tipoCarga, sistemaDeControl, codigoDeSerie)
        {
        }


        //METODOS
        public abstract void getMaterial();
        public abstract void getTipoCarga();
        public abstract void getSistemaDeControl();
        public abstract void getCodigoDeSerie();



    }
}
