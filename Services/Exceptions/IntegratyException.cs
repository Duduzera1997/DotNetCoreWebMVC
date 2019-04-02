using System;
namespace DotNetCoreWebMVC.Services.Exceptions
{
    public class IntegratyException : ApplicationException
    {
        public IntegratyException(string message) : base(message)
        {
        }
    }
}
