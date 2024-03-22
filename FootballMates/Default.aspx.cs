using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FootballMates
{
    public partial class _Default : Page
    {
        private readonly FootballMatesEntities _footballMatesEntities = new FootballMatesEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindClubs();
            }
        }

        public void BindClubs()
        {
            var clubs = GetClubs();
            ClubRepeater.DataSource = clubs;
            ClubRepeater.DataBind();
        }

        public List<ClubViewModel> GetClubs()
        {
            return _footballMatesEntities.TblClubs.ToList() // Retrieve all clubs from the database
                .Select(c => new ClubViewModel
                {
                    ClubId = c.ClubId,
                    ClubName = c.ClubName,
                    ClubLogoBase64 = Convert.ToBase64String(c.ClubLogo) 
                }).ToList();
        }

        protected void ClubRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                var club = e.Item.DataItem as ClubViewModel;
                var btnClub = e.Item.FindControl("ClubButton") as Button;

                if (club != null && btnClub != null)
                {
                    btnClub.Text = club.ClubName;
                }
            }
        }

        public class ClubViewModel
        {
            public int ClubId { get; set; }
            public string ClubName { get; set; }
            public string ClubLogoBase64 { get; set; } // Change property type to string for Base64 image
        }

        protected void ClubButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int clubId = Convert.ToInt32(btn.CommandArgument);
            Response.Redirect($"About.aspx?ClubId={clubId}");
        }
    }
}
