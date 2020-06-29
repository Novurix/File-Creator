import java.io.FileWriter;
import java.io.IOException;

public class Launcher {
    static FileCreator creator;

    public static void main(String[] args) {
        creator = new FileCreator();
    }
}

class FileCreator {
    public FileCreator() {

        try {
            // creates file
            FileWriter writer = new FileWriter("FILE_NAME.txt");
            writer.write("TEST");
            writer.flush();
            writer.close();
            
        }catch(IOException e) {}
    }
}