using System;
/*
namespace NS_CC
{
    class _main
    {
        static void Main(string[] args)
        {
            Marine marine = new Marine();

            UNIT one = marine;
            one.Comment();

            UNIT two = new Vulture();
            two.Comment();

            UNIT three = new Battlecruiser();
            three.Comment();
        }
    }

    class UNIT
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        
        private bool _Able_to_fly;
        public bool Able_to_fly
        {
            get { return _Able_to_fly; }
            set { _Able_to_fly = value; }
        }

        virtual public void Comment()
        {
            Console.WriteLine("띠요옹");
        }
    }

    class Marine : UNIT
    {
        public Marine()
        {
            Name = "Marine";
            Able_to_fly = false;
        }
        override public void Comment()
        {
            Console.WriteLine("고고고");
        }
    }

    class Vulture : UNIT
    {
        public Vulture()
        {
            Name = "Vulture";
            Able_to_fly = false;
        }
        override public void Comment()
        {
            Console.WriteLine("마인마인");
        }
    }

    class Battlecruiser : UNIT
    {
        public Battlecruiser()
        {
            Name = "BattleCruiser";
            Able_to_fly = true;
        }
        override public void Comment()
        {
            Console.WriteLine("빠틀");
        }
    }
}
*/
/*
namespace NS_CC
{
    class _main
    {
        static void Main(string[] args)
        {
            Won won = new Won();
            won.Money = 1000;
            Console.WriteLine(won.ToString());
        }
    }

    public class Currency
    { 
        private decimal _Money;
        public decimal Money
        {
            get
            {
                return _Money;
            }
            set
            {
                _Money = value;
            }
        }        
    }

    public class Won : Currency
    {
        public override string ToString()
        {
            return Money + " Won";
        }
    }
}
*/
/*
namespace NS_CC
{
    class _main
    {
        delegate void WorkDelegate(char arg1, int arg2, int arg3);

        static void Main(string[] args)
        {
            Math math = new Math();
            WorkDelegate work = math.Calc;

            work('+', 10, 50);
            work('-', 29, 30);
        }
    }
    public class Math
    {
        delegate int CC_CALLBACK_2_Calc(int x, int y);

        static int Add(int x,int y) { return x + y; }
        static int Sub(int x,int y) { return x - y; }
        static int Mul(int x,int y) { return x * y; }
        static int Div(int x,int y) { return x / y; }

        CC_CALLBACK_2_Calc[] Methods;

        public Math()
        {
            Methods = new CC_CALLBACK_2_Calc[] { Math.Add, Math.Sub, Math.Mul, Math.Div };
        }

        public void Calc(char opcode,int operand_1,int operand_2)
        {
            switch (opcode)
            {
                case '+':
                    Console.WriteLine(opcode + ": " + Methods[0](operand_1, operand_2));
                    break;
                case '-':
                    Console.WriteLine(opcode + ": " + Methods[1](operand_1, operand_2));
                    break;
                case '*':
                    Console.WriteLine(opcode + ": " + Methods[2](operand_1, operand_2));
                    break;
                case '/':
                    Console.WriteLine(opcode + ": " + Methods[3](operand_1, operand_2));
                    break;
            }
        }

    }
}
*/
/*
namespace NS_CC
{
    class _main
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x,int y) { Console.WriteLine(x + y);}
        static void Sub(int x,int y) { Console.WriteLine(x - y);}
        static void Mul(int x,int y) { Console.WriteLine(x * y);}
        static void Div(int x,int y) { Console.WriteLine(x / y);}

        delegate int CALLBACK_3(int x, int y, int z);

        CALLBACK_3 callback_3;



        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Sub;
            calc += Mul;
            calc += Div;

            calc(10, 5);
        }



    }
}*/

namespace NS_CC
{
    delegate int GetresultDelegate();

    class Target
    {
        public void Do(GetresultDelegate getResult)
        {
            Console.WriteLine(getResult);
        }
    }

    class Source
    {
        public int GetResult()
        {
            return 10;
        }

        public void Test()  
        {
            Target target = new Target();
            target.Do(new GetresultDelegate(this.GetResult));
            
        }
    }
}