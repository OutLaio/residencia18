/* 
Problema: Você tem duas strings, string str1 = "Hello" e string str2 = "World". Escreva
código para verificar se as duas strings são iguais e exibir o resultado.
*/

string str1 = "Hello";
string str2 = "World";

if(str1.CompareTo(str2) == 0)
    Console.WriteLine("As strings são iguais!");
else
    Console.WriteLine("As strings são diferentes!");