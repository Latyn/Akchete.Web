using System;

namespace Ak.Services
{
    public interface ImailService
    {
        bool sendMail(string to, string from, string subject, string body);
    }
}