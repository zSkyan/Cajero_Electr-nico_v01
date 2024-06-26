// código 3 de marzo 2023
using System;
using System.Threading; // funciones o método de retardo de tiempo y similares
namespace parcial1
{
	class cajero_electronico
	{
		public static void Main(string[] args) // método principal
		{
			// VARIABLES

			// DECLARACIONES

			// var independientes
			double valor_retiro, valor_transferencia, valor_consignacion;
			int opcion, clave;
			
			// var dependientes
			double saldo;
			int clave_interna;
			
			// var auxiliares
			string titulo, autor;
			
			// expresiones condicionales
			bool condicion01, condicion02, condicion03, condicion04;
			
			// mensajes
			string mensaje, mensaje_clave, mensaje_saldo, mensaje_retiro, mensaje_bienvenida;
			string mensaje_transf, mensaje_consig, mensaje_clv_invalida;
			string mensaje01, mensaje02, mensaje03, mensaje04, mensaje05;
			
			// DECLARACIÓN-DEFINICIÓN
			const int SEGUNDOS = 1000;
			
			// DEFINICIONES
			// explicitas constante
			clave_interna = 9874;
			saldo = 100000;
			mensaje_clave = "Ingrese clave de 4 digitos";
			mensaje_clv_invalida = "Clave inválida";
			mensaje_bienvenida = "Bienvenido/a a Bancolombia, por favor escoja una opción";
			mensaje_saldo = "1: Consulta de saldo";
			mensaje_retiro = "2: Retiro de dinero";
			mensaje_transf = "3: Transferencia de dinero";
			mensaje_consig = "4: Consignación de dinero";

			titulo = "App que simula un cajero electrónico";
			autor = "Por: Skyan";

			// Presentación
			
			Console.WriteLine(titulo + Environment.NewLine + autor + Environment.NewLine);
			Thread.Sleep(2*SEGUNDOS);
			
			// Implícitas (lectura)
			
			Console.WriteLine(mensaje_bienvenida);
			Thread.Sleep(1*SEGUNDOS);
			Console.WriteLine(mensaje_saldo);
			Console.WriteLine(mensaje_retiro);
			Console.WriteLine(mensaje_transf);
			Console.WriteLine(mensaje_consig);
			opcion = Convert.ToInt32(Console.ReadLine());
			Thread.Sleep(2*SEGUNDOS);

			// Procedimiento
			
			switch (opcion) {
				case 1:
					mensaje01 = ("Operación de consulta de saldo");
					Console.WriteLine(mensaje01);
					
					Console.WriteLine(mensaje_clave);
					clave = Convert.ToInt32(Console.ReadLine());
					
					condicion01 = (clave == clave_interna);
					if (condicion01) {
						mensaje = "Su saldo es $" + Convert.ToString(saldo) + " pesos";
						Console.WriteLine(mensaje);
					}else {
						mensaje = "Intento número uno";
						Console.WriteLine(mensaje_clv_invalida);
					}
					break;
				case 2:
					mensaje02 = ("Operación de retiro");
					Console.WriteLine(mensaje02);
					
					Console.WriteLine(mensaje_clave);
					clave = Convert.ToInt32(Console.ReadLine());
					
					condicion01 = (clave == clave_interna);
					if (condicion01) {
						
						mensaje = "¿Cuánto dinero desea retirar?";
						Console.WriteLine(mensaje);
						valor_retiro = Convert.ToInt32(Console.ReadLine());
						
						condicion02 = (valor_retiro>saldo);
						if (condicion02) {
							mensaje = "No hay fondos suficientes";
							Console.WriteLine(mensaje);
						}else {
							saldo = saldo-valor_retiro;
							mensaje = "Su saldo es $" + Convert.ToString(saldo);
							Console.WriteLine(mensaje); }
					}else {
						mensaje = "Intento número uno";
						Console.WriteLine(mensaje_clv_invalida);
					}
					break;
				case 3:
					mensaje03 = ("Operación transferencia");
					Console.WriteLine(mensaje03);
					
					Console.WriteLine(mensaje_clave);
					clave = Convert.ToInt32(Console.ReadLine());
					
					condicion01 = (clave == clave_interna);
					if (condicion01) {
						
						mensaje = "¿Cuánto dinero desea transferir?";
						Console.WriteLine(mensaje);
						valor_transferencia = Convert.ToInt32(Console.ReadLine());
						
						condicion03 = (valor_transferencia>saldo);
						if (condicion03) {
							mensaje = "No hay fondos suficientes";
							Console.WriteLine(mensaje);
						}else {
							saldo = saldo-valor_transferencia;
							mensaje = "Su saldo es $" + Convert.ToString(saldo);
							Console.WriteLine(mensaje); }
					}else {
						mensaje = "Intento número uno";
						Console.WriteLine(mensaje_clv_invalida);
					}
				case 4:
					mensaje04 = ("Operación de consignación");
					Console.WriteLine(mensaje04);
					
					Console.WriteLine(mensaje_clave);
					clave = Convert.ToInt32(Console.ReadLine());
					
					condicion01 = (clave == clave_interna);
					if (condicion01) {
						
						mensaje = "¿Cuánto dinero desea consignar?";
						Console.WriteLine(mensaje);
						valor_consignacion = Convert.ToInt32(Console.ReadLine());
						saldo = saldo+valor_consignacion;
						mensaje = "Su saldo es $" + Convert.ToString(saldo);
						Console.WriteLine(mensaje); }
					else {
						mensaje = "Intento número uno";
						Console.WriteLine(mensaje_clv_invalida);
					}
					break;
				default:
					mensaje05 = ("Opción inválida");
					Console.WriteLine(mensaje05);
					break;
			};

			// Sentencias para retener la consola
			Console.WriteLine(Environment.NewLine);
			Console.Write("Presione cualquier tecla para terminar . . . ");
			Console.ReadKey(true);
		}
	}
}
