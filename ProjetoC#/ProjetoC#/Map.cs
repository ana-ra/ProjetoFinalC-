namespace JewelCollector;
public class Map

{

    Entity[,] matrix = new Entity[10, 10];
    public Map() {
        for ( int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                matrix[i, j] = new OpenSpace(); 
            }
        }
    }
    public void draw(){
        string line = "";
         for ( int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                line += matrix[i, j] + " "; 
            }
            line += "\n";
        }
        Console.WriteLine(line);



    }

    public void insertEntity(int i, int j, Entity e){
        matrix[i, j] = e; 
    }
}
