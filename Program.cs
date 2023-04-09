string[] a1 = new string[5] {"Car", "Dog", "hello", "world", "restourant"};
string[] a2 = new string[a1.Length];

void SecondArray(string[] a1, string[] a2)
{
    int count = 0;
    for (int i = 0; i < a1.Length; i++)
    {
    if(a1[i].Length <= 3)
        {
        a2[count] = a1[i];
        count++;
        }
    }
}
