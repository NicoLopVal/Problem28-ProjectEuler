int topLimit = 1001*1001;
int sum = 1;
int counter = 0;
int spaces = 1 + 1;
int circle = 0;

for(int i = 2; i <= topLimit; i++)
{
    circle++;
    if(circle == spaces)
    {
        sum = sum + i;
        counter++;
        circle = 0;
    }

    if(counter == 4)
    {
        spaces = spaces + 2;

        counter = 0;
    }
}

Console.WriteLine(sum);