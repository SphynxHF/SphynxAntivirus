using System;
using System.IO;
using System.Net;

namespace SphynxAntivirus
{
    public static class SignatureUpdater
    {
        public static string SignatureURL = "https://raw.githubusercontent.com/SphynxHF/SphynxAntivirus/refs/heads/master/SphynxAntivirus/signatures.txt?token=GHSAT0AAAAAADFY2ZFEGC2CMN3XVEVXFLHC2CQWARQ"; // Replace with your URL
        public static string LocalPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "signatures.txt");

        public static bool UpdateSignatures()
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(SignatureURL, LocalPath);
                }

                Logger.Log("Signatures updated successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log($"Signature update failed: {ex.Message}");
                return false;
            }
        }
    }
}
