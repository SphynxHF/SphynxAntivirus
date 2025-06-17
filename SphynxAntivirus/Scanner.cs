using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

public static class Scanner
{
    public static HashSet<string> LoadSignatures(string path)
    {
        var lines = File.ReadAllLines(path);
        return new HashSet<string>(lines);
    }

    public static string ComputeSHA256(string filePath)
    {
        using (var sha256 = SHA256.Create())
        using (var stream = File.OpenRead(filePath))
        {
            var hash = sha256.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }

    public static List<string> ScanFolder(string folderPath, HashSet<string> signatures, string quarantinePath)
    {
        var results = new List<string>();
        var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

        foreach (var file in files)
        {
            try
            {
                string hash = ComputeSHA256(file);
                if (signatures.Contains(hash))
                {
                    QuarantineFile(file, quarantinePath);
                    results.Add($"QUARANTINED: {Path.GetFileName(file)}");
                    Logger.Log($"QUARANTINED: {file}");

                }
                else
                {
                    results.Add($"OK: {Path.GetFileName(file)}");
                    Logger.Log($"OK: {file}");
                }
            }
            catch
            {
                results.Add($"ERROR: {Path.GetFileName(file)}");
            }
        }

        return results;
    }


    public static void QuarantineFile(string filePath, string quarantinePath)
    {
        try
        {
            if (!Directory.Exists(quarantinePath))
                Directory.CreateDirectory(quarantinePath);

            string fileName = Path.GetFileName(filePath);
            string destPath = Path.Combine(quarantinePath, $"{Guid.NewGuid()}_{fileName}");

            File.Move(filePath, destPath);
        }
        catch (Exception ex)
        {
            // Handle errors (e.g., file in use, permissions)
            Console.WriteLine($"Failed to quarantine {filePath}: {ex.Message}");
        }
    }

    public static List<string> GetQuickScanPaths()
    {
        var paths = new List<string>
    {
        Environment.GetFolderPath(Environment.SpecialFolder.System),
        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        Environment.GetFolderPath(Environment.SpecialFolder.Startup),
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
    };

        return paths.Where(Directory.Exists).ToList();
    }


}
