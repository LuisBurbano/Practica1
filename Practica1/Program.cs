

using System.Xml.Linq;
//creacion de objetos empleado y gerente
Empleado empleado = new Empleado();
Gerente gerente = new Gerente();

//guardamos los datos del empleado 
Console.WriteLine("Escriba el nombre del empleado");
empleado.name = Console.ReadLine();
Console.WriteLine("Escriba la edad del empleado");
empleado.age =Int32.Parse(Console.ReadLine());
Console.WriteLine("Escriba el salario mensual del empleado");
empleado.salaryMonth =Double.Parse(Console.ReadLine());

//calculamos el salario con la funcion calculateSalaryYearly() de empleado
Console.WriteLine("Calculando el salario anual...");
empleado.calculateSalaryYearly();
Console.WriteLine("Mostrando la informacion del empleado");
//usamos la funcion de la interfaz heredada para mostrar la informacion
empleado.ShowInformation();

//guardamos los datos de gerente
Console.WriteLine("Escriba el nombre del gerente");
gerente.name = Console.ReadLine();
Console.WriteLine("Escriba la edad del gerente");
gerente.age = Int32.Parse(Console.ReadLine());
Console.WriteLine("Escriba el salario mensual del gerente");
gerente.salaryMonth = Double.Parse(Console.ReadLine());
Console.WriteLine("Escriba el departamento del gerente");
gerente.deparment = Console.ReadLine();
//calculamos el salario anual
gerente.calculateSalaryYearly();
//mostramos la informacion
gerente.showInformation();


