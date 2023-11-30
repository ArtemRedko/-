double[] mass = {1.1, 4.25, 86.41, 14.2};
double max = mass[0]; double min = mass[0];
for(int i = 0; i < mass.Length; i++){
    if(mass[i] > max){
        max = mass[i];
    }
    if(mass[i] < min){
        min = mass[i];
    }
}
Console.Write(max - min);
