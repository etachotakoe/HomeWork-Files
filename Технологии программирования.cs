

using System;
using System.Diagnostics.Eventing.Reader;

class Program
{
    static void Main()
    {
        /* Задание 1:Вывести на экран число e (основание натурального логарифма) с точностью до
десятых.*/


        Console.WriteLine("Задание 1.Вывести на экран число e (основание натурального логарифма) с точностью до\r\nдесятых.");
        double e = Math.E;



        Console.WriteLine(e.ToString("F1"));



        // Задание 2: Вывести на экран числа 50 и 10 одно под другим.

        Console.WriteLine("Задание 2: Вывести на экран числа 50 и 10 одно под другим.");

        int a1 = 50;
        int b1 = 10;

        Console.WriteLine(a1); Console.WriteLine(b1);



        // Задание 3: Составить программу вывода на экран «столбиком» четырех любых чисел.

        Console.WriteLine("Задание 3: Составить программу вывода на экран «столбиком» четырех любых чисел.");

        int c = 1;
        int d = 2;
        int m = 3;
        int f = 4;

        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(m);
        Console.WriteLine(f);



        /* Задание 4: Пользователь вводит число. Выведите на экран число, которое больше введенного
        на 10.*/

        Console.WriteLine("Задание 4: Пользователь вводит число.Выведите на экран число, которое больше введенного на 10.");

        Console.Write("Введите число: ");

        int number = Convert.ToInt32(Console.ReadLine()); /*Программа считывает введеное число с помощью конслридлайн
        которое возвращает строку. Далее конверттоинт32 преоьразует строку в число и оно сохраняется в переменной number*/
        int result = number + 10;

        Console.WriteLine("Число, большее на 10: " + result);



        // Задание 5: Дана сторона квадрата. Найти его периметр.

        Console.WriteLine("Задание 5: Дана сторона квадрата. Найти его периметр.");

        Console.Write("Введите длину стороны квадрата: ");

        int number1 = Convert.ToInt32(Console.ReadLine());
        int result1 = number1 * 4;

        Console.WriteLine("Периметр квадрата равен: " + result1);



        /*Задание 6: Дан радиус окружности. Найти длину окружности и площадь круга.*/


        Console.WriteLine("Задание 6: Дан радиус окружности. Найти длину окружности и площадь круга.");

        Console.Write("Введите радиус окружности: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double result2 = 2 * number * Math.PI;
        double result3 = number2 * number2 * Math.PI;

        Console.WriteLine("Длина окружности: " + result2);
        Console.WriteLine("Площадь круга: " + result3);

        // Задание 7: Найти значение y=cos(x).

        Console.WriteLine("Задание 7: Найти значение y=cos(x).");

        Console.Write("Введите угол в градусах: ");

        double degrees = Convert.ToDouble(Console.ReadLine());
        double radians = degrees * (Math.PI / 180);
        double y = Math.Cos(radians);

        Console.WriteLine("y = cos(" + degrees + "°) = " + y);

        //Задание 8: Даны основания и высота равнобедренной трапеции. Найти ее периметр.

        Console.WriteLine("Задание 8: Даны основания и высота равнобедренной трапеции. Найти ее периметр.");


        Console.Write("Введите длину первого основания равнобедренной трапеции (a): ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину второго основания равнобедренной трапеции (b): ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту равнобедренной трапеции (h): ");
        double h = Convert.ToDouble(Console.ReadLine());

        double side = Math.Sqrt(Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2));
        double perimeter = a + b + 2 * side;

        Console.WriteLine("Периметр равнобедренной трапеции: " + perimeter);



        /*Задание 9: Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
если купили x кг конфет, у кг печенья и z кг яблок.*/



        Console.WriteLine("Задание 9. ");

        Console.Write("Введите стоимость 1 кг конфет (в рублях): ");
        double konf = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите желаемый вес покупаемых конфет (в килограммах): ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите стоимость 1 кг печенья (в рублях): ");
        double ck = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите желаемый вес покупаемого печенья (в килограммах): ");
        double y5 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите стоимость 1 кг яблок (в рублях): ");
        double apl = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите желаемый вес покупаемых яблок (в килограммах): ");
        double z = Convert.ToDouble(Console.ReadLine());

        double totalCost = konf * x + ck * y5 + apl * z;
        Console.WriteLine("Стоимость всей покупки: " + totalCost);


        /* Задание 10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
        (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
          Мир Труд Май
          Затем так:
         Мир
              Труд
                      Май*/

        Console.WriteLine("Напишите программу, выводит на экран три строки \"Мир\", \"Труд\" и \"Май\"\r\n        (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:\r\n          Мир Труд Май\r\n          Затем так:\r\n         Мир\r\n              Труд\r\n                      Май");
        Console.WriteLine("Результат: ");
        Console.WriteLine("Мир Труд Май");

        Console.WriteLine("Мир");
        Console.WriteLine("\t Труд");
        Console.WriteLine("\t\t Май");

        /* Задание 11. Программа просит пользователя ввести 2 числовые переменные. А после она
меняет их местами и выводит результат на экран. Но, так как пользователь может
ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
например, букву или строку, а так же учесть, что число может быть дробным, и для
выделения её дробной части одни используют точку, другие – запятую.*/

        Console.WriteLine("Программа просит пользователя ввести 2 числовые переменные. А после она\r\nменяет их местами и выводит результат на экран. Но, так как пользователь может\r\nошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,\r\nнапример, букву или строку, а так же учесть, что число может быть дробным, и для\r\nвыделения её дробной части одни используют точку, другие – запятую.");

        double firstNumber, secondNumber; //обЪявляем переменные для хранения двух чисел.

        Console.Write("Введите первое число: ");
        while (!double.TryParse(Console.ReadLine(), out firstNumber)) //проверяем правильно ли введено число.
        {
            Console.WriteLine("Ошибка: введите корректное число.");
        }

        Console.Write("Введите второе число: ");
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("Ошибка: введите корректное число.");
        }

