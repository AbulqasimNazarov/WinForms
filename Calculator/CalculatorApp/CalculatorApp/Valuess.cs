
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace CalculatorApp;


public class Valuess
{
    public int num1;
    public int num2;
    public int result;

    public static List<string> operationList = new List<string>();
    public Valuess()
    {

    }
    public static void SavetoList(string operation)
    {        
        operationList.Add(operation);
    }

    public static void SaveJson()
    {
        var json = JsonSerializer.Serialize(operationList);
        File.WriteAllText("historyBox.json", json);
    }

    public static List<string> LoadJson(string filePath)
    {
        var json = File.ReadAllText(filePath);

        return JsonSerializer.Deserialize<List<string>>(json);
    }

}
