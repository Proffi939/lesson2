using System.Formats.Asn1;

int n = 59;
int n1 = n / 10;
int n2 = n % 10;
int max = 0;
if (n1 > n2)
{
    max = n1;
}
else
{
    max = n2;
}
Console.Write(max);