using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_Programacion2_MatthiasPaniagua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sistema=1,anhoV;
            double kilometraje,iva,descuento=0;
            string op=string.Empty, descS=string.Empty,costoOp=string.Empty;
            string[] servicios = {"Reparaciones basicas","Mantenimiento Preventivo","Reparacion de motores","Diagnostico de sistemas" };
            double[] costo = new double[servicios.Length];
            double subtotal = costo[1] - descuento;
            iva = subtotal * 0.13;
            double total = subtotal + iva;

            while (sistema == 1)
            {
                Console.WriteLine("---Sistema de Servicios AutoSoluciones---");
                Console.WriteLine("-                                       -");
                Console.WriteLine("-         Seleccione una accion         -");
                Console.WriteLine("-      1. Tipos de Servicios            -");
                Console.WriteLine("-      2. Descripcion de servicios      -");
                Console.WriteLine("-      3. Calcular costo de servicios   -");
                Console.WriteLine("-      4. Salir                         -");
                Console.WriteLine("-                                       -");
                Console.WriteLine("-----------------------------------------");
                Console.Write(" --> ");
                op = Console.ReadLine();
                Console.WriteLine(" ");
                switch (op)
                {
                    case "1":
                        Console.WriteLine(" --- Tipos de servicios ----");
                        for (int i = 0; i < servicios.Length; i++)
                        {
                            Console.WriteLine(" " + (i + 1) + " " + servicios[i]);

                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(" Presione Enter para continuar");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine(" De cual servicio desea saber la descripcion? \n" +
                            " ");
                        for (int i = 0; i < servicios.Length; i++)
                        {
                            Console.WriteLine(" " + (i + 1) + " " + servicios[i]);
                        }
                        Console.Write(" --> ");
                        descS =Console.ReadLine();
                        switch (descS)
                        {
                            case "1":
                                Console.WriteLine(" ");
                                Console.WriteLine(" Descripcion de " + servicios[0]);
                                 Console.WriteLine("Las reparaciones basicas sirven para mantener el vehiculo en regla y en funcionamiento, como por ejemplo:\n" +
                                     "cambio de aceite y filtro, Presion de neumaticos, Aire acondicionado, discos y pastillas de freno\n" +
                                     "bomba de agua, escobillas, entre muchas otras.\n" +
                                     "  ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine(" ");
                                Console.WriteLine(" Descripcion de " + servicios[1]);
                                Console.WriteLine("Es un mantenimiento regular y de rutina que sirve para ayudar a mantener tu vehículo en funcionamiento\n" +
                                    "evitando cualquier tiempo de inactividad y gastos por fallas imprevistas del equipo.\n" +
                                    "   ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break;
                            case "3":
                                Console.WriteLine(" ");
                                Console.WriteLine(" Descripcion de " + servicios[2]);
                                Console.WriteLine("Consiste en desarmar completamente las piezas del motor, limpiarlo a fondo, medir y rectificar las partes,\n" +
                                    "cambiar las piezas que sean necesarias y volverlas a ensamblar según las especificaciones que el motor necesite . \n" +
                                    " ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break; 
                            case "4":
                                Console.WriteLine(" ");
                                Console.WriteLine(" Descripcion de " + servicios[3]);
                                Console.WriteLine("El diagnostico de sistemas es un servicio para encontrar fallas específicas, como ruidos, golpes, fallas entre otros\n" +
                                    " y la revisión son inspecciones generalmente visuales que ayudan a conocer el estado en general del vehiculo. ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break;
                            default:
                               
                                Console.WriteLine(" ");
                                Console.WriteLine("   Por favor escoga una opcion valida.");
                                Console.WriteLine(" ");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine(" ");
                        Console.WriteLine(" De cual servicio desearia saber el costo? ");
                        for (int i = 0; i < servicios.Length; i++)
                        {
                            Console.WriteLine(" " + (i + 1) + " " + servicios[i]);
                        }
                        Console.Write(" --> "); costoOp = Console.ReadLine();
                        Console.WriteLine(" ");
                        switch (costoOp) {
                            case "1":
                                Console.WriteLine(" El precio de cada reparacion basica individualmente es de $25,000 colones \n" +
                                    " ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break; 
                            case "2":
                                Console.WriteLine(" 20,000Km o menos  $50,000 / 21,000Km a 40,000Km $75,000 / Mas de 40,000Km $100,000");
                                Console.WriteLine("Los precios varian dependiendo la cantidad de kilometros y el anho de su vehiculo.");
                                Console.WriteLine(" ");
                                Console.WriteLine("Digite el kilometraje del vehiculo en cuestion ");
                                Console.Write(" --> "); kilometraje = double.Parse(Console.ReadLine()); 
                                if (kilometraje <= 20000)
                                {
                                    costo[1]=kilometraje*2.5;
                                }if (kilometraje>=21000 && kilometraje <= 40000)
                                {
                                    costo[1] = kilometraje * 1.875;
                                }if(kilometraje > 40000) { costo[1] = kilometraje * 2.5; }
                                Console.WriteLine(" \n" +
                                    " Costo: $"+costo[1]);
                                Console.WriteLine(" ");
                                Console.WriteLine(" Digite el anho del vehiculo (Ej: 2019)\n" +
                                    "   Por cada 5 anhos de antiguedad del vehiculo se le hace un %2,5 de descuento (max %10 de descuento)");
                                    Console.Write("--> "); anhoV = int.Parse(Console.ReadLine());


                                if (anhoV==2025 && anhoV>=2020 ){
                                    Console.WriteLine("No aplica descuento, el vehiculo no tiene 5 o mas anhos de antiguedad.");
                                    descuento = 0;
                                }
                                if (anhoV <=2019 && anhoV>=2014) 
                                {
                                    Console.WriteLine("Descuento del %2,5 aplicado!");
                                    descuento=costo[1]*0.025;
                                }
                                if (anhoV <= 2013 && anhoV >= 2008)
                                {
                                    Console.WriteLine("Descuento del %5 aplicado!");
                                    descuento = costo[1] * 0.05;
                                }
                                if (anhoV <= 2007 && anhoV >= 2002)
                                {
                                    Console.WriteLine("Descuento del %7,5 aplicado!");
                                    descuento = costo[1] * 0.075;
                                }
                                if (anhoV <= 2001 )
                                {
                                    Console.WriteLine("Descuento del %10 aplicado!");
                                    descuento = costo[1] * 0.1;
                                }

                                Console.WriteLine("  \n" +
                                    "  Costo de mantenimiento preventivo: " + costo[1] + "\n" +
                                    "  Descuento: " + descuento + "\n" +
                                    "  Subtotal: " +subtotal+"\n" +
                                    "  I.V.A: "+iva+" \n" +
                                    "  Total: " +total+"\n" +
                                    " ");
                                Console.WriteLine(" Presione Enter para continuar.");
                                Console.ReadLine();

                                break;
                            case "3":
                                Console.WriteLine(" -------  Reparacion de motores apartir de -------\n" +
                                    "   Motor 4 cilindros en linea : $200,000\n" +
                                    "   Motor 6 cilindros en linea : $450,000\n" +
                                    "   Motor V6: $650,000\n" +
                                    "   Motor V8: $820,000\n" +
                                    "   \n" +
                                    "No se tiene disponibilidad para reparar motores de 5 cilindros,VR6, V10 o V12. \n" +
                                    " ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break; 
                            case "4":
                                Console.WriteLine(" El precio del diagnostico de sistemas es de $75,000 para todos los vehiculos.");
                                Console.WriteLine(" ");
                                Console.WriteLine(" Presione Enter para continuar");
                                Console.ReadLine();
                                break;
                        }
                                  
                        break;
                    case "4":
                        Console.WriteLine(" Saliendo de la gestion de servicios la menu principal....");
                         sistema = 0;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("   Por favor escoga una opcion valida.");
                        Console.WriteLine(" ");
                        break;
                }
            }
            

        }
    }
}
