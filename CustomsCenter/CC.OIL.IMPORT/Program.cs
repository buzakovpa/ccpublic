using System;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using CC.EF;

namespace CC.OIL.IMPORT
{
    public static class Program   
    {
        public static int Main(string[] args)
        {
            const string outputPath = @"C:\Users\buzakovpa\YandexDisk\databases\oil-screens";
            var inputPath = @"C:\Users\buzakovpa\YandexDisk\databases\oil-result\";

            using (var context = new AppContext()) {
                var import = new MakesImport(context);

                var files = Directory
                    .GetFiles(outputPath, "*.json", SearchOption.AllDirectories)
                    .ToList();

                files.ForEach(
                    a => {
                        var fn = Path.GetFileName(a);

                        var file0Info = new FileInfo(a);
                        
                        var file1Info = new FileInfo(inputPath + fn);

                        if (File.Exists(inputPath + fn) && file0Info.Length != file1Info.Length) {
                            inputPath += new Random().Next(100000, 999999);
                        }
                        File.Move(a, inputPath + fn);
                    });
            }
            return 0;
        }
    }
}
