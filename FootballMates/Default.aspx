<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FootballMates._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
<section>
    <div class="container">
        <div class="row">
            <asp:Repeater ID="ClubRepeater" runat="server">
                <ItemTemplate>
                    <div class="col-md-4">
                        <div class="card" style="margin-bottom: 10px;">
                            <img class="m-4" src="data:image/png;base64,<%# Eval("ClubLogoBase64") %>" alt="<%# Eval("ClubName") %>" />
                            <div class="card-body text-center">
                                <div>
                                    <asp:Button ID="ClubButton" runat="server" CssClass="btn" BackColor="#bde8f1" CommandName="VisitClub" CommandArgument='<%# Eval("ClubId") %>' Text='<%# Eval("ClubName") %>' OnClick="ClubButton_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</section>

    </main>

</asp:Content>
