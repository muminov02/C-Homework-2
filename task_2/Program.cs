int num1 = 0;
int num2 = 0;
void SecondNumber(int num){
    Console.WriteLine(num);
    num1 = num / 100;
    num2 = num % 10;
    
    Console.WriteLine($"{num1}{num2}"); 
}
SecondNumber(new Random().Next(100, 1000));