using System;

public class Program
{
    public static string string_merge(string a, string b)
    {
              
        char[] a_arr = a.ToCharArray();
        char[] b_arr = b.ToCharArray();
        char[] wynik_arr = new char[a.Length * b.Length+1];
        //wynik_arr[0] = a_arr[0];
        int j = 0;
        int i = 0;
        for (; j < b.Length; i += 2, j++)
        {
        if (a.Length > b.Length)
        {
            if (b.Length == j)
            {
                break;
            }

            wynik_arr[i] = b[j];
            wynik_arr[i + 1] = a[j];
        }
        else
                if (a.Length == j)
                {
                    break;
                }

                wynik_arr[i] = a[j];
                wynik_arr[i+1] = b[j];  


        }
        char[] result = new char[i+1];
        for(int x = 0; x < wynik_arr.Length+1; x++)
        {
            if(wynik_arr[x] == '\0')
            {
                break;
            }
            else
            {
                result[x] = wynik_arr[x];   
            }
        }

        // if(wynik_arr[wynik_arr.Length-1] != '\0')
        //     wynik_arr[i] = '\0';

        string wynik = new string(result); ;
        wynik = wynik.Remove(wynik.Length - 1, 1);
        return wynik;
        
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] wynik = new string[n];
        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            string a = s[0];
            string b = s[1];
            //wynik = new string[s.Length];
            wynik[i] = string_merge(a, b);
        }
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(wynik[i]);
        }
       
    }
}
