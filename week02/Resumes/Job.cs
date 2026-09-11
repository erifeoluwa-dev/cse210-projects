public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _stopYear = 0;                          
    public void Display()
    {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_stopYear}");
    }
}
