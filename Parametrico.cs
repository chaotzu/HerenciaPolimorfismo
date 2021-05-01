using System.Collections.Generic;

namespace HerenciaPolimorfismo
{
    class DatoInt{
        int valor;
        public DatoInt (int v){
            valor = v;
        }

        public int getValor(){
            return valor;
        }
    }

    class DatoDbl{
        double valor;
        public DatoDbl (double v){
            valor = v;
        }

        public double getValor(){
            return valor;
        }
    }

    //Clase genérica, variables de tipo, permite crear variables de cualquier tipo
    public class Dato <D>{
        D valor;

        public Dato(D v){
            valor = v;
        }

        public D getValor(){
            return valor;
        }
    }
}