using System;

namespace ClassLibrary3
{
    public static class Class1
    {
        
        public static double MinAVG(string[] Marks)
        {
            int[] intMarks = new int[Marks.Length];
            double a = 0;
            double b = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine(Marks[i]);
                intMarks[i] = Convert.ToInt32(Marks[i]);
                a = a + intMarks[i];
                Console.WriteLine(a);
            }
            b = a / intMarks.Length;
            Console.WriteLine(b);
            return b;
        }

        public static string GetStudNumber(int year, int group, string fio)
        {
            string _year = Convert.ToString(year);
            string _group = Convert.ToString(group);
            string[] _fio = fio.Split(' ');
            string name = _fio[0];
            string surname = _fio[1];
            string otchstvo = _fio[2];
            string vozvrat = _year + '.' + _group + '.' + Convert.ToString(name[0]) + Convert.ToString(surname[0]) + Convert.ToString(otchstvo[0]);
            Console.WriteLine(vozvrat);
            return vozvrat;
        }
    }
}
