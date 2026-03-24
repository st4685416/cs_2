namespace pr3
{
    public class Task2
    {
        public void DisplayFoldersInDirectory(string path)
        {
            if (!Directory.Exists(path)) return;


            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine($"File: {fileInfo.Name}, Size: {fileInfo.Length} bytes, Created: {fileInfo.CreationTime}");
            }

            Stack<string> folderStack = new Stack<string>();
            folderStack.Push(path);

            while(folderStack.Count > 0)
            { 
                string currentDir = folderStack.Pop();
                Console.WriteLine($"{currentDir}");

                string[] subDirs = Directory.GetDirectories(currentDir);
                foreach (string subDir in subDirs)
                {
                    folderStack.Push(subDir);
                }
            }
        }

        public void DisplayFoldersRecursive(string path)
        {
            if (!Directory.Exists(path)) return;

            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine($"File: {Path.GetFileName(file)}");
            }

            foreach (string dir in Directory.GetDirectories(path))
            {
                Console.WriteLine($"Dir: {Path.GetFileName(dir)}");
                DisplayFoldersRecursive(dir);
            }
        }

    }
}