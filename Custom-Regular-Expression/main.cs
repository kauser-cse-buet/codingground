using System.IO;
using System;

class Program
{
    static void Main()
    {
        IsMatch("aaa", "a*a.");
    }
    
    static bool IsMatch(string a, string b){
        int indexA = 0;
        for(int i=0; i<b.Length; i++){
            Console.WriteLine(b[i]);
            if(b[i] != '*'){
                
            }
        }
        return false;
    }
}
