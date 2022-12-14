Console.Clear();
int [] Array (int size){
    int [] b = new int [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().Next(-9,10);
    }
    return b;
}
int [] arrays = Array(9);
System.Console.WriteLine($"[{String.Join(", /", arrays)}");

int r = int.Parse(Console.ReadLine());
void rezalt (int [] ar){
    int re =0;
    for(int i=0; i<ar.Length; i++){
    if(r==ar[i]); re = 1; 
    }
    if (re==1) Console.WriteLine("Есть в массиве: ");
    else Console.WriteLine("Нет числа: ");
}   
rezalt(arrays);