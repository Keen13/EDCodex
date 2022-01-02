using ED_Codex.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ED_Codex
{
    public static class DbAccessor
    {
        private const string DataFilePath = @"C:\Work\ ED\Codex.data";
        private static Codex codex;

        public static Codex Codex
        {
            get => codex ?? throw new ArgumentNullException("Codex cannot be null (get)");
            set => codex = value ?? throw new ArgumentNullException("Codex cannot be null (set)");
        }

        public static void LoadCodex()
        {
            var json = File.ReadAllText(DataFilePath);

            Codex = JsonSerializer.Deserialize<Codex>(json);
        }

        public static void SaveCodex()
        {
            var json = JsonSerializer.Serialize(Codex ?? throw new ArgumentNullException("Codex cannot be null"));

            File.WriteAllText(DataFilePath, json);
        }
    }
}
