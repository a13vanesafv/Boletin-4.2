using System;
namespace Ejercicio_4_4_11
{
    interface IPersona11
    {
        void Adelgazar11(int cantidad);
        int Altura11 { get; set; }
        string ColorOjos11 { get; set; }
        string ColorPelo11 { get; set; }
        bool ComprobarColor11(string colorLentillas);
        bool ComprobarPeso(int nuevo_peso);
        void Engordar11(int cantidad);
        int Peso11 { get; set; }
        void PonerLentillas11(string colorLentillas);
    }
}
