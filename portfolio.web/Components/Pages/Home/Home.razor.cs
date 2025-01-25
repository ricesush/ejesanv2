using portfolio.domain.Entities;
using portfolio.web.Utilities;

namespace portfolio.web.Components.Pages.Home;

public partial class Home
{
    private int TenureYear { get; set; } = 0;
    private int TenureMonth { get; set; } = 0;
    private List<MilestoneModel> Milestone { get; set; } = [];
    private List<Techstack> PrimaryStacks { get; set; } = [];
    private List<Techstack> SecondaryStacks { get; set; } = [];
    protected override async Task OnInitializedAsync()
    {
        try
        {
            DateTime startDate = DateTime.Parse(AppSettingsHelper.StartDate);
            DateTime currentDate = DateTime.UtcNow.AddHours(8);

            TenureYear = (((currentDate.Year - startDate.Year) * 12) + (currentDate.Month - startDate.Month)) / 12;
            TenureMonth = (((currentDate.Year - startDate.Year) * 12) + (currentDate.Month - startDate.Month)) % 12;

            SetMilestone();
            SetTechstacks();
        }
        catch (Exception ex)
        {

        }
    }

    private void SetMilestone(){
        try
        {
            Milestone.Add( new(){
                CompanyLocation = "Amorsolo Street, Legazpi Village, Makati",
                CompanyName = "Premier Software Enterprise",
                Date = new DateOnly(2023, 5, 22),
                Description = "Premier is a financial technology company, with deep expertise in financial and equity industry. We connect people powered by intellect, driven by values, exceptional ideas, and strong vision to achieve innovative digital solutions.",
                Position = "Software Developer"
            });

            Milestone.Add( new(){
                CompanyLocation = "Taguig, Metro Manila, Philippines",
                CompanyName = "Kodego",
                Date = new DateOnly(2022, 11, 12),
                Description = "KodeGo is a 12-week online bootcamp that teaches full-stack web development to beginners and career shifters.",
                Position = "Web Developer"
            });

            Milestone = [..Milestone.OrderByDescending(item => item.Date)];
        }
        catch (Exception ex)
        {
            
        }
    }

    private void SetTechstacks(){
        try
        {
            
            PrimaryStacks = [
                new(){
                    Label="C#",
                    Src="/img/csharp.svg.png"
                },
                new(){
                    Label="Javascript",
                    Src="/img/js.svg.png"
                },
                new(){
                    Label="Vue JS",
                    Src="/img/vuejs.svg.png"
                },
                new(){
                    Label="Blazor",
                    Src="/img/blazor.svg"
                },
                new(){
                    Label="Tailwind",
                    Src="/img/tailwind.svg.png"
                },
                new(){
                    Label=".Net Core",
                    Src="/img/netCore.svg.png"
                },
                new(){
                    Label="MySQL",
                    Src="/img/mysql.svg"
                },
                new(){
                    Label="Github",
                    Src="/img/github.png"
                },
                new(){
                    Label="VSCode",
                    Src="/img/vscode.png"
                }
            ];

            SecondaryStacks = [
                new(){
                    Label="MongoDB",
                    Src="/img/MongoDB.svg.png"
                },
                new(){
                    Label="Express",
                    Src="/img/Express.png"
                },
                new(){
                    Label="React",
                    Src="/img/React.svg.png"
                },
                new(){
                    Label="NodeJS",
                    Src="/img/Node.js_logo.svg.png"
                },
                new(){
                    Label="PHP",
                    Src="/img/PHP.svg.png"
                },
                new(){
                    Label="Laravel",
                    Src="/img/Laravel.svg.png"
                }
            ];
        }
        catch (Exception ex)
        {
            
        }
    }
}