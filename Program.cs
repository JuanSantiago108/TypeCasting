List<object> objectList = new List<object>();
objectList.Add(7);
objectList.Add(27);
objectList.Add(-1);
objectList.Add(true);
objectList.Add("chair");

int total = 0;

foreach (object obj in objectList)
if (obj is int){
    total+=(int)obj;
}

{
    Console.WriteLine(total);
}