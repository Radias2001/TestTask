using Area;

namespace UnitTests
{
    [TestClass]  // ����� ������������ ������� ������� �����
    public class RoundAreaTests
    {
        [TestMethod]  // ��� ������� 5 ������� = 78,5
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
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

    [TestClass]  // ����� ������������ ������� ������� ������������
    public class TriangleAreaTests
    {
        [TestMethod]  // ��� �������� 3, 4 � 5 ������� = 6 (�������������)
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

        [TestMethod]  // ��� �������� 4, 7 � 6 ������� = 11.976539567003485
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
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

    [TestClass]  // ����� ������������ ������� ������� ����������� ������
    public class UnknownAreaTests
    {
        [TestMethod]  // ��� ����� ���������, ������ 5, ��������� ������� �����, ������ 78,5
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
        public void Unknown_negative5_ArgumentException()
        {
            // arrange
            double r = -5;

            // act
            FigureArea AreaCounter = new();

            // assert
            Assert.ThrowsException<ArgumentException>(() => AreaCounter.UnknownFigure(r));

        }

        [TestMethod]  // ��� ��� ����������, ������ 3, 4 � 5, ��������� ������� �������������� ������������, ������ 6
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

        [TestMethod]  // ��� ��� ����������, ������ 4, 7 � 6, ��������� ������� ������������, ������ 11.976539567003485
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
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

        [TestMethod]  // ��� ���� ����������, ������ 5 � 4, ��������� ������� ��������������, ������ 20
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

        [TestMethod]  // ��� ������������� �������� �������� ����������
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