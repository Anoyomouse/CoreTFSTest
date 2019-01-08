using Microsoft.TeamFoundation.Client;
using System;

namespace CoreTFSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var tfs = new TfsTeamProjectCollection(new Uri(args[0]),
                    new Microsoft.VisualStudio.Services.Common.VssCredentials(
                        new Microsoft.VisualStudio.Services.Common.WindowsCredential(true)));

                var build = tfs.GetService<Microsoft.TeamFoundation.Build.Client.IBuildServer>();

                Console.WriteLine("Got build service");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
            }

            Console.ReadLine();
        }
    }
}
