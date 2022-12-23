using Area;

namespace UnitTests
{
    [TestClass]  // класс тестирования методов площади круга
    public class RoundAreaTests
    {
        [TestMethod]  // при радиусе 5 площадь = 78,5
        public void Round_5_return_78point5()
        {
            // arrange
            double r = 5;
            double expected = 78.5;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.Round(r);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Round_negative5_ArgumentException()
        {
            // arrange
            double r = -5;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.Round(r));
        }
    }

    [TestClass]  // класс тестирования методов площади треугольника
    public class TriangleAreaTests
    {
        [TestMethod]  // при сторонах 3, 4 и 5 площадь = 6 (прямоугольный)
        public void Triangle_3_4_5_return_6()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.Triangle(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при сторонах 4, 7 и 6 площадь = 11.976539567003485
        public void Triangle_4_7_6_return_11()
        {
            // arrange
            double a = 4;
            double b = 7;
            double c = 6;
            double expected = 11.976539567003485;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.Triangle(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Triangle_3_negative4_5_ArgumentException()
        {
            // arrange
            double a = 3;
            double b = -4;
            double c = 5;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.Triangle(a, b, c));
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Triangle_3_4_8_ArgumentException()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 8;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.Triangle(a, b, c));
        }
    }

    [TestClass]  // класс тестирования методов площади неизвестной фигуры
    public class UnknownAreaTests
    {
        [TestMethod]  // при одном аргументе, равным 5, вычисляет прощадь круга, равную 78,5
        public void Unknown_5_return_78point5()
        {
            // arrange
            double r = 5;
            double expected = 78.5;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.UnknownFigure(r);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Unknown_negative5_ArgumentException()
        {
            // arrange
            double r = -5;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.UnknownFigure(r));

        }

        [TestMethod]  // при трёх аргументах, равных 3, 4 и 5, вычисляет прощадь прямоугольного треугольника, равную 6
        public void Unknown_3_4_5_return_6()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.UnknownFigure(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при трёх аргументах, равных 4, 7 и 6, вычисляет прощадь треугольника, равную 11.976539567003485
        public void Unknown_4_7_6_return_11()
        {
            // arrange
            double a = 4;
            double b = 7;
            double c = 6;
            double expected = 11.976539567003485;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.UnknownFigure(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Unknown_3_negative4_5_ArgumentException()
        {
            // arrange
            double a = 3;
            double b = -4;
            double c = 5;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.UnknownFigure(a, b, c));
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Unknown_3_4_8_ArgumentException()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 8;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.UnknownFigure(a, b, c));
        }

        [TestMethod]  // при двух аргументах, равных 5 и 4, вычисляет прощадь прямоугольника, равную 20
        public void Unknown_5_4_return_20()
        {
            // arrange
            double a = 5;
            double b = 4;
            double expected = 20;

            // act
            FigureArea AreaCounter = new();
            double actual = AreaCounter.UnknownFigure(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]  // при отрицательном значении вызывает исключение
        public void Unknown_5_negative4_ArgumentException()
        {
            // arrange
            double a = 5;
            double b = -4;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.UnknownFigure(a, b));
        }
    }
}