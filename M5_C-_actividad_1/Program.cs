while (true)
{
    Console.WriteLine(@"
--- Centro de Entrenamiento Técnico ---

1: Suma y validación numérica
2: Cálculo y condicionales
3: Manipulación de Cadenas
4: Operaciones Lógicas (Calculadora)
5: Análisis Numérico (Listas de enteros)
6: Gestión de Tareas (Listas de cadenas)
7: Arreglos y Búsqueda
8: Programación Orientada a Objetos (Clases)
9: CRUD de Objetos (Listas de objetos)
Salir");
    
    if (int.TryParse(Console.ReadLine(), out int option)) ;

    switch (option) 
    {
        case 1:
            Console.WriteLine("Ingresa 2 numeros");
            if(!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Algo salio mal");
            };
            if(!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Algo salio mal");
            };
            
            int result = sum(a, b);
            Console.WriteLine(result);
            break;
        case 2:
            Console.WriteLine("Ingresa tus 3 notas");
            if(double.TryParse(Console.ReadLine(), out double note1));
            if(double.TryParse(Console.ReadLine(), out double note2));
            if(double.TryParse(Console.ReadLine(), out double note3));
            
            double final_note = avg_note(note1, note2, note3);
            Console.WriteLine(final_note);
            break;
        case 3:
            Console.WriteLine("Ingresa tu nombre y apellido");
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            
            string fullname_result = fullname(name, lastname);
            Console.WriteLine(fullname_result);
            break;
        case 4:
            Console.WriteLine("Ingresa 2 numeros y la operacion a realizar");
            if(!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Something went wrong");  
            };
            if(!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Something went wrong");  
            };
            string op = Console.ReadLine();
            
            int calculator_result = calculator(num1,num2,op);
            Console.WriteLine(calculator_result);
            break;
        case 5:
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingresa 5 numeros");
            while (numeros.Count() < 5)
            {
                Console.WriteLine("Ingresa un nuevo numero");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(numeros.Count());

            }
            int total_arr = sum_arr(numeros);
            Console.WriteLine(total_arr);

            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            
            break;
        case 6:
            Console.WriteLine("op");
            break;
    }

}

int sum(int a,int b)
{
    return a + b;
}

double avg_note(double note1,double note2,double note3)
{
    return (note1 + note2 + note3) / 3;
}

string fullname( string name, string lastname)
{
    return $@"Su completo es {name} {lastname}";
}

int calculator(int number1, int number2, string op)
{
    switch (op)
    {
        case "+":
            return number1 + number2;
        case "-":
            return number1 - number2;
        case "%":
            return number1 / number2;
        case "*":
            return number1 * number2;
    }

    return 0;
}

int sum_arr(List<int> arr)
{
    int total = 0;
    foreach (var number in arr)
    {
        total += number;
    }
    return total;
}