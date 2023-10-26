using PR_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SchetVBanke USER1 = new(); //создание новых "пользователей"
            SchetVBanke USER2 = new();
            SchetVBanke USER3 = new();
            //заполнение информации о пользователях
            USER1.User(1488, "Drozdov Ivan Vitalievich", 5566);
            USER2.User(1337, "Z Artem Z", 0);
            USER3.User(228, "Kuzmin Nikolay Stanislavovich", 874);

            USER1.Operations(USER2);
            USER2.Operations(USER1);
            USER3.Operations(USER2);
            USER1.Operations(USER3);

            



        }
    }
}
