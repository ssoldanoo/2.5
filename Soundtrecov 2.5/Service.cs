using Soundtrecov_2_5.Models;

namespace Soundtrecov_2_5;

public class Service
{
    private static Context? _db;
    public static Context  GetDbContext()
    {
        if (_db == null)
        {
            _db = new Context();
        }
        return _db;
    }
}