using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PipesPawth
{
    class RequestData
    {
        /*avaliable methood to provide
        information within a text*/
        public void request(){
            int item_1 = 0;
            int item_2;
            int append = 0;
            int append1;
            Console.WriteLine("Set number of neighbourds by work:");
            int size = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            Console.WriteLine("Put distances between neighbourds:");
            do
            {
                Console.WriteLine($"Distance-neighbourds ::: {item_1}:");
                for (item_2=0; item_2!=size; item_2++)
                {
                    string data = Console.ReadLine();
                    matrix[item_1,item_2] = Int32.Parse(data);
                }
                item_1++;
            } while (item_1!=size);
            /*To will send information
            with a text by Distances.txt*/
            string pathway = @"C:\FinalProject\PipesPawth\Distances.txt";
            using (StreamWriter append_matrix = File.AppendText(pathway)){
                do
                {
                    for (append1=0; append1!=size; append1++){
                        append_matrix.WriteLine(matrix[append,append1].ToString());
                    }
                    append_matrix.WriteLine("\n");
                    append++;
                } while (append<size);
                append_matrix.Close();
            }
        }
    }
}