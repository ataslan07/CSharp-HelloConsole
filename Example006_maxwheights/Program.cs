int A = 1;
int B = 2;
int C = 3;
int D = 4;

int MAX = A;
if(A > MAX) MAX = A;
if(B > MAX) MAX = B;
if(C > MAX) MAX = C;
if(D > MAX) MAX = D;

Console.Write("MAX = ");
Console.WriteLine(MAX);