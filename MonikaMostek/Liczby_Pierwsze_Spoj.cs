// c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Projects
{
    internal class Permutacje
    {
        public void write()
        {
            int n = 15;
            bool isPrime = false;
            for(int i = 3; i <= n; i++)
            {
                if (i < 3)
                {
                    Console.WriteLine(i + " NIE");
                    break;
                }
                for(int j = 2; j <= i / 2; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        Console.WriteLine(i + " NIE");
                        break;
                    }   
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i + " TAK");
                }
                isPrime = true;
            }
        }
    }
}

//c++
/*
 #include <iostream>
using namespace std;
int main()
{
     
     int n;
     int number;
            cin>>n;
            bool isPrime = true;
            string answers[n];
            for(int i = 0; i < n; i++)
            {
            	cin>>number;
            	 if(number<3){
                        isPrime = false;
                        answers[i]="NIE";
                }
                for(int j = 2; j <= number / 2; j++)
                { 
                   
                    if(number % j == 0)
                    {
                        isPrime = false;
                        answers[i]="NIE";
                        //std::cout<<("NIE");
                        break;
                    }   
                }
                if(isPrime ==  true)
                {
                    answers[i]="TAK";
                   // std::cout<<("TAK");
                }
                isPrime = true;
            }
            //cout<<"Output:"<<endl<<endl;
            for(int i=0;i<n;i++){
            	if(i==n-1){
            		cout<<answers[i];
            		break;
            	}
                cout<<answers[i]<<endl;
            }
        return 0;
    
}
*/
