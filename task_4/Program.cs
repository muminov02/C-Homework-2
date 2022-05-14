void Check(int num){
    if(num == 6 | num == 7){
        Console.WriteLine("Это выходые!!!");
    }else{
        Console.WriteLine("Жаль...");
    }
}
Check(new Random().Next(1,8));