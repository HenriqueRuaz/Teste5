using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste5;

//no ai needed
//no copypaste

namespace Teste5{
	internal class Program{
		static void Main(string[] args){
			
			char exit = 'x';
			int Rchoose = 0;
			int Lchoose = 0;
			bool loop1 = false;
			bool loop2 = false;
			bool login1 = false;
			bool login2 = false;
			bool login3 = false;
			bool login4 = false;
			bool login5 = false;
			bool login6 = false;

            DataBase  Register0 = new DataBase();
			DataBase  Register1 = new DataBase();
			DataBase  Register2 = new DataBase();
			DataBase  Register3 = new DataBase();
			DataBase  Register4 = new DataBase();
			DataBase  Register5 = new DataBase();						//Object Register
			DataBase  Login0 = new DataBase();
			DataBase  Login1 = new DataBase();
			DataBase  Login2 = new DataBase();
			DataBase  Login3 = new DataBase();
			DataBase  Login4 = new DataBase();
			DataBase  Login5 = new DataBase();							//Object Login

			//============================================================================================================================//Part_1

			while(exit != 'z') { 
				while(exit == 'x') { 
			do{
				try { 
					Console.WriteLine("[1, 2, 3, 4, 5, 6]");
					Console.WriteLine("");
					Console.Write("Choose your Register: ");
					Rchoose = Convert.ToInt32(Console.ReadLine());		//Nº Register	//Console.WriteLine();	
					loop1 = true;

				}catch(Exception e){
					Console.WriteLine(e.Message);	
				}
				
			}while(loop1 == false || Rchoose > 6 || Rchoose < 1);		
			
			//============================================================================================================================//Part_2

			if(Rchoose == 1) { 
				Console.WriteLine("");
				Console.Write("Introduce a new username: ");				//User 
				Register0.Username = Console.ReadLine();
			
				Console.Write("Introduce a new password: ");				//Pass
				Register0.Password = Console.ReadLine();
				login1 = true;

			}else if(Rchoose == 2){ 
				Console.WriteLine("");
				Console.Write("Introduce a new username: ");				
				Register1.Username = Console.ReadLine();
			
				Console.Write("Introduce a new password: ");				
				Register1.Password = Console.ReadLine();
				login2 = true;

			}else if(Rchoose == 3){ 
				Console.WriteLine("");
				Console.Write("Introduce a new username: ");				
				Register2.Username = Console.ReadLine();
			
				Console.Write("Introduce a new password: ");				
				Register2.Password = Console.ReadLine();
				login3= true;

			}else if(Rchoose == 4){ 
				Console.WriteLine("");
				Console.Write("Introduce a new username: ");				
				Register3.Username = Console.ReadLine();
			
				Console.Write("Introduce a new password: ");				
				Register3.Password = Console.ReadLine();
				login4 = true;

			}else if(Rchoose == 5){ 
				Console.WriteLine("");
				Console.Write("Introduce a new username: ");				
				Register4.Username = Console.ReadLine();
			
				Console.Write("Introduce a new password: ");				
				Register4.Password = Console.ReadLine();
				login5 = true;

			}else if(Rchoose == 6){ 
				Console.WriteLine("");
				Console.Write("Introduce a new username: ");				
				Register5.Username = Console.ReadLine();
			
				Console.Write("Introduce a new password: ");				
				Register5.Password = Console.ReadLine();
				login6 = true;
			}

			exit = 'y';
				}
		//============================================================================================================================//Part_3
			
			while(exit == 'y') {

			do{
				try{ 
					Console.WriteLine("[1, 2, 3, 4, 5, 6]");
			
					Console.WriteLine("Choose your Login: ");			
					Lchoose = Convert.ToInt32(Console.ReadLine());				//Nº Login
					loop2 = true;
				
				}catch(Exception e){
					Console.WriteLine(e.Message);
				}
			}while(loop2 == false || Lchoose > 6 || Lchoose < 1);



		//============================================================================================================================//Part_4

			if(Lchoose == 1 && login1 == true){
				do{ 
					Console.Write("Enter a username: ");						//Login -> User 
					Login0.Username = Console.ReadLine();
			
					Console.Write("Enter a password: ");						//Login ->Pass
					Login0.Password = Console.ReadLine();

					if(Login0.Username != Register0.Username || Login0.Password != Register0.Password){
						Console.WriteLine("");
						Console.WriteLine("-> Username or Password incorrect!");
						Console.WriteLine("");
					}

				}while(Login0.Username != Register0.Username || Login0.Password != Register0.Password);
				
					Console.WriteLine("");
					Console.WriteLine("Login_1 successed.");
					Console.WriteLine(">>> " + Login0.Username);
					Console.WriteLine(">>> " + Login0.Password);
				
			}

		//Login 2 =================================================================================================================

			else if(Lchoose == 2 && login2 == true){
				do{ 
					Console.Write("Enter a username: ");						
					Login1.Username = Console.ReadLine();
			
					Console.Write("Enter a password: ");						
					Login1.Password = Console.ReadLine();

					if(Login1.Username != Register1.Username || Login1.Password != Register1.Password){
						Console.WriteLine("");
						Console.WriteLine("-> Username or Password incorrect!");
						Console.WriteLine("");
					}

				}while(Login1.Username != Register1.Username || Login1.Password != Register1.Password);
				
					Console.WriteLine("");
					Console.WriteLine("Login_2 successed.");
					Console.WriteLine(">>> " + Login1.Username);
					Console.WriteLine(">>> " + Login1.Password);
					
			}

		//login 3===============================================================================================================

			 else if(Lchoose == 3 && login3 == true){
				do{ 
					Console.Write("Enter a username: ");
					Login2.Username = Console.ReadLine();
			
					Console.Write("Enter a password: ");						
					Login2.Password = Console.ReadLine();

					if(Login2.Username != Register2.Username || Login2.Password != Register2.Password){
						Console.WriteLine("");
						Console.WriteLine("-> Username or Password incorrect!");
						Console.WriteLine("");
					}

				}while(Login2.Username != Register2.Username || Login2.Password != Register2.Password);
				
					Console.WriteLine("");
					Console.WriteLine("Login_3 successed.");
					Console.WriteLine(">>> " + Login2.Username);
					Console.WriteLine(">>> " + Login2.Password);

			 }

		//login 4 =================================================================================================================

			 else if(Lchoose == 4 && login4 == true){
				do{ 
					Console.Write("Enter a username: ");
					Login3.Username = Console.ReadLine();
			
					Console.Write("Enter a password: ");						
					Login3.Password = Console.ReadLine();

					if(Login3.Username != Register3.Username || Login3.Password != Register3.Password){
						Console.WriteLine("");
						Console.WriteLine("-> Username or Password incorrect!");
						Console.WriteLine("");
					}

				}while(Login3.Username != Register3.Username || Login3.Password != Register3.Password);
				
					Console.WriteLine("");
					Console.WriteLine("Login_4 successed.");
					Console.WriteLine(">>> " + Login3.Username);
					Console.WriteLine(">>> " + Login3.Password);

			 }

		//login 5 ===============================================================================================================

			else if(Lchoose == 5 && login5 == true){
				do{ 
					Console.Write("Enter a username: ");
					Login4.Username = Console.ReadLine();
			
					Console.Write("Enter a password: ");						
					Login4.Password = Console.ReadLine();

					if(Login4.Username != Register4.Username || Login4.Password != Register4.Password){
						Console.WriteLine("");
						Console.WriteLine("-> Username or Password incorrect!");
						Console.WriteLine("");
					}

				}while(Login4.Username != Register4.Username || Login4.Password != Register4.Password);
				
					Console.WriteLine("");
					Console.WriteLine("Login_5 successed.");
					Console.WriteLine(">>> " + Login4.Username);
					Console.WriteLine(">>> " + Login4.Password);

			}

		//login 6 =================================================================================================================

			 else if(Lchoose == 6 && login6 == true){
				do{ 
					Console.Write("Enter a username: ");
					Login5.Username = Console.ReadLine();
			
					Console.Write("Enter a password: ");						
					Login5.Password = Console.ReadLine();

					if(Login5.Username != Register5.Username || Login5.Password != Register5.Password){
						Console.WriteLine("");
						Console.WriteLine("-> Username or Password incorrect!");
						Console.WriteLine("");
					}

				}while(Login5.Username != Register5.Username || Login5.Password != Register5.Password);
				
					Console.WriteLine("");
				    Console.WriteLine("Login_6 successed.");
					Console.WriteLine(">>> " + Login5.Username);
					Console.WriteLine(">>> " + Login5.Password);

			 }else{
					Console.WriteLine("You are not logged in!");
				
			 }
				Console.WriteLine(" ");
				Console.WriteLine("Press x to Register Menu, y to Login Menu, z to exit!");
				exit = Convert.ToChar(Console.ReadLine());
				}
			//============================================================================================================================//Part_5
			}
		}
	}
}

