using System;

class Program{
    static bool isPrime(int val){
        if(val <= 1){
            return false;
        }
        for(int i = 2; i * i <= val; i++){
            if(val % i == 0){
                return false;
            }
        }
        return true;
    }

    public static void Main(){
        int num;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if(isPrime(num)){
            Console.Write("Prime");
        }
        else {
            Console.Write("Not Prime");
        }
    }
}