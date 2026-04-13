while (true)
{
    Console.WriteLine(@"
--- Centro de Entrenamiento Técnico ---

1: Suma y validación numérica
2: Cálculo y condicionales
3: Manipulación de Cadenas
4: Operaciones Lógicas (Calculadora)
5: Análisis Numérico (Listas de enteros)
6: Gestión de Tareas (List<string>)
7: Arreglos y Búsqueda
8: Colecciones de Objetos (List<Estudiante>)
9: Salir");
    
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
            List<string> tareas = new List<string>();
            bool continuarTareas = true;
            while (continuarTareas)
            {
                Console.WriteLine(@"
--- Gestión de Tareas ---
1: Agregar tarea
2: Ver tareas
3: Eliminar tarea por índice
4: Volver");
                if (int.TryParse(Console.ReadLine(), out int opTareas))
                {
                    switch (opTareas)
                    {
                        case 1:
                            Console.WriteLine("Ingresa la tarea:");
                            tareas.Add(Console.ReadLine());
                            Console.WriteLine("Tarea agregada.");
                            break;
                        case 2:
                            if (tareas.Count == 0)
                            {
                                Console.WriteLine("No hay tareas pendientes.");
                            }
                            else
                            {
                                for (int i = 0; i < tareas.Count; i++)
                                    Console.WriteLine($"[{i}] {tareas[i]}");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingresa el índice a eliminar:");
                            if (int.TryParse(Console.ReadLine(), out int idxTarea) && idxTarea >= 0 && idxTarea < tareas.Count)
                            {
                                tareas.RemoveAt(idxTarea);
                                Console.WriteLine("Tarea eliminada.");
                            }
                            else Console.WriteLine("Índice inválido.");
                            break;
                        case 4:
                            continuarTareas = false;
                            break;
                    }
                }
            }
            break;

        case 7:
            string[] ciudades = { "Bogotá", "Medellín", "Cali", "Barranquilla", "Cartagena" };
            Console.WriteLine("Ingresa el nombre de una ciudad:");
            string ciudadBuscar = Console.ReadLine();
            bool encontrada = false;
            foreach (string ciudad in ciudades)
            {
                if (ciudad.Equals(ciudadBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    encontrada = true;
                    break;
                }
            }
            Console.WriteLine(encontrada ? "Encontrada" : "No encontrada");
            break;

        case 8:
            List<Estudiante> estudiantes = new List<Estudiante>();
            bool continuarEst = true;
            while (continuarEst)
            {
                Console.WriteLine(@"
--- Mini CRUD de Estudiantes ---
1: Registrar estudiante
2: Mostrar estudiantes
3: Eliminar estudiante por índice
4: Volver");
                if (int.TryParse(Console.ReadLine(), out int opEst))
                {
                    switch (opEst)
                    {
                        case 1:
                            Console.WriteLine("Nombre:");
                            string nombreEst = Console.ReadLine();
                            Console.WriteLine("Edad:");
                            int.TryParse(Console.ReadLine(), out int edadEst);
                            Console.WriteLine("Nota:");
                            double.TryParse(Console.ReadLine(), out double notaEst);
                            estudiantes.Add(new Estudiante(nombreEst, edadEst, notaEst));
                            Console.WriteLine("Estudiante registrado.");
                            break;
                        case 2:
                            if (estudiantes.Count == 0)
                            {
                                Console.WriteLine("No hay estudiantes registrados.");
                            }
                            else
                            {
                                for (int i = 0; i < estudiantes.Count; i++)
                                    Console.WriteLine($"[{i}] {estudiantes[i]}");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingresa el índice a eliminar:");
                            if (int.TryParse(Console.ReadLine(), out int idxEst) && idxEst >= 0 && idxEst < estudiantes.Count)
                            {
                                estudiantes.RemoveAt(idxEst);
                                Console.WriteLine("Estudiante eliminado.");
                            }
                            else Console.WriteLine("Índice inválido.");
                            break;
                        case 4:
                            continuarEst = false;
                            break;
                    }
                }
            }
            break;

        case 9:
            Console.WriteLine("¡Hasta luego!");
            return;
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

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }

    public Estudiante(string nombre, int edad, double nota)
    {
        Nombre = nombre;
        Edad = edad;
        Nota = nota;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}, Nota: {Nota}";
    }
}