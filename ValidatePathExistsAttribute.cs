using System;
using System.Management.Automation;

namespace AVClub
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ValidatePathExists : ValidateArgumentsAttribute
    {
        protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            string path = (string)arguments;

            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException(nameof(path));

            if (!System.IO.File.Exists(path))
                throw new System.IO.FileNotFoundException($"File not found: {path}", path);
        }
    }
}