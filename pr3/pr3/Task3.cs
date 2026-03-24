namespace pr3
{
    public class Task3
    {
        public void SearchForBiggest(string path)
        {
            Stack<string> folderStack = new Stack<string>();
            folderStack.Push(path);
            uint maxFileSize = 0;
            string biggestFile = string.Empty;
            string biggestFilePath = string.Empty;

            while (folderStack.Count > 0)
            {
                string currentDir = folderStack.Pop();

                string[] subDirs = Directory.GetDirectories(currentDir);
                foreach (string subDir in subDirs)
                {
                    folderStack.Push($"{subDir}");
                    foreach (string file in Directory.GetFiles(currentDir))
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        if (maxFileSize < fileInfo.Length)
                        {
                            maxFileSize = (uint)fileInfo.Length;
                            biggestFile = fileInfo.Name;
                            biggestFilePath = fileInfo.FullName;
                        }
                    }
                }
            }
            Console.WriteLine($"Name: {biggestFile}, Size: { maxFileSize / 1048576} MB, Path: {biggestFilePath}");
        }


    }
}
