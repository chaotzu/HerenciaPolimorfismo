using System.Collections.Generic;

namespace HerenciaPolimorfismo
{
        /// <summary>
        /// Lista de superpoderes comunes y un valor que supone
        /// al sumarlo el poder total del super heroe  
        /// </summary>
        public enum SuperPoder {
            Volar = 100,
            SuperFuerza = 75,
            VisionRayosX = 20,
            SuperVelocidad = 40,
            Invulnerabilidad =150,
            SuperIntelecto = 90
        }

        /// <summary>
        /// Un superheroe tiene dos identidades
        /// y varios o un super poder
        /// Clase abstracta que debe completarse
        /// </summary>
        public abstract class SuperHeroe {

            private string identidadActual;
            private string otraIdentidad;  
            private List<SuperPoder> poderes;         
        
            #region propiedades
            /// <summary>
            /// Propiedad para determinar la lista de poderes
            /// </summary>
            public List<SuperPoder> Poderes{
                get{
                    return poderes;
                }
                private set{}
            }
            #endregion
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++Polimorfismo Sobrecarga++++++++++++++++++++++++++++++++++++++++++
            //Sobrecarga de constructores, polimorfismo 
            #region constructores
            /// <summary>
            /// Constructor recibe nombre de superheroe y su alter ego
            /// </summary>
            /// <param name="identidad verdadera">Identidad verdadera del super heroe.</param>
            /// <param name="alter Ego">Alter ego del super héroe.</param>        
            public SuperHeroe(string verdaderaIdentidad, string alterEgo) {
                identidadActual = verdaderaIdentidad;
                otraIdentidad = alterEgo;
                poderes?.Add(SuperPoder.SuperIntelecto);
            }

            /// <summary>
            /// Constructor recibe identidad del super héroe, alter ego y lista de poderes
            /// </summary>
            /// <param name="identidad verdadera">Identidad verdadera del super heroe.</param>
            /// <param name="alter Ego">Alter ego del super héroe.</param>        
            /// <param name="poderes">Lista de poderes del super héroe.</param>            
            public SuperHeroe(string verdaderaIdentidad, string alterego, List<SuperPoder> poderes){
                identidadActual = verdaderaIdentidad;
                otraIdentidad = alterego;
                this.poderes = poderes;
            }
            #endregion
            #region métodos
            /// <summary>
            /// TODO Hacer algo para identidad actual
            /// </summary>            
            public string IdentidadActual(){
                return identidadActual;
            }

            /// <summary>
            /// Devuelve la ponderación numérica de un poder
            /// </summary>
            /// <param name="poder">Super poder del héroe.</param>            
            public int ObtenerValorDePoder(SuperPoder poder) {
                return (int) poder;
            }

            /// <summary>
            /// Cambia la identidad del super héroe
            /// </summary>            
            public virtual void CambiarIdentidad() { //Método virtual que puede ser sobreescrito o no por la clase hija

                identidadActual = otraIdentidad;

            }
            /// <summary>
            /// Permite atacar a un super héroe
            /// </summary>            
            public virtual string Ataca(){
                return "Patada";
            }

            /// <summary>
            /// Se debe implementar en clases derivadas, saber si un super héroe posee un poder
            /// </summary>
            /// <param name="quePoder">Super poder del héroe.</param>            
            public abstract bool TienePoder(SuperPoder quePoder); //Método abstracto que deben implementar los hijos

            /// <summary>
            /// Se debe implementar en clases derivadas, saber el poder total de un super héroe
            /// </summary>            
            public abstract int PoderTotal();//Método abstracto, algunos extraterrestres tienen mas poder en la tierra
            #endregion
        
    }
}