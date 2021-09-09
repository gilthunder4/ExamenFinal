using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Program
    {
        struct Trabajador
        {
            public int codigo;
            public string nombre;
            public string apellido;
            public double sueldo;
            public double ISSS;
            public double AFP;
            public double RENTA;
            public double Total;
            public double sueldoneto;
        }
        static int Menu()
        {
            int mn;
            StringBuilder cad = new StringBuilder();
            cad.AppendLine("MENU DE OPCIONES");
            cad.AppendLine(" ");
            cad.AppendLine("1. Agregar trabajador");
            cad.AppendLine("2. Mostrar plantilla");
            cad.AppendLine("3. Salir");
            cad.AppendLine(" ");
            cad.AppendLine("Digite la opcion");
            Console.WriteLine(cad);
            mn = Convert.ToInt32(Console.ReadLine());
            return mn;
        }

        static Trabajador agregarTrabajador()
        {
            Trabajador trab = new Trabajador();
            Console.Write("Digite el codigo: ");
            trab.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el nombre del trabajador: ");
            trab.nombre = Console.ReadLine();
            Console.Write("Digite el apellido del trabajador: ");
            trab.apellido = Console.ReadLine();
            Console.Write("Digite el sueldo: ");
            trab.sueldo = Convert.ToDouble(Console.ReadLine());
            trab.ISSS = trab.sueldo * 0.03;
            trab.AFP = trab.sueldo * 0.0725;
            trab.RENTA = trab.sueldo * 0.1;
            trab.Total = trab.ISSS + trab.AFP + trab.RENTA;
            trab.sueldoneto = trab.sueldo - trab.Total;
            return trab;
        }
        static void Lista(ArrayList lst)
        {
            if (lst.Count == 0)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine("Codigo\tNombre\tApellido\tSueldo\tDescuento\tSueldo neto");
                foreach (Trabajador item in lst)
                {
                    Console.Write(item.codigo + "\t");
                    Console.Write(item.nombre + "\t");
                    Console.Write(item.apellido + "\t");
                    Console.Write(item.sueldo + "\t");
                    Console.Write(item.Total + "\t");
                    Console.WriteLine("        " + item.sueldoneto);

                }
            }
        }

        static void Main(string[] args)
        {


            ArrayList listaTrab = new ArrayList();
            int tb;
            do
            {
                Console.Clear();
                tb = Menu();
                switch (tb)
                {
                    case 1:
                        listaTrab.Add(agregarTrabajador());
                        break;
                    case 2:
                        Lista(listaTrab);
                        break;
                    case 3:
                        Console.WriteLine("Esta abandonando el programa");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.ReadKey();
            } while (tb != 3);
        }
    }
}
