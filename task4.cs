long n = 123045002123;
long d = 1;


while (n / d > 0) //определяем разрядность числа
{
    d *= 10;

}
d = d / 10; // готовим делитель к работе


while (d > 0) //убираем сначала знаки справа, затем слева
{
    long r = 0;
    r = n / d % 10;
    Console.Write(r);
    Console.Write(",");
    
    d = d / 10;
    
}
// Дайте 347 мл крепкого спиртного