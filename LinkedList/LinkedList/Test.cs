using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace LinkedList
{
    class Test
    {
        //[Serializable]
        public class Tutorial
        {
            public int id;
            public string name;
        }

        public static void main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.id = 1;
            obj.name = "New";

            IFormatter formmatter = new BinaryFormatter();
            Stream stream = new System.IO.FileStream("c:\\Tatha\\Exp.txt", FileMode.Create);
            formmatter.Serialize(stream, obj);
        }
    }
}
