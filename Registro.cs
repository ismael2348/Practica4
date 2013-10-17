using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApplication4
{
    class Registro
    {
        public string @check;
       



        public void imprimirp(ArrayList datos) {

            foreach (string[] array in datos)
            {

                if (array.Length > 0)
                    Console.WriteLine("ID : "+ array[0]);
                if (array.Length > 1)
                    Console.WriteLine("Nombre : " + array[1]);
                if (array.Length > 2)
                    Console.WriteLine("Domicilio : " + array[2]);
                if (array.Length > 3)
                    Console.WriteLine("Telefono : " + array[3]);


            
            
            }
            
                    
        
        }
        public void leer(){

            Console.WriteLine("Teclea la ruta de tu archivo:   ");
            check  = Console.ReadLine();
            }

        public void checar() {


            if (File.Exists(this.check)) {

                if (Path.GetExtension(this.check) == ".csv") {

                    parseCSV(); 
                
                }
            }    
            }
        
       
             public void parseCSV()
        {       
                ArrayList parsedData = new ArrayList();

                using (StreamReader readFile = new StreamReader(this.check))
            {
                string line;
                string[] row;
                try
                {



                    while ((line = readFile.ReadLine()) != null)
                    {

                        Registro registro = new Registro();
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }
                catch (FileNotFoundException m) {
                    Console.WriteLine(m.Message);
                
                }
            }
                imprimirp(parsedData);


        }
    
    }

 
    
    
    
        
}
