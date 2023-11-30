int num = 131313; int a = num; int b = 1;
Console.Write("[");
while(num > 0){
    if(num < 10){
        Console.Write($"{num}");
        while(b <= a){
            b = b * 10;     
        } 
        b = b / 10; 
        if (b == 1){                            // К сожалению, не придумал, что делать, если в числе есть 0 (не хватило сил)
            Console.Write("]");
            break;
        }
        else {
            num = a - num * b;
            a = num;
            b = 1;
            Console.Write(", ");
        }
    }
    else{
        num = num / 10;
    }
}    


