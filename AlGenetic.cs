using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipesPawth
{
    class AlGenetic
    {
        /*The genetic algorithm recreates the mixture 
        and mutation of a pair of parent chromosomes, 
        which will now form heirs of their genes
        and they themselves will mutate until they achieve 
        a goal by themselves under their own local criteria.*/
        Processes process = new Processes();
        RequestData reque = new RequestData();
        public void genetic_Algorithm(){    
            int item_0, i = 0;
            int item_1 = 0;
            bool catc_h;
            int[] to_validate1 = new int[reque.size];
            int[] to_validate2 = new int[reque.size];
            /*Fst get_Population*/
            int[,] neighbours = process.get_Population();
            /*Snd border a selection into population*/
            int[,] neigh_pipes = process.selection(){
                neighbours[item_0, item_1];
            };
            /*Trd set a crossing twoo azar population*/
            int[2,reque.size] crossing = process.cross_Alleles(){
                neigh_pipes[2,reque.size];
            };
            /*Frd fix a mutation between azar crossing*/
            int[,] mutate_azarcross = process.mutation(){
                if(crossing[i,] == 0)
                {
                    to_validate1 = crossing[i];
                }
                else
                {
                    to_validate2 = crossing[i];
                }
                /*Set a validator while condition in 
                to_validate1 and tovalidate2 are 
                seting diferent between criteria 
                of validator method:*/
                foreach (int item in to_validate1)
                {
                    item++;
                }
                foreach (int item2 in to_validate2)
                {
                    item2++;
                }
                if (item<item2)
                {
                    catc_h = validator();
                    /*Fitness-process*/
                    if (catc-h = true)
                    {
                        Console.WriteLine("This is the best wellness way to conect pipes from streets down-way"); 
                    }
                    else
                    {
                        process.get_Population();
                        process.selection();
                        process.cross_Alleles();
                        process.mutation();
                        validator();
                    }
                }
                else
                {
                    /*Returns to the census of the process and does it again*/
                    genetic_Algorithm(); 
                }
            };
        }
        /*The genetic algorithm has validations as 
        goals and criteria of evolution and mutation, 
        so this criterion is established and worked 
        until it is done.*/
        /*validation-order-method*/
        public bool validator(){
            bool trop = true;
            int[] trop1 = new int[reque.size];
            int[] trop2 = new int[reque.size];
            trop1 = process.newfst_mut;
            trop2 = processes.newsnd_mut;
            int spox, spox1 = 0;
            for (int item1 = 0; item1 < reque.size; item1++)
            {
                spox = spox + trop1[item1];
            }
            for (int item2 = 0; item2 < reque.size; item2++)
            {
                spox1 = spox1 + trop2[item2];
            }
            if (spox<spox1)
            {
                trop = true;
            }
            else
            {
                trop = false;
            }
            return trop;
        }
    }
}