using System;
using System.Linq;

namespace FootballMates
{
    public partial class About : System.Web.UI.Page
    {
        private readonly FootballMatesEntities _footballMatesEntities = new FootballMatesEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ClubId"] != null)
                {
                    int clubId;
                    if (int.TryParse(Request.QueryString["ClubId"], out clubId))
                    {
                        var club = _footballMatesEntities.TblClubs.FirstOrDefault(c => c.ClubId == clubId);
                        if (club != null)
                        {
                            Page.Title = $"About {club.ClubName}";
                            SetClubDetails(club);
                            SetManagerDetails(clubId);
                        }
                        else
                        {
                            HandleError("Club not found.");
                        }
                    }
                    else
                    {
                        HandleError("Invalid Club ID provided.");
                    }
                }
                else
                {
                    HandleError("Club ID not provided.");
                }
            }
        }

        private void HandleError(string message)
        {
            ErrorMessageLabel.Text = message;
        }

        private void SetClubDetails(TblClub club)
        {
            ClubNameHeader.InnerText = club.ClubName;
            ClubLogoImage.Src = $"data:image/png;base64,{Convert.ToBase64String(club.ClubLogo)}";
            YearFoundedLabel.InnerText = $"Founded: {club.YearFounded}";
            StadiumLabel.InnerText = $"Stadium: {club.Stadium}";
            CountryLabel.InnerText = $"Country: {club.Country}";
            DescriptionLabel.InnerText = $"{club.ClubDescription}";
        }

        private void SetManagerDetails(int clubId)
        {
            var manager = _footballMatesEntities.TblManagers.FirstOrDefault(m => m.ClubId == clubId);
            if (manager != null)
            {
                ManagerNameLabel.InnerText = manager.FullName;
                YearJoinedLabel.InnerText = $"Joined: {manager.YearJoined}";
                ManagerImage.Src = $"data:image/png;base64,{Convert.ToBase64String(manager.ManagerImage)}";
            }
            else
            {
                HandleError("Manager details not found.");
            }
        }
    }
}
