namespace pr3
{
    public class Task5
    {
        public void Analyzer(string path)
        {
            Stack<string> folderStack = new Stack<string>();
            folderStack.Push(path);
            uint foldersCount = 0;
            uint filesCount = 0;
            long totalSize = 0;
            uint maxFileSize = 0;
            string biggestFile = string.Empty;

            while (folderStack.Count > 0)
            {
                string currentDir = folderStack.Pop();

                string[] subDirs = Directory.GetDirectories(currentDir);
                foreach (string subDir in subDirs)
                {
                    foldersCount++;
                    folderStack.Push($"{subDir}");
                    foreach (string file in Directory.GetFiles(currentDir))
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        if (maxFileSize < fileInfo.Length)
                        {
                            maxFileSize = (uint)fileInfo.Length;
                            biggestFile = fileInfo.FullName;
                        }
                        totalSize += fileInfo.Length;
                        filesCount++;
                    }
                }
            }
            Console.WriteLine($"Folders: {foldersCount}, Files: {filesCount}, Total size: {totalSize/1048576} MB, Largest file: {biggestFile}");
        }
    }
}
