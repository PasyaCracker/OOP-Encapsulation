using System;

public class HelloWorld
{
    static public void Main ()
    {
        Rumus rumus = new Rumus ();
Console.WriteLine(rumus.tampil());
Console.Write("inputkan panjang : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("inputkan lebar : ");
int l = Convert.ToInt16(Console.ReadLine());
Console.Write("inputkan tinggi : ");
int t = Convert.ToInt16(Console.ReadLine());
rumus.kali(p,l);
Console.Write("Volume Balok Adalah : ");
Console.WriteLine(rumus.balok(t));

    }
    class Kalkulator
    {
        private string tulisan = "Rumus Volume Balok" ;
        public string tampil(){
            return tulisan;
        } 
        protected int alas;

        public int kali(int a, int b){
            return this.alas = a * b;
        }
    }

    class Rumus:Kalkulator 
    {
        public int balok(int t) {
            return this.alas * t;
        } 
    }

}
