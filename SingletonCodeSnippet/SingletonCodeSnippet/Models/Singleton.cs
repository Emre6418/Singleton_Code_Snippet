using System.IO;

//The part where I tested the snippet :)

public class Test   
{
    private static Test instance;

    private Test()
    {
        // Constructor logic here
    }

    public static Test Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Test();
            }
            return instance;
        }
    }
}








































