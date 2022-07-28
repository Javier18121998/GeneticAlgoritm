using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PipesPawth
{
    class Processes
    {
        RequestData req = new RequestData();
        public int[,] get_Population(){
            string get_Distances = @"C:\FinalProject\PipesPawth\Distances.txt";
            string pup = "\n";
            string pop = "";
            int item_1 = 0;
            int item_2;
            int[,] population = new int[req.size,req.size];
            using (StreamReader file = new StreamReader(get_Distances)){
                while ((pop=file.ReadLine())!=null)
                {
                    do
                    {
                        for (item_2=0; item_2!=req.size; item_2++)
                        {
                            population[item_1,item_2] = Int32.Parse(pop);
                        }
                    } while (item_1!=req.size);   
                }
                file.Close();
            }
            return population;
        }
        public int[,] selection(){
            string write_processes = @"C:\FinalProject\PipesPawth\Processes.txt";
            Random pop = new Random();
            int[,] population = get_Population();
            int[,] fathers = new int[2, req.size];
            int item_1 = 0;
            int item_2;
            int i, j = 0;
            do
            {
                for (int j = 0; j < req.size; j++)
                {
                    for (int l= 0; l<2; l++)
                    {
                        int pop_select = pop.Next(1,req.size);
                        do
                        {
                            for (item_1=0; item_1!=req.size; item_1++)
                            {
                                fathers[i,j]=population[item_1,item_2];
                            }
                            item_2++;
                        } while (item_2<(pop_select+1));    
                    }
                }
            } while (i<2);
            using( StreamWriter processes = File.AppendText(write_processes))
            {
                processes.WriteLine("Temporary selection allele are ::::" + "\n");
                processes.WriteLine("{");
                do
                {
                    processes.WriteLine("{");
                    for(item_2=0; item_2<req.size; item_2++)
                    {
                        processes.WriteLine(fathers[item_1,item_2].ToString());
                    }
                    processes.WriteLine("}");
                    processes.WriteLine("\n"+"\t");
                    item_1++;
                } while (item_2<req.size);
                processes.WriteLine("}");
                processes.WriteLine("Before ... The anterior segment will be used for mixing by clauture.....");
                processes.Close();
            }
            return fathers;           
        }
        public int cross_Alleles(){
            string write_processes = @"C:\FinalProject\PipesPawth\Processes.txt";
            int[,] select = selection();
            int item_0,item_2;
            int item_1, item_4 = 0;
            int item_3 = 1;
            int[] f1 = new int[req.size];
            int[] f2 = new int[req.size];
            int[] son1 = new int[req.size];
            int[] son2 = new int[req.size];
            int[] neww = new int[2,req.size];
            for(item_0=0; item_0<req.size; item_0++)
            {
                for(item_2=0; item_2<req.size; item_2++)
                {
                    f1[item_0] = select[item_1,item_2];
                }
            }
            for(item_0=0; item_0<req.size; item_0++)
            {
                for(item_2=0; item_2<req.size; item_2++)
                {
                    f2[item_0] = select[item_3,item_2];
                }
            }
            do
            {
                do
                {
                    for(item_0 = 0; item_0<int((req.size)/2); item_0++)
                    {
                        son1[item_0] = f1[item_1];
                    }    
                    item_1++;
                    for(item_0=int((req.size)/2); item_0!=req.size; item_0++)
                    {
                        son1[item_0] = f2[item_4];
                    }
                } while (item_4>(int((req.size)/2)));
            } while (item_1<(int((req.size)/2)));
            do
            {
                do
                {
                    for(item_0 = 0; item_0<int((req.size)/2); item_0++)
                    {
                        son2[item_0] = f2[item_1];
                    }    
                    item_1++;
                    for(item_0=int((req.size)/2); item_0!=req.size; item_0++)
                    {
                        son2[item_0] = f1[item_4];
                    }
                } while (item_4<(int((req.size)/2)));
            } while (item_1>(int((req.size)/2)));
            neww[1,] = son1;
            neww[2,] = son2;
            using (StreamWriter file = new StreamWriter(write_processes, true))
            {
                file.WriteLine("This is new alleles-clausure; being useful to next mixture (none-crossing)");
                do
                {
                    file.WriteLine($"This is the{item_1} :: cross-chromosome :: ");
                    for (item_0 = 0; item_0<req.size; item_0++)
                    {
                        file.WriteLine(neww[item_1,item_0].ToString());
                    }
                    item_1++;
                } while (item_1<2);
                file.WriteLine("cross clausure-chromosome...");
                file.Close();             
            }
            return neww;
        }
        public int[,] mutation(){
            string write_processes = @"C:\FinalProject\PipesPawth\Processes.txt";
            int[,] to_mutate = cross_Alleles();
            int[][] crap = new int[2][];
            int[] fst_mut = new int[req.size];
            int[] snd_mut = new int[req.size];
            int[] newfst_mut = new int[req.size];
            int[] newsnd_mut = new int[req.size];
            int item_0 = 0;
            int item_1, item_2;
            int item_3, item_4;
            int temp;
            do
            {
                for(item_1 = 0; item_1<req.size; item_1++)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        crap[i] = to_mutate[item_0, item_1];
                    }
                }
                item_0++;
            } while (item_0<2);
            fst_mut[] = crap[0];
            snd_mut[] = crap[1];
            for(item_1 = 0; item_1<req.size; item_1++)
            {
                if (fst_mut[item_1]%2 == 0)
                {
                    for (item_2 = 0; item_2 <req.size; item_2++)
                    {
                        newfst_mut[item_2] = fst_mut[item_1];
                        temp++;
                    }                   
                }
                else
                {
                    for (item_2 = temp+1; item_2 <req.size; item_2++)
                    {
                        newfst_mut[item_2] = fst_mut[item_1];
                    }
                }
            }
            for(item_3 = 0; item_3<req.size; item_3++)
            {
                if (fst_mut[item_3]%2 == 0)
                {
                    for (item_4 = 0; item_4 <req.size; item_4++)
                    {
                        newsnd_mut[item_4] = snd_mut[item_3];
                        temp++;
                    }                   
                }
                else
                {
                    for (item_4 = temp+1; item_4 <req.size; item_4++)
                    {
                        newsnd_mut[item_4] = snd_mut[item_3];
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(write_processes, true))
            {
                file.WriteLine("Before all : Then now have new mutation of alleles in chromosomes :::...");
                file.WriteLine("First mutation ...");
                foreach (int item in newfst_mut)
                {
                    file.WriteLine("{0}", item + "\n");
                }
                file.WriteLine("Second mutation...");
                foreach(int item2 in newsnd_mut)
                {
                    file.WriteLine("{0}", item2);
                }
                file.WriteLine("End mutations :::...");                
                file.Close();
            }
        }
    }
}