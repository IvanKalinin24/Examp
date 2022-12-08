// Задаем массив
int [] Array (int size){
    int [] b = new int [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().Next(-9,10);
    }
    return b;
}
int [] arrays = Array(9);
System.Console.WriteLine($"[{String.Join(", /", arrays)}");
int [] sum_m = Sumr(arrays);
System.Console.WriteLine($"pol {sum_m[0]}; otr {sum_m[1]};");

int [] Sumr(int [] a){
    int [] r= new int [2];
    int sum = 0;
    int raz = 0;
    for(int i=0; i<a.Length; i++){
        if (a[i]<0){sum=sum+a[i];}
        if (a[i]>0){raz= raz+ a[i];}
    }
    r[0]=sum;
    r[1]=raz;
    return r;
}