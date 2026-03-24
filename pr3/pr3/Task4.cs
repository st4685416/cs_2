namespace pr3
{
    public class Task4
    {
        public void ClearCache(string path)
        {
            Stack<string> folderStack = new Stack<string>();
            folderStack.Push(path);
            uint filesCount = 0;
            long totalSize = 0;

            while (folderStack.Count > 0)
            {
                string currentDir = folderStack.Pop();
                
                foreach (string file in Directory.GetFiles(currentDir))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;
                    File.Delete(file);
                }
                
                foreach (string subDir in Directory.GetDirectories(currentDir))
                {
                    folderStack.Push(subDir);
                }
            }
            Console.WriteLine($"Files: {filesCount}, Total size: {totalSize} B");
        }

        public void ClearCacheRecursive(string path)
        {
            if (!Directory.Exists(path)) return;

            uint filesCount = 0;
            long totalSize = 0;

            void Recursive(string currentDir)
            {
                foreach (string file in Directory.GetFiles(currentDir))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;
                    filesCount++;
                    File.Delete(file);
                }
                foreach (string subDir in Directory.GetDirectories(currentDir))
                {
                    Recursive(subDir);
                }
            }

            Recursive(path);

            Console.WriteLine($"Files: {filesCount}, Total size: {totalSize} B");

        }
    }
}
