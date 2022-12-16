using System;
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Func);
            ThreadParam tp = new ThreadParam(2, 6);
            myThread.Start(tp);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
            Console.WriteLine("메인스레드 종료");
        }
        private static void Func(object obj)
        {
            ThreadParam tempParam = obj as ThreadParam;
            int num = tempParam.param1 + tempParam.param2;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(100);
            }
        }
    }
    class ThreadParam
    {
        public int param1;
        public int param2;
        public ThreadParam(int num1, int num2)
        {
            this.param1 = num1; this.param2 = num2;
        }
    }