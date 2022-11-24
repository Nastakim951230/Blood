using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public double Sinus(double x)
        {
            Program program = new Program();
            double sin2 = ((1 - Math.Cos(2 * x)) / 2);
            //double sin2 = program.ZaglushkaCos();
            if (x <= 90)
            {
                return -Math.Sqrt(sin2);
            }
            else if (x > 90 && x <= 180)
            {
                return Math.Sqrt(sin2);
            }
            else if (x > 180 && x <= 270)
            {
                return -Math.Sqrt(sin2);
            }
            else if (x > 270 && x <= 360)
            {
                return Math.Sqrt(sin2);
            }
            else
            {
                return 0;
            }
        }
        public double Cosinus(double x)
        {
            Program program = new Program();
            double cos2 = 1 - Math.Pow(Sinus(x), 2);
            //double cos2 = program.ZaglushkaCos();
            if (x <= 90)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 90 && x <= 180)
            {
                return -Math.Sqrt(cos2);
            }
            else if (x > 180 && x <= 270)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 270 && x <= 360)
            {
                return -Math.Sqrt(cos2);
            }
            else
            {
                return 0;
            }

        }

        public double Logarifm_Natural(double x)
        {
            Program program = new Program();
            double ln2 = Math.Log(x) / Math.Log(Math.E);
            //double ln2 = program.ZaglushkaLn();
            return ln2;
        }
        public double Logorifm(double ocn, double x)
        {
            {
                Program program = new Program();
                double stepen = 0.1;
                while (Math.Pow(ocn, stepen) <= x)
                    stepen += 0.001;
                //double stepen = program.ZaglushkaLon();
                return stepen;
            }
        }

        public double SinCos(double x)
        {
            Program program = new Program();
            double rez;
            rez = (Math.Pow(((program.Sinus(x) + program.Cosinus(x)) + program.Cosinus(x)), 2));
            //rez = (Math.Pow(((program.ZaglushkaSin() + program.ZaglushkaCos()) + program.ZaglushkaCos()), 2));
            return rez;

        }
        public double ZaglushkaCosSin()
        {
            double x = (Math.Pow(((ZaglushkaSin() + ZaglushkaCos()) + ZaglushkaCos()), 2));
            return x;
        }
        public double ZaglushkaLnLog()
        {
            double x= (ZaglushkaLn() * ZaglushkaLon());
            return x;
        }
        public double ZaglushkaSin()
        {
            double x = Sinus(30);
            return x;
        }
        public double ZaglushkaCos()
        {
            double x = Cosinus(30);
            return x;
        }
        public double ZaglushkaLon()
        {
            double x = Logorifm(5,30);
            return x;
        }
        public double ZaglushkaLn()
        {
            double x = Logarifm_Natural(30);
            return x;
        }
        public double LogLn(double x)
        {
            Program program = new Program();
            double rez;
            rez = (program.Logarifm_Natural(x) * program.Logorifm(5, x));
            //rez = (program.ZaglushkaLn() * program.ZaglushkaLon());
            return rez;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("1 этап ");
            Console.WriteLine("Решение заглушки sin(30): {0}", program.ZaglushkaSin());
            Console.WriteLine("Решение sin(30) {0}\n", program.Sinus(30));

            Console.WriteLine("Решение заглушки cos(30): {0}", program.ZaglushkaCos());
            Console.WriteLine("Решение cos(30) {0}\n", program.Cosinus(30));

            Console.WriteLine("Решение заглушки log(5,30): {0}", program.ZaglushkaLon());
            Console.WriteLine("Решение log(5,30) {0}\n", program.Logorifm(5, 30));

            Console.WriteLine("Решение заглушки ln(30): {0}", program.ZaglushkaLn());
            Console.WriteLine("Решение ln(30) {0}\n", program.Logarifm_Natural(30));

            Console.WriteLine("2 этап ");
          
            Console.WriteLine("Решение заглушки cos и sin: {0}", program.ZaglushkaCosSin());
            Console.WriteLine("Решение cos и sin {0}\n", program.SinCos(30));

            Console.WriteLine("Решение заглушки log(5,30) и ln: {0}", program.ZaglushkaLnLog());
            Console.WriteLine("Решение log(5,30) и ln {0}\n", program.LogLn(30));
            try
            {
                Console.Write("Введите x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                
                double rez = 0;

                //Можно удалить, сделано для проверки
                //Console.WriteLine($"Cos={program.Cosinus(x)}, Sin={program.Sinus(x)}, ln={program.Logarifm_Natural(x)}, log5={program.Logorifm(5,x)}");



                if (x <= 0)
                {
                    rez = program.SinCos(x);
                    //rez = program.ZaglushkaCosSin();
                    Console.WriteLine("(((sin({0})+cos({0}))+cos({0}))^2) = {1}", x, rez);
                }
                else
                {
                    rez = program.LogLn(x);
                    //rez = program.ZaglushkaLnLog();
                    Console.WriteLine("(ln({0})*log5({0})) = {1}", x, rez);
                }

            }
            catch
            {
                Console.WriteLine("Ошибка, введите значение занова");
            }
        }
    }
}


