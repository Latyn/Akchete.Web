using System;
using System.Diagnostics;

namespace Ak.Services
{
    public class DebugMailService : ImailService
    {
        public bool sendMail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending email: To:{to}, Subject: {subject}");
            return true;
        }
    }
}