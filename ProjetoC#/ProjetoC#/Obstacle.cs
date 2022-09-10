namespace JewelCollector;
public abstract class Obstacle : Entity
{
    
}

public class Water : Obstacle
{
    public override string ToString()
    {
        return "##";
    }
}

public class Tree : Obstacle
{

 public override string ToString()
    {
        return "$$";
    }
}