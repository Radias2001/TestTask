using Area;

FigureArea AreaCounter = new();
double ansRound = AreaCounter.Round(5);
double ansTr = AreaCounter.Triangle(3, 4, 5);

double ansUnRound = AreaCounter.UnknownFigure(5);
double ansUnTr = AreaCounter.UnknownFigure(7, 4, 6);

Console.WriteLine(ansRound);
Console.WriteLine(ansTr);

Console.WriteLine("----------");

Console.WriteLine(ansUnRound);
Console.WriteLine(ansUnTr);