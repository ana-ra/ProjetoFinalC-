namespace JewelCollector;

public abstract class Jewel : Entity
{
 
}

public class JewelRed : Jewel
{

public override string ToString()
    {
        return "JR";
    }
}

public class JewelGreen : Jewel
{

public override string ToString()
    {
        return "JG";
    }
}

public class JewelBlue : Jewel
{

public override string ToString()
    {
        return "JB";
    }
}

