using EDCodex.Data.Models;
using System.Text.Json;

namespace EDCodex.Data;

public static class DbAccessor
{
    private const string DataFilePath = @"..\Codex.data";
    private static readonly JsonSerializerOptions JsonSerializerOptions  = new() { WriteIndented = true };

    private static Codex? _codex;

    public static Codex Codex
    {
        get => _codex ?? throw new ArgumentNullException("Codex cannot be null (get)");
        set => _codex = value ?? throw new NullReferenceException("Codex cannot be null (set)");
    }

    public static void LoadCodex()
    {
        var json = File.ReadAllText(DataFilePath);
        Codex = JsonSerializer.Deserialize<Codex>(json);
    }

    public static void SaveCodex()
    {
        var json = JsonSerializer.Serialize(Codex, JsonSerializerOptions);
        File.WriteAllText(DataFilePath, json);
    }

    public static void ClearCodex()
    {
        Codex = new Codex();
        SaveCodex();
    }        
}
