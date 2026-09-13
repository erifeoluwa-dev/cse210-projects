using System;
public class Entry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = "";
    public void Display()
        {
    Console.WriteLine($"{_prompt} \n{_response} -{_date}");
    }
    public string GetSaveString()
    {
        return $"{_prompt}~{_response}~{_date}";
    }
}