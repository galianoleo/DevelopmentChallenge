using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Strategy;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Calculo.Imprimir(new List<IFormas>(), Idiomas.Espaniol));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Calculo.Imprimir(new List<IFormas>(), Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormas> {new Cuadrado(5)};

            var resumen = Calculo.Imprimir(cuadrados, Idiomas.Espaniol);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormas>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Calculo.Imprimir(cuadrados, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormas>
            {
                new Cuadrado(5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado(2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = Calculo.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormas>
            {
                 new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Calculo.Imprimir(formas, Idiomas.Espaniol);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        #region TestLG
        [TestCase]
        public void TestResumenListaConUnRectanguloEnCastellano()
        {
            var cuadrados = new List<IFormas> { new Rectangulo(3, 1) };
            var resumen = Calculo.Imprimir(cuadrados, Idiomas.Espaniol);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 3 | Perimetro 8 <br/>TOTAL:<br/>1 formas Perimetro 8 Area 3", resumen);
        }
        [TestCase]
        public void TestResumenListaConUnRectanguloEnItaliano()
        {
            var cuadrados = new List<IFormas> { new Rectangulo(3, 1) };
            var resumen = Calculo.Imprimir(cuadrados, Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto sui moduli</h1>1 Rettangolo | Zona 3 | Perimetro 8 <br/>TOTALE:<br/>1 forme Perimetro 8 La zona 3", resumen);
        }
        [TestCase]
        public void TestResumenListaConCuadradoRectanguloCirculoTrianguloEnCastellano()
        {
            var formas = new List<IFormas>
            {
                 new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(7,5)
            };

            var resumen = Calculo.Imprimir(formas, Idiomas.Espaniol);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>1 Rectángulo | Area 35 | Perimetro 24 <br/>TOTAL:<br/>8 formas Perimetro 121.66 Area 126.65",
                resumen);
        }
        #endregion
    }
}
