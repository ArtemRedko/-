int[] mass = {8, 43, 42, 58, 1, 33, 47, 73, 46, 4};
int result = 0;
foreach(int a in mass){
    if(a % 2 == 0){
        result++;
    }
}
Console.Write(result);