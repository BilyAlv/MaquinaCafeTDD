using System;

namespace MaquinaCafe
{
    public class MaquinaCafe
    {
        private bool vasosDisponibles;
        private bool azucarDisponible;
        private bool cafeDisponible;

        public MaquinaCafe(bool vasos = true, bool azucar = true, bool cafe = true)
        {
            vasosDisponibles = vasos;
            azucarDisponible = azucar;
            cafeDisponible = cafe;
        }

        public int SeleccionarVaso(string tamaño)
        {
            return tamaño switch
            {
                "Pequeño" => 3,
                "Mediano" => 5,
                "Grande" => 7,
                _ => throw new ArgumentException("Tamaño de vaso inválido")
            };
        }

        public int SeleccionarAzucar(int cucharadas)
        {
            return cucharadas;
        }

        public string PrepararCafe(string tamaño, int cucharadas)
        {
            if (!vasosDisponibles)
                return "No hay vasos disponibles";
            if (!azucarDisponible)
                return "No hay azúcar disponible";
            if (!cafeDisponible)
                return "No hay café disponible";

            int onzas = SeleccionarVaso(tamaño);
            int azucar = SeleccionarAzucar(cucharadas);

            return $"Café {tamaño} ({onzas} oz) preparado con {azucar} cucharada(s) de azúcar.";
        }
    }
}
