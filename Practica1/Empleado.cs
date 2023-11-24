using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class Empleado: IMostrarInformacion
{
    public string name { get; set; }
    public int age { get; set; }
    public double salaryMonth { get; set; }
    public double salaryYear { get; set; }

    public void calculateSalaryYearly()
    {   
        
        salaryYear = this.salaryMonth * 12;
        
    }

    public void ShowInformation()
    {
        Console.WriteLine("Nombre: {0} Edad: {1} Salario mensual: {2} Salario anual: {3}",name, age, salaryMonth, salaryYear );
    }


}