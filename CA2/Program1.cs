//using System;

//namespace CA2
//{
//    class Program1
//    {
//        static int Main() //void
//        {
//            const double BookPriceLow = 499.99;
//            const double BookPriceMediumLow = 2499.99;
//            const double BookPriceMedium = 4999.99;
//            const double BookPriceMediumHigh = 7499.99;
//            const double BookPriceHigh = 9999.99;
//            const double TaxRate = 0.13;
//            const double DiscountChildren = 0.05;
//            const double DiscountMistery = 0.10;
//            const double DiscountFantasy = 0.15;
//            const double DiscountEducational = 0.20;
//            const double DiscountOther = 0.25;

//            string CustomerName, CelPhone;
//            int NumberOfBook1 = 0, NumberOfBook2 = 0, NumberOfBook3 = 0, NumberOfBook4 = 0, NumberOfBook5 = 0;
//            int NumberOfBook6 = 0, NumberOfBook7 = 0, NumberOfBook8 = 0, NumberOfBook9 = 0, NumberOfBook10 = 0;
//            double BookPrice1 = 0, BookPrice2 = 0, BookPrice3 = 0, BookPrice4 = 0, BookPrice5 = 0;
//            double BookPrice6 = 0, BookPrice7 = 0, BookPrice8 = 0, BookPrice9 = 0, BookPrice10 = 0;
//            double TotalDiscount = 0, TotalOrder = 0, TaxAmount = 0, SalesTotal = 0;
//            double AmountTended, Difference;

//            //Lectura de datos
//            Console.WriteLine("*-* Librería el Buen Lector  *-*");
//            Console.WriteLine("Ingrese la siguiente información");
//            Console.Write("Nombre Cliente  : ");
//            CustomerName = Console.ReadLine();
//            Console.Write("Teléfono Cliente: ");
//            CelPhone = Console.ReadLine();
//            Console.WriteLine("\nDesglose de Libros");
//            Console.WriteLine("Libro \t\t\t\t\t\tCategoría\tCantidad");
//            Console.Write("El Señor de los anillos, Las dos torres\t\tFantasía\t");
//            NumberOfBook1 = int.Parse(Console.ReadLine());
//            BookPrice1 = BookPriceMediumHigh;
//            Console.Write("Alicia en el país de la Maravillas\t\tInfantil\t");
//            NumberOfBook2 = int.Parse(Console.ReadLine());
//            BookPrice2 = BookPriceMedium;
//            Console.Write("Cementerio de Mascotas\t\t\t\tMisterio\t");
//            NumberOfBook3 = int.Parse(Console.ReadLine());
//            BookPrice3 = BookPriceMediumLow;
//            Console.Write("Quiero aprender\t\t\t\t\tEducativo\t");
//            NumberOfBook4 = int.Parse(Console.ReadLine());
//            BookPrice4 = BookPriceLow;
//            Console.Write("El poder del pensamiento Positivo\t\tSuperación\t");
//            NumberOfBook5 = int.Parse(Console.ReadLine());
//            BookPrice5 = BookPriceMedium;
//            Console.Write("Mi primer libro de matemáticas\t\t\tEducativo\t");
//            NumberOfBook6 = int.Parse(Console.ReadLine());
//            BookPrice6 = BookPriceLow;
//            Console.Write("Las aventuras de Tom Sawyer\t\t\tInfantil\t");
//            NumberOfBook7 = int.Parse(Console.ReadLine());
//            BookPrice7 = BookPriceMediumHigh;
//            Console.Write("El mago de Oz\t\t\t\t\tFantasía\t");
//            NumberOfBook8 = int.Parse(Console.ReadLine());
//            BookPrice8 = BookPriceMediumLow;
//            Console.Write("La zona muerta\t\t\t\t\tMisterio\t");
//            NumberOfBook9 = int.Parse(Console.ReadLine());
//            BookPrice9 = BookPriceHigh;
//            Console.Write("Viaje al centro de la tierra\t\t\tCiencia ficción\t");
//            NumberOfBook10 = int.Parse(Console.ReadLine());
//            BookPrice10 = BookPriceHigh;

//            //Ejecutando los cálculos
//            TotalOrder = TotalOrder + NumberOfBook1 * BookPrice1;
//            TotalDiscount = TotalDiscount + BookPrice1 * NumberOfBook1 * DiscountFantasy;
//            TotalOrder += NumberOfBook2 * BookPrice2;
//            TotalDiscount += BookPrice2 * NumberOfBook2 * DiscountChildren;
//            TotalOrder += NumberOfBook3 * BookPrice3;
//            TotalDiscount += BookPrice3 * NumberOfBook3 * DiscountMistery;
//            TotalOrder += NumberOfBook4 * BookPrice4;
//            TotalDiscount += BookPrice4 * NumberOfBook4 * DiscountEducational;
//            TotalOrder += NumberOfBook5 * BookPrice5;
//            TotalDiscount += BookPrice5 * NumberOfBook5 * DiscountOther;
//            TotalOrder += NumberOfBook6 * BookPrice6;
//            TotalDiscount += BookPrice6 * NumberOfBook6 * DiscountEducational;
//            TotalOrder += NumberOfBook7 * BookPrice7;
//            TotalDiscount += BookPrice7 * NumberOfBook7 * DiscountChildren;
//            TotalOrder += NumberOfBook8 * BookPrice8;
//            TotalDiscount += BookPrice8 * NumberOfBook8 * DiscountFantasy;
//            TotalOrder += NumberOfBook9 * BookPrice9;
//            TotalDiscount += BookPrice9 * NumberOfBook9 * DiscountMistery;
//            TotalOrder += NumberOfBook10 * BookPrice10;
//            TotalDiscount += BookPrice10 * NumberOfBook10 * DiscountOther;
//            TaxAmount = (TotalOrder - TotalDiscount) * TaxRate;
//            SalesTotal = TotalOrder - TotalDiscount + TaxAmount;

