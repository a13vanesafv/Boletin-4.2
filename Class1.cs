using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_4_11
{
<<<<<<< master
      class Persona11
=======
      class Persona11 : Ejercicio_4_4_11.IPersona11
>>>>>>> local
    {
        public Persona11(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.altura11 = altura;
            this.colorOjos11 = colorOjos;
            this.colorPelo11 = colorPelo;
            this.peso11 = peso;
        }

        private int peso11;

        public int Peso11
        {
            get { return peso11; }
            set { peso11 = value; }
        }
        private int altura11;

        public int Altura11
        {
            get { return altura11; }
            set { altura11 = value; }
        }
        private string colorOjos11;

        public string ColorOjos11
        {
            get { return colorOjos11; }
            set { colorOjos11 = value; }
        }
        private string colorPelo11;

        public string ColorPelo11
        {
            get { return colorPelo11; }
            set { colorPelo11 = value; }
        }

       
        public void PonerLentillas11(string colorLentillas)
        {
            if (ComprobarColor11(colorLentillas))
                this.colorOjos11 = colorLentillas;
        }

        public bool ComprobarColor11(string colorLentillas)
        {
            return colorLentillas.Equals("azul") || colorLentillas.Equals("marron") || colorLentillas.Equals("verde");
        }

        public void Engordar11(int cantidad)
        {
            int nuevo_peso = this.peso11 + cantidad;

            if (ComprobarPeso(nuevo_peso))
            {
                Console.WriteLine("No puede incrementar más peso!!");
            }
            else
            {
                this.peso11 = nuevo_peso;
            }
        }
        public bool ComprobarPeso(int nuevo_peso)
        {
            return nuevo_peso > 180 || nuevo_peso < 40; ;
        }

        public void Adelgazar11(int cantidad)
        {
            int nuevo_peso = this.peso11 - cantidad;

            if (ComprobarPeso(nuevo_peso))
            {
                Console.WriteLine("No puede perder más peso!!");
            }
            else
            {
                this.peso11 = nuevo_peso;
            }
        }

    }
}