        double temp = firstNumber; // сохраняем первое число во временной переменной 
        firstNumber = secondNumber; // заменяем первое вторым
        secondNumber = temp; // заменяем второе первым

        Console.WriteLine($"Первое число после обмена: {firstNumber}");
        Console.WriteLine($"Второе число после обмена: {secondNumber}");

        /* Задание 12: Программа для подсчета периметра и площади фигур (треугольник,
четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
будет считать – площадь или периметр. Задаётся все необходимые значения, а на
основе полученных результатов, программа должна подсчитать, какими могли бы
быть периметры или площади остальных фигур.*/

        Console.WriteLine("Задание 12: Программа для подсчета периметра и площади фигур (треугольник,\r\nчетырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа\r\nбудет считать – площадь или периметр. Задаётся все необходимые значения, а на\r\nоснове полученных результатов, программа должна подсчитать, какими могли бы\r\nбыть периметры или площади остальных фигур.");
        Console.WriteLine("Выберите фигуру, над которой будут выполнятся вычислительные операции: ");
        Console.WriteLine("1. Треугольник ");
        Console.WriteLine("2. Четырехугольник ");
        Console.WriteLine("3. Круг ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Вычислить: ");
        Console.WriteLine("1. Периметр ");
        Console.WriteLine("2. Площадь ");
        int calculationChoice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: // треугольник
                if (calculationChoice == 1) // периметр
                {
                    Console.WriteLine("Введите длины сторон треугольника: ");
                    double sidetrigA = Convert.ToDouble(Console.ReadLine());
                    double sidetrigB = Convert.ToDouble(Console.ReadLine());
                    double sidetrigC = Convert.ToDouble(Console.ReadLine());
                    double perimeter0 = sidetrigA + sidetrigB + sidetrigC;
                    Console.WriteLine($"Периметр треугольника равен: {perimeter0}");
                }
                else if (calculationChoice == 2) // площадь
                {
                    Console.WriteLine("Введите основание треугольника: ");
                    double basetrig = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите высоту треугольника: ");
                    double heighttrig = Convert.ToDouble(Console.ReadLine());

                    double area0 = 0.5 * basetrig * heighttrig;
                    Console.WriteLine($"Площадь треугольника равна: {area0}");
                }
                break; // выход из свитч



            case 2: // четырехугольник
                if (calculationChoice == 1) // периметр
                {
                    Console.WriteLine("Введите длину и ширину четырехугольника: ");
                    double side4A = Convert.ToDouble(Console.ReadLine());
                    double side4B = Convert.ToDouble(Console.ReadLine());

                    double perimeter4 = 2 * (side4A + side4B);
                    Console.WriteLine($"Периметр четырехугольника равен: {perimeter4}");
                }
                else if (calculationChoice == 2) // площадь
                {
                    Console.WriteLine("Введите длину и ширину четырехугольника: ");
                    double side4A1 = Convert.ToDouble(Console.ReadLine());
                    double side4A2 = Convert.ToDouble(Console.ReadLine());

                    double area1 = side4A1 * side4A2;
                    Console.WriteLine($"Площадь четырехугольника равна: {area1}");
                }
                break;



