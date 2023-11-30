int[] mass = {20, 45, 25, 24, 87, 34, 24, 65, 22, 64};
int result = 0;
for(int i = 0; i < mass.Length; i++){
    if (mass[i] <= 90 &&  mass[i] >= 20){
        result++;
    }
}
Console.Write(result);