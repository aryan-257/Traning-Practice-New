using Q2_CacheManager;

var intCache = new CacheManager<int>();
intCache.Add("age" , 25);
intCache.Add("score" , 99);
intCache.Add("rank" , 1 , TimeSpan.FromMilliseconds(1));

Console.WriteLine("age = " + intCache["age"]);
Console.WriteLine("All keys : " + string.Join(", " , intCache.GetAllKeys()));

Thread.Sleep(10);
Console.WriteLine("Expired items : " + intCache.CountExpiredItems());

try
{
    intCache.Remove("wrongkey");
}
catch(InvalidCacheKeyException ex)
{
    Console.WriteLine("Exception caught : " + ex.Message);
}

intCache.Clear();
Console.WriteLine("After clear, keys : " + intCache.GetAllKeys().Count);
