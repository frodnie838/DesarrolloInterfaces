using simulacro.Logica;

namespace SimulacroTest
{
    [TestClass]
    public sealed class SaludoServiceTests
    {
              
        [TestMethod]
        public void ObtenerSaludo_NoEsNulo()
        {
            SaludoService servicio = new SaludoService();
            string resultado = servicio.ObtenerSaludo();

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void ObtenerSaludo_ContienePalabraBienvenido()
        {
            SaludoService servicio = new SaludoService();
            string resultado = servicio.ObtenerSaludo();

            Assert.IsTrue(resultado.Contains("Bienvenid"));
        }

        [TestMethod]
        public void ObtenerSaludo_DevuelveTextoIncorrecto()
        {
            SaludoService servicio = new SaludoService();
            string resultado = servicio.ObtenerSaludo();

            // Fallo intencionado
            Assert.AreEqual("Hola", resultado);
        }
        
    }
}
