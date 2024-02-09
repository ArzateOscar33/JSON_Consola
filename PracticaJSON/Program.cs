using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PracticaJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista para almacenar los taladros
            List<Taladro> listaTaladros = new List<Taladro>();

            // Crear taladros y agregarlos a la lista
            Taladro taladro1 = new Taladro { FuerzaTorque = 50.0, RPM = 3000, Voltage = 12.0, CEnergia = 100.0 };
            Taladro taladro2 = new Taladro { FuerzaTorque = 60.0, RPM = 4000, Voltage = 24.0, CEnergia = 150.0 };

            listaTaladros.Add(taladro1);
            listaTaladros.Add(taladro2);

            // Guardar todos los taladros en un archivo JSON
            GuardarDatosEnJSON(listaTaladros);

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }




        static void GuardarDatosEnJSON(List<Taladro> listaTaladros)
        {
            // Serializar la lista de taladros a JSON
            string jsonContent = JsonConvert.SerializeObject(listaTaladros, Formatting.Indented);

            // Especifica la ruta donde deseas guardar el archivo JSON
            string projectPath = @"C:\Users\Admin\source\repos\PracticaJSON";
            string fileName = "taladros.json";
            string filePath = Path.Combine(projectPath, fileName);

            // Guardar el JSON en un archivo
            File.WriteAllText(filePath, jsonContent);

            Console.WriteLine($"Datos de todos los taladros guardados en el archivo JSON en: {filePath}");
        }
        static void ImprimirDatosTaladro(Taladro taladro)
        {
            Console.WriteLine($"Fuerza/Torque: {taladro.FuerzaTorque}");
            Console.WriteLine($"RPM: {taladro.RPM}");
            Console.WriteLine($"Voltage: {taladro.Voltage}");
            Console.WriteLine($"C Energía: {taladro.CEnergia}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
