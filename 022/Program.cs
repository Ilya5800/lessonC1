
System.Console.Write("Введите пятизначное число:  ");
string? number=Console.ReadLine();
 
  void CheckingNumber (string number)
 {
    if (number[0]==number[4]|| number[1]==number[3]){
     System.Console.WriteLine($"{number} Палидром");
     }
     else System.Console.WriteLine($"{number} не палидром");
 }
  if (number!.Length == 5){
    CheckingNumber(number);
  }
  else System.Console.WriteLine("Введите правильное число");
