using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2TVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть першу координату вектора:");
            double temp1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть другу координату вектора:");
            double temp2 = double.Parse(Console.ReadLine());
            TVector2D inp1 = new TVector2D(temp1,temp2);
            HashSet<TVector2D> vector = new HashSet<TVector2D>();
            vector.Add(inp1);
            Console.WriteLine("Отриманий вектор:");
            Console.WriteLine(inp1.ToString());
            Console.WriteLine("Автоматично створимо точку з iдентичними координатами");
            TVector2D inp2 = new TVector2D(temp1, temp2);
            vector.Add(inp2);
            Console.WriteLine("Перевiримо чи мiститьть HashSet другий вектор: ");
            if (vector.Contains(inp2)) Console.WriteLine("Так, мiстить");
            else Console.WriteLine("Нi,не мiстить");


            Console.WriteLine("Введiть першу координату вектора:");
            double temp21 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть другу координату вектора:");
            double temp22 = double.Parse(Console.ReadLine());
            TVector2D inp21 = new TVector2DF(temp21, temp22);
            HashSet<TVector2D> vector2 = new HashSet<TVector2D>();
            vector2.Add(inp21);
            Console.WriteLine("Отриманий вектор:");
            Console.WriteLine(inp21.ToString());
            Console.WriteLine("Автоматично створимо точку з iдентичними координатами");
            TVector2D inp22 = new TVector2DF(temp21, temp22);
            vector2.Add(inp22);
            Console.WriteLine("Перевiримо чи мiститьть HashSet другий вектор: ");
            if (vector2.Contains(inp22)) Console.WriteLine("Так, мiстить");
            else Console.WriteLine("Нi,не мiстить");


            Console.WriteLine("-----------------");
            Console.WriteLine("Попрацюємо з тривiмiрним вектором");
            Console.WriteLine("Створимо 5 примiрникiв класу з однаковими першими 2 координатами:");
            HashSet<TVector3D> vector3 = new HashSet<TVector3D>();
            TVector3D tri1 = new TVector3D(8,5,7);
            Console.WriteLine(tri1.ToString());
            TVector3D tri2 = new TVector3D(8, 5, 99);
            Console.WriteLine(tri2.ToString());
            TVector3D tri3 = new TVector3D(8, 5, -6);
            Console.WriteLine(tri3.ToString());
            TVector3D tri4 = new TVector3D(8, 5, 0);
            Console.WriteLine(tri4.ToString());
            TVector3D tri5 = new TVector3D(8, 5, 8);
            Console.WriteLine(tri5.ToString());
            vector3.Add(tri1);
            vector3.Add(tri2);
            vector3.Add(tri3);
            vector3.Add(tri4);
            vector3.Add(tri5);
            Console.WriteLine("Кiлькiсть елементiв у HashSet дорiвнює {0}",vector3.Count);

            Console.WriteLine("Перевизначивши методи Equals та HаshSet, повторимо попереднi дiї");
            Console.WriteLine("Створимо 5 примiрникiв класу з однаковими першими 2 координатами:");
            HashSet<TVector3DF> vector4 = new HashSet<TVector3DF>();
            TVector3DF tri21 = new TVector3DF(8, 5, 7);
            Console.WriteLine(tri21.ToString());
            TVector3DF tri22 = new TVector3DF(8, 5, 99);
            Console.WriteLine(tri22.ToString());
            TVector3DF tri23 = new TVector3DF(8, 5, -6);
            Console.WriteLine(tri23.ToString());
            TVector3DF tri24 = new TVector3DF(8, 5, 0);
            Console.WriteLine(tri24.ToString());
            TVector3DF tri25 = new TVector3DF(8, 5, 8);
            Console.WriteLine(tri25.ToString());
            vector4.Add(tri21);
            vector4.Add(tri22);
            vector4.Add(tri23);
            vector4.Add(tri24);
            vector4.Add(tri25);
            Console.WriteLine("Кiлькiсть елементiв у HashSet дорiвнює {0}", vector4.Count);


            Console.WriteLine("-----------------");
            Console.WriteLine("Перевiримо наявнi методи з векторaмu - {0} i {1}",inp21.ToString(), inp1.ToString());
            Console.WriteLine("Довжина першого вектора:");
            Console.WriteLine(inp21.VectorLength());
            Console.WriteLine("Нормований вектор:");
            Console.WriteLine(inp21.ToNormVector());
            Console.WriteLine(inp21);
            Console.WriteLine("Перевiримо чи рiвний попередьньому:");
            if (inp21.IsTheSame(inp1)) Console.WriteLine("Вектори рiвнi");
            else Console.WriteLine("Вектори не рiвнi");
            Console.WriteLine("Додамо два ветора:");
            Console.WriteLine(inp21 + inp1);
            Console.WriteLine("Вiднiмимо два ветора:");
            Console.WriteLine(inp21 - inp1);
            Console.WriteLine("Помножимо два ветора:");
            Console.WriteLine(inp21 * inp1);
            

            Console.ReadKey();
        }
    }
}
