using System.Collections.Generic;

namespace HerenciaPolimorfismo
{
     class Spiders: Extraterrestre {

        private int patas;        

        public Spiders(string name, string secretId, string planeta, int patas) : base(name, secretId, planeta) { this.patas = patas; }
        public Spiders(string name, string secretId, string planeta) : base(name, secretId, planeta) { }

        public Spiders(string name, string secretId, List<SuperPoder> poderes, string planeta) : base(name, secretId, poderes, planeta) { }

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