Random random= new Random();
int[] array = new int[1000];
for (int i = 0;i< array.Length; i++)
    array[i] = random.Next(1,100);
//создание рандомного массива
Array.Sort(array);/*сортировка*/
int povMajor = -1, major = 0, tecPovMajor = 0, tecMajor = array[0];
//обЪявление переменных
foreach(int i in array)
{
    if (i == tecMajor)
    {
        tecPovMajor ++;
    }
    
    else
    {
        tecPovMajor = 1;
        tecMajor = i;
    }
    if(tecPovMajor > povMajor)
    {
        povMajor = tecPovMajor;
        major = i;
    }
    Console.WriteLine($"Число которое больше всего повторяется: "+ major +".Количество его повтора:" +povMajor  );
}