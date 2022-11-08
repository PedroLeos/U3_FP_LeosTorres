using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace U3_FP_Tarea_PedroLeos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Actividad para dar acceso a un usuario
            string nombreUsuario;
            byte edadUsuario;
            string apellidoUsuario, direccionUsuario, celularUsuario, perfilUsuario, usuarioAcceso, contraseñaUsuario, confirmContraseña, codigoAcceso;

            //Personalizar la consola
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(70, 30);
            Console.Clear();

            //Pedir nombre del usuario
            Console.WriteLine("Ingresa tu nombre:");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad:");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            //Aplicacion de la selectiva "if"
            if (edadUsuario > 18)
            {
                //Generar codigo de acceso
                Console.WriteLine("Ingresa tu apellido:");
                apellidoUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu direccion:");
                direccionUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu número celular:");
                celularUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa el nombre de tu perfil:");
                perfilUsuario = Console.ReadLine();
                Console.WriteLine("Ingresa tu nombre de usuario:");
                usuarioAcceso = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña:");
                contraseñaUsuario = Console.ReadLine();
                Console.WriteLine("Confirma tu contraseña:");
                confirmContraseña = Console.ReadLine();

                //Segunda aplicacion del if
                if (contraseñaUsuario == confirmContraseña)
                {

                    //Generar codigo con numeros aleatorios
                    Random aleatorio = new Random();
                    aleatorio.Next(1000, 9999);
                    //Random NO es una variable, es un objeto

                    codigoAcceso = aleatorio.ToString();

                    //Imprimir los datos del usuario
                    Console.WriteLine("\n Informacion del usuario:");
                    Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}, Direccion: {3}, Numero Celular: {4}", nombreUsuario, apellidoUsuario, edadUsuario, direccionUsuario, celularUsuario);
                    Console.WriteLine("Nombre de perfil: {0}, Usuario: {1}", perfilUsuario, usuarioAcceso);

                    //Imprimir codigo de acceso en otro color
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Codigo de acceso: {0}", codigoAcceso);
                }
                else
                {

                    Console.WriteLine("Tu contraseña no fue validada.");
                    Thread.Sleep(3000);
                    return;
                }

                    Console.ReadKey();

                }
            }
        }
    }
}
