using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Input wind speed");
  
   var WindSpeedMPH = Console.ReadLine();   
    var WindSpeedSplit = WindSpeedMPH.Split(' ');
      var WindSpeedNumber = WindSpeedSplit[0];
//changes the user input from a string to just the number
    double WindSpeed;
if(double.TryParse(WindSpeedNumber, out WindSpeed)){
  if( WindSpeed >= 157 ){
    Console.WriteLine( "Category Five Hurricane");
  }
    else if( WindSpeed >= 130 && WindSpeed < 157 ){
     Console.WriteLine("Category Four Hurricane"); 
    }
    else if( WindSpeed >= 111 && WindSpeed < 130 ){
     Console.WriteLine("Category Three Hurricane"); 
      }
    else if( WindSpeed >= 96 && WindSpeed < 111 ){
     Console.WriteLine("Category Two Hurricane"); 
      }
    else if( WindSpeed >= 74 && WindSpeed < 96 ){
     Console.WriteLine("Category One Hurricane"); 
      }
    else{
     Console.WriteLine("Not a Hurricane"); 
      }}
    else {
      Console.WriteLine("Invalid Input");
    }
  }
}