            case 3: // круг
                if (calculationChoice == 1) // периметр (длина окружности)
                {
                    Console.WriteLine("Введите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double perimeterCircle = 2 * Math.PI * radius;
                    Console.WriteLine($"Периметр круга равен: {perimeterCircle}");
                }
                else if (calculationChoice == 2) // площадь
                {
                    Console.WriteLine("Введите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double areaCircle = Math.PI * radius * radius;
                    Console.WriteLine($"Площадь круга равна: {areaCircle}");
                }
                break;
            default:
                Console.WriteLine("Неправильный выбор фигуры.");
                break; // добавлено для обработки неверного выбора



        }//конец задания 12

        /*Задание 13.Составить программу вывода на экран числа, вводимого с клавиатуры.Вводимому
числу должно предшествовать сообщение «Вы ввели число».*/

        Console.WriteLine("Составить программу вывода на экран числа, вводимого с клавиатуры.Вводимому\r\nчислу должно предшествовать сообщение «Вы ввели число».");
        Console.Write("Введите число: ");
        double z13 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Вы ввели число: " + z13);


        /* Задание 14. Составить программу вывода на экран следующей информации:
2 кг
13 17*/

        Console.WriteLine("Задание 14. Составить программу вывода на экран следующей информации:\r\n2 кг\r\n13 17");

        Console.WriteLine("2 кг");
        Console.WriteLine("13 17");

        // Задание 15. Составить программу вывода на экран «столбиком» четырех случайных чисел.

        Console.WriteLine("Задание 15. Составить программу вывода на экран «столбиком» четырех случайных чисел.");
        Console.WriteLine(new Random().Next(1, 101));
        Console.WriteLine(new Random().Next(1, 101));
        Console.WriteLine(new Random().Next(1, 101));
        Console.WriteLine(new Random().Next(1, 101));

        /*16. Найти корни квадратного уравнения(коэффициента задаются пользователем с
        клавиатуры)*/

        Console.WriteLine(" Задание 16. Найти корни квадратного уравнения(коэффициента задаются пользователем с\r\nклавиатуры)");

        Console.WriteLine("Введите коэффиценты квадратного уравнения (ax^2+bx+c=0) ");

        Console.Write("a: ");
        double acoef = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double bcoef = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double ccoef = Convert.ToDouble(Console.ReadLine());

        if (acoef == 0)
        {
            Console.WriteLine("Коэффицент в не может быть равен 0. Введите другое значение.");
            return;
        }

        double discriminant = bcoef * bcoef - 4 * acoef * ccoef;

        if (discriminant > 0)
        {
            double root1 = (-bcoef + Math.Sqrt(discriminant) / (2 * acoef));

            double root2 = (-bcoef - Math.Sqrt(discriminant) / (2 * acoef));

            Console.WriteLine("Первый корень: " + root1);
            Console.WriteLine("Второй корень: " + root2);


        }
        else if (discriminant == 0)
        {
            double root0 = (-bcoef / (2 * acoef));

            Console.WriteLine("Корень уравнения: " + root0);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }



       
        /*17.Даны два целых числа.Найти: а) их среднее арифметическое; б) их среднее
геометрическое.*/

        Console.WriteLine("Задание 17.Даны два целых числа.Найти: а) их среднее арифметическое; б) их среднее\r\nгеометрическое.");

                     Console.WriteLine("Введите первое число.");
                                 double z117 = Convert.ToDouble(Console.ReadLine());
                     Console.WriteLine("Введите второе число.");
                                 double z217 = Convert.ToDouble(Console.ReadLine());
        double res1 = (z117 + z217) / 2;
        double res2 = Math.Sqrt(z117 * z217);
            Console.WriteLine("Среднее арифметическое: " + res1);
            Console.WriteLine("Среднее геометрическое: " + res2);

        /*18. Известны координаты на плоскости двух точек. Составить программу вычисления
         расстояния между ними.*/


        Console.WriteLine("Введите координаты первой точки на плоскости. Первое число соответствует x1, второе - y1.");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки на плоскости. Первое число соответствует x2, второе - y2");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double S = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine("Расстояние между точками: " + S);



        /*20. С начала суток прошло n секунд. Определить:
                 а) сколько полных часов прошло с начала суток;
                 б) сколько полных минут прошло с начала очередного часа;
                 в) сколько полных секунд прошло с начала очередной минуты.*/

        Console.WriteLine("20. С начала суток прошло n секунд. Определить:\r\nа) сколько полных часов прошло с начала суток;\r\nб) сколько полных минут прошло с начала очередного часа;\r\nв) сколько полных секунд прошло с начала очередной минуты.");

        Console.Write("Введите количество секунд, прошедших с начала суток: ");
        int n = Convert.ToInt32(Console.ReadLine());

   
        int hours = n / 3600;  // Полные часы
        Console.WriteLine("Полных часов прошло с начала суток: " + hours);

        
        int minutes = (n % 3600) / 60;// Полные минуты с начала текущего часа
        Console.WriteLine("Полных минут прошло с начала текущего часа: " + minutes);

        
        int seconds = n % 60;// Полные секунды с начала текущей минуты
        Console.WriteLine("Полных секунд прошло с начала текущей минуты: " + seconds);



        /*21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
        мм можно отрезать от него?*/

        Console.WriteLine("Задание 21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130\r\n        мм можно отрезать от него?");
          
        Console.WriteLine("Вычислим площадь прямоугольника, чтобы далее использовать эту площадь как делимое.");
        double pr1 = 530 * 130;
            Console.WriteLine("Площадь прямоугольника: " + pr1 );
        Console.WriteLine("Вычислим площадь квадрата, чтобы использовать эту площадь как делитель.");
        double sq1 = 130 * 130;
            Console.WriteLine("Площадь квадрата: " + sq1 );
        double op = pr1 / sq1;
        Console.WriteLine("Количество квадратов с заданными параметрами, которое возможно отрезать от прямоугольника (только целое):  " + op.ToString("F0") );

       

    }



}
