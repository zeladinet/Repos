using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mint.Framework.Core;
using reSearch.Client.Core;

namespace Mint.Samples.Apps.CodeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            MintProgram.Initialize(new CodeSearchProgram());
            var codeSearchService = MintContainer.Resolve<ICodeSearchService>();
            var resultSet = codeSearchService.Search(new CodeSearchQuery(
                new CodeSearchCollection("windowsenv01", "winmain(dev)", "Windows Threshold"), "foo")
            {
                Path = "sdktools",
                MaxResults = 1000,
            });

            if (resultSet != null && resultSet.Results.Count > 0)
            {
                var firstResult = resultSet.Results[0];
                var remoteFile = codeSearchService.RetrieveRemoteFile(firstResult.FileInfo);
                Console.WriteLine(remoteFile.FileContents);
            }
            Console.ReadLine();
        }
    }
}
