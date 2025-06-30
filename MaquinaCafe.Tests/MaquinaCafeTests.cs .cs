using Xunit;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    public class MaquinaCafeTests
    {
        [Theory]
        [InlineData("Peque�o", 3)]
        [InlineData("Mediano", 5)]
        [InlineData("Grande", 7)]
        public void SeleccionarVaso_DevuelveCantidadDeCafe(string tama�o, int esperado)
        {
            var maquina = new MaquinaCafe(true, true, true);
            int resultado = maquina.SeleccionarVaso(tama�o);
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void SeleccionarAzucar_DevuelveCantidadCorrecta()
        {
            var maquina = new MaquinaCafe(true, true, true);
            int cucharadas = maquina.SeleccionarAzucar(2);
            Assert.Equal(2, cucharadas);
        }

        [Fact]
        public void HacerCafe_SinVasos_MuestraMensaje()
        {
            var maquina = new MaquinaCafe(false, true, true);
            string resultado = maquina.PrepararCafe("Peque�o", 2);
            Assert.Equal("No hay vasos disponibles", resultado);
        }

        [Fact]
        public void HacerCafe_SinCafe_MuestraMensaje()
        {
            var maquina = new MaquinaCafe(true, true, false);
            string resultado = maquina.PrepararCafe("Grande", 1);
            Assert.Equal("No hay caf� disponible", resultado);
        }

        [Fact]
        public void HacerCafe_SinAzucar_MuestraMensaje()
        {
            var maquina = new MaquinaCafe(true, false, true);
            string resultado = maquina.PrepararCafe("Mediano", 3);
            Assert.Equal("No hay az�car disponible", resultado);
        }

        [Fact]
        public void HacerCafe_TodoDisponible_PreparaCorrectamente()
        {
            var maquina = new MaquinaCafe(true, true, true);
            string resultado = maquina.PrepararCafe("Grande", 2);
            Assert.Equal("Caf� Grande (7 oz) preparado con 2 cucharada(s) de az�car.", resultado);
        }
    }
}