//            //Haciendo el cobro
//            Console.Write("\nMonto a Cancelar: ");
//            Console.WriteLine("{0:N2}", SalesTotal);
//            Console.Write("Monto Ahorro: ");
//            Console.WriteLine("{0:N2}", TotalDiscount);
//            returnflag:
//            Console.Write("Digite el Monto con que Cancela: ");
//            AmountTended = double.Parse(Console.ReadLine());
//            if (AmountTended >= SalesTotal)
//                Difference = AmountTended - SalesTotal;
//            else
//            {
//                Console.WriteLine("Monto insuficiente..Intente de nuevo por favor");
//                goto returnflag;
//            }
//            Console.WriteLine("Presione Enter para Imprimir la Factura");
//            Console.ReadKey();

//            //Imprimiendo la factura
//            Console.Clear();
//            Console.WriteLine("===================================================================");
//            Console.WriteLine("*-*                  Librería El Buen Lector                    *-*");
//            Console.WriteLine("===================================================================");
//            Console.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
//            Console.Write(" Cliente : ");
//            Console.WriteLine(CustomerName);
//            Console.Write(" Teléfono: ");
//            Console.WriteLine(CelPhone);
//            Console.WriteLine("-------------------------------------------------------------------");
//            Console.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
//            Console.WriteLine("-------------------------------------------------------------------");
//            if (NumberOfBook1 > 0)
//            {
//                Console.Write(" El Señor de los anillos, las..");
//                Console.Write("\t" + NumberOfBook1);
//                Console.Write("\t¢{0:N2}", BookPrice1);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook1 * BookPrice1);
//            }
//            if (NumberOfBook2 > 0)
//            {
//                Console.Write(" Alicia en el país de las mar..");
//                Console.Write("\t" + NumberOfBook2);
//                Console.Write("\t¢{0:N2}", BookPrice2);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook2 * BookPrice2);
//            }
//            if (NumberOfBook3 > 0)
//            {
//                Console.Write(" Cementerio de Mascotas   ");
//                Console.Write("\t" + NumberOfBook3);
//                Console.Write("\t¢{0:N2}", BookPrice3);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook3 * BookPrice3);
//            }
//            if (NumberOfBook4 > 0)
//            {
//                Console.Write(" Quiero aprender          ");
//                Console.Write("\t" + NumberOfBook4);
//                Console.Write("\t¢{0:N2}", BookPrice4 + "   ");
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook4 * BookPrice4);
//            }
//            if (NumberOfBook5 > 0)
//            {
//                Console.Write(" El poder del pensamiento Pos..");
//                Console.Write("\t" + NumberOfBook5);
//                Console.Write("\t¢{0:N2}", BookPrice5);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook5 * BookPrice5);
//            }
//            if (NumberOfBook6 > 0)
//            {
//                Console.Write(" Mi primer libro de matemátic..");
//                Console.Write("\t" + NumberOfBook6);
//                Console.Write("\t¢{0:N2}", BookPrice6 + "   ");
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook6 * BookPrice6);
//            }
//            if (NumberOfBook7 > 0)
//            {
//                Console.Write(" Las aventuras de Tom Sawyer");
//                Console.Write("\t" + NumberOfBook7);
//                Console.Write("\t¢{0:N2}", BookPrice7);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook7 * BookPrice7);
//            }
//            if (NumberOfBook8 > 0)
//            {
//                Console.Write(" El mago de Oz            ");
//                Console.Write("\t" + NumberOfBook8);
//                Console.Write("\t¢{0:N2}", BookPrice8);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook8 * BookPrice8);
//            }
//            if (NumberOfBook9 > 0)
//            {
//                Console.Write(" La zona muerta           ");
//                Console.Write("\t" + NumberOfBook9);
//                Console.Write("\t¢{0:N2}", BookPrice9);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook9 * BookPrice9);
//            }
//            if (NumberOfBook10 > 0)
//            {
//                Console.Write(" Viaje al centro de la tierra");
//                Console.Write("\t" + NumberOfBook10);
//                Console.Write("\t¢{0:N2}", BookPrice10);
//                Console.WriteLine("\t¢{0:N2}", NumberOfBook10 * BookPrice10);
//            }
//            Console.WriteLine("-------------------------------------------------------------------");
//            Console.Write(" Total Orden:    \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", TotalOrder);
//            Console.Write(" Total Descuento:    \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", TotalDiscount);
//            Console.Write(" Impuesto Venta: \t\t\t\t\t");
//            Console.WriteLine(TaxRate * 100 + "%");
//            Console.Write(" Impuesto Total: \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", TaxAmount);
//            Console.Write(" Precio Neto:    \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", SalesTotal);
//            Console.WriteLine("-------------------------------------------------------------------");
//            Console.Write(" Monto Recibido:");
//            Console.WriteLine("¢{0:N2}", AmountTended);
//            Console.Write(" Monto Cambio  :");
//            Console.WriteLine("¢{0:N2}", Difference);
//            Console.WriteLine("===================================================================");
//            Console.Write(" Gracias por comprar con nosotros...");
//            Console.ReadKey();
//            return 0;
//        }
//    }
//}
