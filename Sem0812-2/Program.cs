Console.Clear();
int [] Array (int size){
    int [] b = new int [size];
    for(int i=0; i<b.Length; i++){
        b[i] = new Random().Next(-100,100);
    }
    return b;
}

int [] arrays = Array(9);
System.Console.WriteLine($"[{String.Join(", /", arrays)}");

    for(int i=0; i<arrays.Length; i++){

        if (arrays[i]>0) arrays[i] *= -1;
        else arrays[i] *= Math.Abs(arrays[i]);
        Console.WriteLine(arrays[i]);
    }
    