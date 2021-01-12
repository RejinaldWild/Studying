using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractsInterfaces
{
    internal abstract class BaseL2
    {
        public abstract string Text { get; set; }
        public abstract char this[int k] { get; }
        public abstract int Length { get; }
    }
    
    internal class AlphaL2 : BaseL2
    {
        private char[] Symbs;
        public AlphaL2(string t) : base()
        {
            Text = t;
        }
        public override string Text
        {
            get
            {
                return new string(Symbs);
            }
            set
            {
                Symbs = value.ToCharArray();
            }
        }
        public override int Length
        {
            get
            {
                return Symbs.Length;
            }
        }
        public override char this[int k]
        {
            get
            {
                return Symbs[k];
            }
        }
    }

    internal class BravoL2 : BaseL2
    {
        private string Txt;
        public BravoL2(string t) : base()
        {
            Text = t;
        }
        public override string Text
        {
            get { return Txt; }
            set { Txt = value; }
        }
        public override int Length
        {
            get { return Txt.Length; }
        }
        public override char this[int k]
        {
            get
            {
                return Txt[k];
            }
        }
    }

    internal class AbstrPropAndIndex
    {
        public static void Main02()
        {
            BaseL2 Obj1 = new AlphaL2("Alpha");
            Console.WriteLine(Obj1.Text);
            Obj1.Text = "Base";
            for(int k = 0; k < Obj1.Length; k++)
            {
                Console.Write("|"+Obj1[k]);
            }
            Console.WriteLine("|");
            Obj1 = new BravoL2("Bravo");
            for (int k = 0; k < Obj1.Length; k++)
            {
                Console.Write("|" + Obj1[k]);
            }
            Console.WriteLine("|");
            Obj1.Text = "Base";
            Console.WriteLine(Obj1.Text);                        
        }
    }
}
