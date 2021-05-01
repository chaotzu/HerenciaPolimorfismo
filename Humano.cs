using System.Collections.Generic;

namespace HerenciaPolimorfismo
{
     class Humano: SuperHeroe {
        public Humano(string name, string secretId) : base(name, secretId) { }

        public Humano(string name, string secretId, List<SuperPoder> poderes) : base(name, secretId, poderes) { }

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++Polimorfismo Sobrecarga++++++++++++++++++++++++++++++++++++++++++
        //Sobrecarga de métodos, polimorfismo 
        public string Avanza(){
            return "Da un paso";
        }

        //Polimorfismo sobrecarga
        public string Avanza(string formaDeAvanzar){
            return "da un " + formaDeAvanzar;
        }

        public override bool TienePoder(SuperPoder whatPower) {
            return false;
        }

        public override int PoderTotal() {
            int suma = 0;
            foreach(SuperPoder poder in Poderes){
               suma = suma + (int) poder; 
            }
            return suma;
        }
    }
}