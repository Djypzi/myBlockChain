﻿using ConsoleApp1;
using myBlockChain.blockChain;
using System;
using System.Threading;

namespace myBlockChain.test
{
    class TestJson
    {
        static public void Main()
        {
            Console.WriteLine("my Block Chain");
            BlockChain myBlockChaine = new BlockChain();
            Console.WriteLine(myBlockChaine.getBlockI(0).getIndex() + " " + myBlockChaine.getBlockI(0).getData());
            for (int i = 1; i < 10; i++)
            {
                //Thread.Sleep(1000);
                myBlockChaine.searchBlock("test");
                //Console.WriteLine(myBlockChaine.getBlockI(i).getIndex() + " " + myBlockChaine.getBlockI(i).getData());
            }

            myBlockChaine.toString();
            /*Console.WriteLine("Json");
            string json = JsonConvert.SerializeObject(myBlockChaine, Formatting.Indented);
            File.WriteAllText("file.json", json);
            Console.Write(json);

            //StreamWriter file = File.CreateText(@"D:\path.txt");
            Console.WriteLine("open");
            StreamReader r = new StreamReader("file.json");
            Console.WriteLine("lecture");
            string jsonr = r.ReadToEnd();
            Console.WriteLine("deserialize");
            BlockChain deserializedProduct = JsonConvert.DeserializeObject<BlockChain>(jsonr);*/

            Json j = new Json("file.json", myBlockChaine);
            String s = j.serialize();
            Console.WriteLine("json string : "+s);

            BlockChain deserializedProduct = j.deserialize();

            deserializedProduct.toString();

            Console.WriteLine("end");
            


            Thread.Sleep(999999999);
        }

    }
}