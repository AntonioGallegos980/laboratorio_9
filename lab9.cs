using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("============================");
            Console.WriteLine("TIENDA DON LUCAS");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("============================");
            Console.WriteLine("Ingrese una opcion");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio2(); break;
                case 2:
                    ejercicio3(); break;

            }
            Console.ReadKey();

            return;
        }
        static void ejercicio2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE:");
            Console.WriteLine("============================");
            Console.WriteLine("1: lIMPIEZA ");
            Console.WriteLine("2: ABARROTES");
            Console.WriteLine("3: GOLOSINAS");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion2 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion2)
            {
                case 1: ejercicio4_1(); break;
                case 2: ejercicio4_2(); break;
                case 3: ejercicio4_3(); break;
                case 4: ejercicio4_4(); break;
                case 5: Main(); break;
            }
            return;
        }
        static void ejercicio3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE:");
            Console.WriteLine("============================");
            Console.WriteLine("1: lIMPIEZA ");
            Console.WriteLine("2: ABARROTES");
            Console.WriteLine("3: GOLOSINAS");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion3 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion3)
            {
                case 1: ejercicio4_2_1(); break;
                case 2: ejercicio4_2_2(); break;
                case 3: ejercicio4_2_3(); break;
                case 4: ejercicio4_2_4(); break;
                case 5: Main(); break;
            }
            return;
        }
        static void ejercicio4_1()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE LIMPIEZA:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de limpieza ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_1(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void ejercicio4_2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE ABARROTES:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ABARROTES ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_2(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void ejercicio4_3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE GOLOSINAS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de GOLOSINAS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_3(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void ejercicio4_4()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR VENTA DE ELECTRONICOS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos  ELECTRONICOS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_4(); break;
                case 2: ejercicio2(); break;
            }
        }
        static void ejercicio4_2_1()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE LIMPIEZA:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de limpieza ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_2_1(); break;
                case 2: ejercicio3(); break;
            }
        }
        static void ejercicio4_2_2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE ABARROTES:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ABARROTES ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_2_2(); break;
                case 2: ejercicio3(); break;
            }
        }
        static void ejercicio4_2_3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE GOLOSINAS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de GOLOSINAS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_2_3(); break;
                case 2: ejercicio3(); break;
            }

        }
        static void ejercicio4_2_4()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTAR DEVOLUCION DE electrodomesticos:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1;
            TOTAL1 = UNIDADES * PRECIO;
            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de electrodomesticos ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1: ejercicio4_2_4(); break;
                case 2: ejercicio3(); break;
            }
        }

    }
}
