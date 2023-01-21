'''
DYZIO2 - Dyzio (https://pl.spoj.com/problems/DYZIO2/)
Wejście
Dane podawane są na standardowe wejście. 
W pierwszym wierszu podana jest liczba N (1<=N<=20000) zestawów danych. 
Dalej podawane są zestawy danych zgodnie z poniższym opisem:

Jeden zestaw danych
W pierwszym i jedynym wierszu zestawu danych znajdują się dwie liczby a i b (2<=a<=b<=106), 
oddzielone pojedynczą spacją, oznaczające odpowiednio początek i koniec przedziału domkniętego, 
dla którego program będzie wyznaczał ilość liczb pierwszych.

Wyjście
Wyniki programu powinny być wypisywane na standardowe wyjście. 
W kolejnych wierszach należy podać odpowiedzi obliczone dla kolejnych zestawów danych. 
Wynikiem dla jednego zestawu jest liczba liczb pierwszych znajdujących się w przedziale domkniętym [a,b].

dane wejściowe:
2
6 19
12 50

wynik:
5
10
'''

import math

data = int(input())
lines = []
for line in range(data):
    line = input()
    lines.append(line.split())

def is_prime(n):
  for i in range(2, int(math.ceil(math.sqrt(n)+1))):
    if (n % i) == 0:
      return False
  return True

for i in range(0, len(lines)):
    count = 0
    for j in range(int(lines[i][0]), int(lines[i][1])+1):
        if is_prime(j):
            count += 1
    print(count)
