#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{

    char c;
    int a;
    int b;


    while (!(cin >> c).eof())
    {

        cin>> a;
        cin >> b;


        switch(c)
        {
            case '+':
                cout<<a+b<<endl;
                break;
            case '-':
                cout<<a-b<<endl;
                break;
            case '*':
                cout<<a*b<<endl;
                break;
            case '/':
                cout<<a/b<<endl;
                break;
            case '%':
                cout<<a%b<<endl;
                break;
        }
    }
    return 0;
}
