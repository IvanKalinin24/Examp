Console.Clear();
int [] Array (int size){
    int [] b = new int [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().Next(-20,40);
    }
    return b;
}

int [] arrays = Array(10);
System.Console.WriteLine($"[{String.Join(", /", arrays)}");
int count = 0;

    for(int i=0; i<arrays.Length; i++){
    if(arrays[i]>9 & arrays[i]<99) count++; 
}
Console.WriteLine(count);