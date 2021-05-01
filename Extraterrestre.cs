using System.Collections.Generic;

namespace HerenciaPolimorfismo
{
     class Extraterrestre: SuperHeroe {
        public Extraterrestre(string name, string secretId) : base(name, secretId) { }

        public Extraterrestre(string name, string secretId, List<SuperPoder> poderes) : base(name, secretId, poderes) { }

        public override bool TienePoder(SuperPoder whatPower) {
            return false;
        }

        public string Avanza(){
            return "Vuela";
        }

        public override int PoderTotal() {
            int suma = 0;
            foreach(SuperPoder poder in Poderes){
               suma = suma + (int) poder; 
            }
            return suma;
        }

        public override string Ataca()
        {
            return "Patada extraterrestre";
        }
    }
}