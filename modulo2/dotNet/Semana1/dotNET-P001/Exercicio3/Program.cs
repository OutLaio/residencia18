/* 
Ao converter um double para um int em C#, a parte fracionária do número é truncada, ou seja, removida sem arredondamento.
Se a parte fracionária não puder ser acomodada em um int, isso resultará em perda de dados.
*/


double numeroDouble = 15.78;

// Convertendo double para int
int numeroInteiro = (int)numeroDouble;

Console.WriteLine($"Número double: {numeroDouble}");
Console.WriteLine($"Número inteiro (após conversão): {numeroInteiro}");

/* 
Neste exemplo, a variável numeroDouble é convertida para int usando a sintaxe de cast (int).
Sendo a parte fracionária incapaz de ser acomodada em um int, ela será truncada, resultando em perda de precisão.

Por exemplo, sendo numeroDouble 15.78, a parte fracionária .78 seria removida durante a conversão, 
e o valor de numeroInteiro seria 15. Note que nenhum arredondamento ocorre, e a conversão 
simplesmente trunca a parte decimal.

Uma solução rasa pode ser feita a partir do seguinte código:
*/

int casasDecimais = (int)(10000*(numeroDouble-numeroInteiro));

Console.WriteLine($"Numero completo: {numeroInteiro}.{casasDecimais}");

/*
Neste exemplo, coverte-se a parte fracionária do número para inteiro e é realizado um truncamento
para a variável casasDecimais. Desta forma, obtemos uma variável com a parte inteira do numero original
e uma outra variável que armazena o correspondente à parte fracionária do número original.
*/
