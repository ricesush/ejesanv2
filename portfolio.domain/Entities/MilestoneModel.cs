namespace portfolio.domain.Entities;

public class MilestoneModel
{
    public DateOnly Date
    {
        get
        {
            return _Date;
        }
        set
        {
            Month = value.ToString("MMM");
            Year = value.Year;
            Day = value.Day;
            _Date = value;
        }
    }

    public string CompanyName { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public string CompanyLocation { get; set; } = String.Empty;
    public string Position { get; set; } = String.Empty;

    public DateOnly _Date { get; set; } = new();
    public string Month { get; set; } = String.Empty;
    public int Year { get; set; } = 0;
    public int Day { get; set; } = 0;
}