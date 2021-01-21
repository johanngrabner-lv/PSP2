using System;

namespace SayHelloWithDelegates
{
    delegate string DelegateHello(string g);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SayHello(Spanish,"F");
            SayHello(Spanish,"M");
            SayHello(German,"M");

            BegruessungsGenerator begruessungsGenerator = new BegruessungsGenerator();

            SayHello(begruessungsGenerator.Hoeflich,"F");
            SayHello(begruessungsGenerator.SaloppUndZwanglos,"F");

            SayHello(DemoFuerLambda, "F");
            //x fließt in die Methode
            SayHello(x => "Seruvs. Sie sind " + x, "F");

            SayHello(x =>
            {
                if (x == "F")
                    return "Sehr geehrte Frau ";
                else
                    return "Sehr geehrte Herr";
            },
            "F");


        }

        public static string DemoFuerLambda(string g)
        {
            return "Servus. Sie sind " + g;
        }

        public static string Spanish(string geschlecht)
        {
            string result = "";
            if (geschlecht=="F")
            {
                result = "Hola Sinorita";
            }
            else
            {
                result = "Hola Hombre";
            }
            return result;
                 
        }
        public static string German(string geschlecht)
        {
            string result = "";
            if (geschlecht == "F")
            {
                result = "Sehr geehrte Frau";
            }
            else
            {
                result = "Sehr geehrter Herr";
            }
            return result;

        }
        public static void SayHello(DelegateHello delHello, string geschlecht)
        {
            string begruessung = delHello(geschlecht);
            Console.WriteLine(begruessung);
        }
    }
}
