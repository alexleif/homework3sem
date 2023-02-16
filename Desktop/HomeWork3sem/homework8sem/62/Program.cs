Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 8. Двумерные массивы.{rn}"+
        $"Задача 62:{rn}"+
        $"Напишите программу, которая заполнит спирально массив 4 на 4.{rn}"+
        $"Например, на выходе получается вот такой массив:{rn}"+
        $"{rn}"+
        $"01 02 03 04{rn}"+
        $"12 13 14 05{rn}"+
        $"11 16 15 06{rn}"+
        $"10 09 08 07{rn}";
        
    // длина каждой метрики массива
    int arrLen;

    // ограничение длины массива
    int arrLenMin = 4;
    int arrLenMax = 10;

    int[,] ArrayRandomInt;


    ViewTitleTask(title);

    while(true){
        Console.Clear();
        
        // длина ребра массива
        arrLen = new Random().Next(arrLenMin, arrLenMax + 1);

        ArrayRandomInt = new int[arrLen, arrLen];

        MatrixSpiral(ArrayRandomInt);

        Console.WriteLine($"Создана матрица размером {arrLen} x {arrLen}:");
        ShowArrayTwoDimensionalInt(ArrayRandomInt);
        Console.WriteLine(); 
       
                
        Console.WriteLine($"Press any key to continue...");
        Console.ReadKey();
    };

};


// alternative method name: Anaconda
void MatrixSpiral(int[,] array){
    int len = array.GetLength(0);
    int num = 1;
    int sum = len * len;
    int Ring;
    int row = 0;
    int col = 0;
    int index;
    int max;

    len -= 1;

    // rings
    for(Ring = 0; num <= sum; Ring += 2){
        // длина ребра массива с учетом смещения в центр матрицы
        max = len - Ring;
        
        // для нечетных матриц, иначе конечное число не подпадает под условия
        if(max == 0 && (len+1) % 2 != 0){
            max = 1;
        };

        // move to right
        for(index = 0; index < max && num <= sum; index++){
            array[row, col++] = num++;
        };

        // move to down
        for(index = 0; index < max && num <= sum; index++){
            array[row++, col] = num++;
        };

        // move to left
        max = Ring;
        for(index = len; index > max && num <= sum; index--){
            array[row, col--] = num++;
        };
        // компенсируем col-- в конце цикла
        col++;

        // move to top
        for(index = len; index > max && num <= sum; index--){
            array[row--, col] = num++;
        };
        // компенсируем row-- в конце цикла
        row++;
    };
};


void ShowArrayTwoDimensionalInt(int[,] array){
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);
    string newLine = new string('-', lenCol * 8 + 1);

    Console.WriteLine($"{newLine}");
    for (int i = 0; i < lenRow; i++){
        for (int j = 0; j < lenCol; j++){
            Console.Write($"| ");
            Console.Write("{0:d2} ", array[i, j]);
            Console.Write($"\t");
        };
        Console.WriteLine("|");
    };
    Console.WriteLine($"{newLine}");
};


// ViewTitleTask version 2.1
void ViewTitleTask(string? text = ""){
    string rn = "\n";
    Console.Clear();
    Console.WriteLine(
        $"{text}{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}{rn}"+
        $"Press any key to continue..."
    );
    Console.ReadKey();
    Console.Clear();
};