using System.Text;

StringBuilder sb = new StringBuilder("Viplav");

sb.Clear();
sb.Append("Ganesh");

int first = 0;
int last = sb.Length - 1;


while (first <= last)
{

    char temp = sb[first];
    sb[first] = sb[last];
    sb[last] = temp;


    first++;
    last--;
}

for (int i = 0; i < sb.Length; i++)
{
    Console.WriteLine(sb[i]);
}