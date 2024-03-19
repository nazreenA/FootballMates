<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FootballMates.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Custom CSS for About page */
.club-logo-container {
    display: flex;
    justify-content: center;
    margin-bottom: 20px;
}

.club-logo {
    max-width: 100%;
    height: auto;
    border: 1px solid #ECECEC; /* Light Gray */
    border-radius: 8px;
    box-shadow: 0px 2px 6px rgba(0, 0, 0, 0.1); /* Shadow effect */
}

.club-details {
    border: 1px solid #f2f2f0; /* Light Gray */
    border-radius: 8px;
    box-shadow: 0px 2px 6px rgba(0, 0, 0, 0.1); /* Shadow effect */
    padding: 20px;
}

.divider {
    border-top: 1px solid #ECECEC; /* Light Gray */
    margin: 10px 0;
}

.club-name {
    color: #2C2C54; /* Dark Indigo */
    font-weight: bold;
    margin-bottom: 10px;
}

.club-detail {
    color: #474787; /* Deep Purple-Gray */
    margin-bottom: 5px;
}

        .club-description {
            color: #AAABB8; /* Cool Gray */
            margin-top: 20px;
            line-height: 1.5;
        }

    .manager-image {
    max-width: 100%;
    height: auto;
    border: 1px solid #ECECEC; /* Light Gray */
    border-radius: 8px;
    box-shadow: 0px 2px 6px rgba(0, 0, 0, 0.1); /* Shadow effect */
    }

    .manager-details {
    background-color: #610c26; /* Burgundy */
    border-radius: 8px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); /* Box shadow */
    }

.manager-name {
    color: #ffffff; /* White text */
    margin-bottom: 0;
}

.manager-details .card-body {
    padding: 20px;
}




    </style>
    <div class="container">
        <div class="row">
            <!-- Left column with club logo -->
            <div class="col-md-4">
                <div class="club-logo-container">
                    <img id="ClubLogoImage" class="club-logo" runat="server" alt="Club Logo" />
                </div>
            </div>
            <!-- Right column with club details -->
            <div class="col-md-8">
                <div class="card club-details">
                    <div class="card-body">
                        <h5 id="ClubNameHeader" runat="server" class="card-title club-name"></h5>
                        <hr class="divider">
                        <p id="YearFoundedLabel" runat="server" class="card-text club-detail"><strong>Year Founded:</strong></p>
                        <p id="StadiumLabel" runat="server" class="card-text club-detail"><strong>Stadium:</strong></p>
                        <p id="CountryLabel" runat="server" class="card-text club-detail"><strong>Country:</strong></p>
                        <hr class="divider">
                        <p id="DescriptionLabel" runat="server" class="card-text club-description"></p>
                    </div>
                    <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                </div>
            </div>
        </div>
    </div>

    <hr />

    <div class="container">
    <div class="row">
        <!-- Manager details card (left column) -->
        <div class="col-md-4">
            <div id="ManagerCard" runat="server" class="card manager-details text-white">
                <div class="card-header">
                    <p id="ManagerNameLabel" runat="server" class="card-text manager-name"></p>
                </div>
                <div class="card-body">
                    <img id="ManagerImage" runat="server" class="manager-image" alt="Manager Image" />
                    <hr />
                    <p id="YearJoinedLabel" runat="server" class="card-text manager-detail"><strong>Year Joined:</strong></p>
                </div>
            </div>
        </div>
        <!-- Table (right column) -->
        <div class="col-md-8">
            <!-- Add your table here -->
        </div>
    </div>
</div>


</asp:Content>
