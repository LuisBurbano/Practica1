using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gerente:Empleado
{
    public string deparment { get; set; }

    public void showInformation()
    {
        Console.WriteLine("Nombre: {0} Edad: {1} Salario mensual: {2} Salario anual: {3} Departamento:{4} ", name, age, salaryMonth, salaryYear, deparment);
    }


}
