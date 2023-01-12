void WaitSeconds(double sec){
    System.Threading.Thread.Sleep((int)(sec * 1000));
};

void TitleTask(string? text = ""){
    Console.Clear();
    Console.WriteLine($"{text}");
    Console.WriteLine();
};

void ProgressBar(){    
    Console.Clear();
    Console.WriteLine("Loading...");
    for(int i = 0; i < 100; i++){
        Console.Write($"#");
        WaitSeconds(0.015);
    };
    WaitSeconds(1);
};

void ExitFromProg(bool exit = true, string? text = ""){
    if(!exit){
        Console.WriteLine($"Для выхода введите Q и нажмите ENTER");
    };
    if(text == "Q"){
        Console.Clear();
        Console.WriteLine("End.");
        System.Environment.Exit(0);
    };
    Console.WriteLine();
};

int ReadIntegerFromString(string write){
    while(true){
        Console.Write($"{write} ");
        string? text = Console.ReadLine();

        if(text != ""){
            ExitFromProg(true, text);
            return Convert.ToInt32(text);
        }else{
            Console.WriteLine($"Attention: the data is incorrect!!!");
            WaitSeconds(1);
        };
    };    
};

void Run(){
    string rn = "\n";
    string title = $"Задача 23: {rn}"+
                   $"Напишите программу, которая принимает на вход число (N){rn}"+
                   $"и выдаёт таблицу кубов чисел от 1 до N.{rn}";
    int num;
    int i;

    ProgressBar();

    while(true){
        TitleTask(title);
        WaitSeconds(1);
        ExitFromProg(false);
        num = ReadIntegerFromString("Введите целое число (N):");
        for(i = 1; i <= num; i++){
            Console.Write($"{Math.Pow(i, 3)}");
            if(i < num){
                Console.Write(", ");
            };
        };
        WaitSeconds(3);
    };

};

Run();