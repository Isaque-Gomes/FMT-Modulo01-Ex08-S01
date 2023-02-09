// Fibonacci (sequência iniciada por 0 e 1 e cada número subsequente é calculado pela soma dos dois anteriores)
int num1 = 0;
int num2 = 1;
int seqFibo;

Console.WriteLine("Nesse programa, vamos calcular os primeiros 20 números da sequência de Fibonacci!");

Console.Write(1 + ",");
for(int i = 0; i <= 20; i++){
    seqFibo = num1 + num2;
    Console.Write(seqFibo + ",");
    num1 = num2;
    num2 = seqFibo;
}