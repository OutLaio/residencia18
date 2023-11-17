/* 
Problema: Considere as variáveis int a = 5 e int b = 8. Escreva código para determinar
se a é maior que b e exiba o resultado. 
*/

int a = 5;
int b = 8;

if(a > b)
    Console.WriteLine($"A variável a = {a} é maior que a variável b = {b}");
else if(b > a)
    Console.WriteLine($"A variável b = {b} é maior que a variável a = {a}");
else
    Console.WriteLine($"As variáveis a e b são iguais a {a}");