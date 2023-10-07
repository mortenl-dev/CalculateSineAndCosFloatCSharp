using System;
using System.CodeDom.Compiler;

namespace program {
    public class Wave {
        string executeGenerateMethod = "Executing Generate Method",
        askForUserInput = "Please input a number/angle in degrees",
        notValidNumber = "Number could not be recognized as valid. Please try again.",
        notRecognizeableNumber = "Could not recognize number. Please try again.",
        doesUserWantToContinue = "Do you wish to continue? Y/N",
        generateSinOrCos = "Press 1 to calculate Sin of a number. Press 2 for Cos.";

        public static void Main() {
            
            Wave Start = new Wave();
            Console.WriteLine(Start.generateSinOrCos);
            int SinOrCos;
            SinOrCos = Int32.Parse(Console.ReadLine()!);
            switch (SinOrCos) {
                case 1 : 
                    Start.GenerateSin();
                    break;
                case 2 : 
                    Start.GenerateCos();
                    break;
            }
            
            
            
        }
        float b;
        float a; 
        public void GenerateSin () {
            Console.WriteLine(executeGenerateMethod);
            
            try {
                Console.WriteLine(askForUserInput);
                a = float.Parse(Console.ReadLine()!); //null forgiving
                if (a > 360 || a < -360) {
                    Console.WriteLine(notValidNumber);
                    GenerateSin();
                    return;
                }
                
                for(float i = 0; i < a; ++i)
                {   
                    DisplayFloatsSin(i); //basically just a cool
                }
                DisplayFloatsSin(a);
            }
            catch (FormatException) {
                Console.WriteLine(notRecognizeableNumber);
                GenerateSin();
                return;
            }
    
            Console.WriteLine("\n"+doesUserWantToContinue);
            string answer;
            answer = Console.ReadLine()!;
            if (answer == "Y") {
                GenerateSin();
            }
            
        }
        public void DisplayFloatsSin(float temp) {
            Thread.Sleep(5);
            Console.Write("\r                          ");
            Console.Write("\r");
            b = temp * MathF.PI / 180; 
            if (temp == 180 || temp == 360) {
            Console.Write("Sin("+a+")"+" equals "+0);
            }
            else {
                Console.Write("Sin("+a+")"+" equals "+float.Round(MathF.Sin(b), 6));
            }
            
        
        }

        public void GenerateCos () {
            Console.WriteLine(executeGenerateMethod);
            
            try {
                Console.WriteLine(askForUserInput);
                a = float.Parse(Console.ReadLine()!); //null forgiving
                if (a > 360 || a < -360) {
                    Console.WriteLine(notValidNumber);
                    GenerateCos();
                    return;
                }
                
                for(float i = 0; i < a; ++i)
                {   
                    DisplayFloatsCos(i); //basically just a cool
                }
                DisplayFloatsCos(a);
            }
            catch (FormatException) {
                Console.WriteLine(notRecognizeableNumber);
                GenerateCos();
                return;
            }
    
            Console.WriteLine("\n"+doesUserWantToContinue);
            string answer;
            answer = Console.ReadLine()!;
            if (answer == "Y") {
                GenerateCos();
            }
            
        }
        public void DisplayFloatsCos(float temp) {
            Thread.Sleep(5);
            Console.Write("\r                          ");
            Console.Write("\r");
            b = temp * MathF.PI / 180; 
            if (temp == 180 || temp == 360 || temp == 90) {
            Console.Write("Cos("+a+")"+" equals "+0);
            }
            else {
                Console.Write("Cos("+a+")"+" equals "+float.Round(MathF.Cos(b), 6));
            }
            
        
        }
        
    }
}