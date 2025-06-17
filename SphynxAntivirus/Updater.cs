using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace SphynxAntivirus
{
    public static class SignatureUpdater
    {
        public static string SignatureURL = "http://raw.githubusercontent.com/SphynxHF/SphynxAntivirus/refs/heads/master/SphynxAntivirus/signatures.txt"; // Replace with your URL
        public static string LocalPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "signatures.txt");

        public static bool UpdateSignatures()
        {
            if (!IsInternetAvailable())
            {
                Logger.Log("Signature update skipped: No internet connection.");
                return false;
            }

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


        public static bool IsInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 1000); // Google DNS
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetSignatureVersion()
        {
            try
            {
                if (File.Exists(LocalPath))
                {
                    DateTime modified = File.GetLastWriteTime(LocalPath);
                    return modified.ToString("yyyy-MM-dd HH:mm");
                }
                else
                {
                    return "Not available";
                }
            }
            catch
            {
                return "Unknown";
            }
        }

    }
}
