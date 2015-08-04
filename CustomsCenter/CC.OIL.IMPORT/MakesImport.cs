using System;
using System.IO;
using System.Runtime.Serialization.Json;
using CC.EF;
using CC.OIL.IMPORT.JsonObjects;

namespace CC.OIL.IMPORT
{

    internal class MakesImport : IImport
    {
        private readonly AppContext _context;

        public MakesImport(AppContext context)
        {
            _context = context;
        }

        public void Import(string filepath)
        {
            if (filepath == null) throw new ArgumentNullException("filepath");

            var args = Path.GetFileName(filepath).Split('_');
            var make = args[1];

            using (var reader = new StreamReader(filepath)) {
                var ser = new DataContractJsonSerializer(typeof (MakeJsonObject));
                var obj = (MakeJsonObject) ser.ReadObject(reader.BaseStream);
                obj.alt = "";
            }
        }
    }

}