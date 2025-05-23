using EDCodex.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EDCodex.Data;

public static class DbAccessor
{
    private const string DataFilePath = @"..\Codex.data";
    private static Codex _codex;

    public static Codex Codex
    {
        get => _codex ?? throw new ArgumentNullException("Codex cannot be null (get)");
        set => _codex = value ?? throw new ArgumentNullException("Codex cannot be null (set)");
    }

    public static void LoadCodex()
    {
        var json = File.ReadAllText(DataFilePath);

        Codex = JsonSerializer.Deserialize<Codex>(json);
    }

    public static void SaveCodex()
    {
        var json = JsonSerializer.Serialize(
            Codex ?? throw new ArgumentNullException("Codex cannot be null"),
            new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(DataFilePath, json);
    }

    public static void ClearCodex()
    {
        Codex = new Codex();
        SaveCodex();
    }        
}
