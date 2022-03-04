using static System.Console;
Numero a = new Numero(2);
Numero b = new Numero(2);

// comparação de referencias
if (a == b) { WriteLine($"a e b são iguais referencialmente"); }
else { WriteLine($"a e b são diferentes referencialmente"); }

// comparação de valores
if (a.N == b.N) { WriteLine($"a e b são iguais numericamente"); }
else { WriteLine($"a e b são diferentes numericamente"); }

class Numero
{
    public int N { get; set; }

    public Numero(int n) { N = n; }
}