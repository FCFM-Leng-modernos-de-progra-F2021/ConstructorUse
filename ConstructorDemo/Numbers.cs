using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorDemo
{
    public class Numbers
    {
        public int Count { get; set; }
        public List<int> MyNumbers { get; set; }
        //Cuando no hay constructor, el constructor es "invisible" o lo que es lo mismo 
        //como si estuviera escrito esto
        //public Numbers()
        //{

        //}

        public Numbers()
        {
            MyNumbers = new List<int>() { 1, 2, 5, 10 };
            Count = MyNumbers.Count;
        }
    }
}
