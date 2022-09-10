namespace JewelCollector;

public class JewelCollector {
    Map m; 

    public JewelCollector() {
         m = new Map();
         Robot r = new Robot();
         m.insertEntity(0,0,r);
         m.insertEntity(5,0,new Tree());
         m.insertEntity(5,1,new Tree());
         m.insertEntity(5,2,new Tree());
         m.insertEntity(5,3,new Tree());
         m.insertEntity(5,5,new Tree());
         m.insertEntity(5,6,new Water());
         m.insertEntity(5,9,new Water());
         m.insertEntity(3,9,new Water());
         m.insertEntity(8,3,new Water());
         m.insertEntity(2,5,new Water());
         m.insertEntity(1,4,new Water());
         m.draw(); // chamei o draw 

    }
    public static void Main()
    {
        JewelCollector j = new JewelCollector();
    }
}
