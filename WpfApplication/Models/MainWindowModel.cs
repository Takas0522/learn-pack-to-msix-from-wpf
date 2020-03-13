using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace WpfApplication.Models
{
    public class MainWindowModel
    {
        public MainWindowModel()
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            AssemblyVersion = versionInfo.FileVersion;
        }

        public string AssemblyVersion { get; set; }

        public override bool Equals(object obj)
        {
            return obj is MainWindowModel model &&
                   AssemblyVersion == model.AssemblyVersion;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AssemblyVersion);
        }
    }
}
