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
            if(char.IsLetter(b[i])){
                if((i+1) < b.length){
                    if(b[i+1] == "*"){
                        indexA++;
                        while(indexA < a.length && a[indexA] == b[i]){
                            indexA++;
                        }
                    }
                    else{
                        if(a[indexA] == b[i]){
                            indexA++;
                        }
                    }
                }
            }
            else{
                if(b[i] == '*''){
                    continue;
                }
                if(b[i] == '.'){
                   if(b[i+1] == "*"){
                        indexA++;
                        while(indexA < a.length){
                            indexA++;
                        }
                    }
                    else{
                        if(a[indexA] == b[i]){
                            indexA++;
                        }
                    } 
                }
            }
        }
        return false;
    }
}
