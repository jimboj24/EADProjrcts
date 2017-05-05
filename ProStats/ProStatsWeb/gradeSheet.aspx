<%@ Page Title="Gradesheet" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ProStatsWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <formview>
        Student ID:<br /><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
        FullName:<br /><asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br />
        Programme:<br /><asp:TextBox ID="txtProgramme" runat="server"></asp:TextBox><br />
        Simester:<br /><asp:TextBox ID="txtSimester" runat="server"></asp:TextBox><br />
        Year:<br /><asp:TextBox ID="txtYear" runat="server"></asp:TextBox><br />
        Academic Year:<br /><asp:TextBox ID="txtAcademicYear" runat="server"></asp:TextBox>
    <br />
    <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"></asp:Button>&nbsp;&nbsp; <asp:Button ID="btnCancel" runat="server" Text="Cancel"></asp:Button>

    </formview>
    
    <p>Use this area to provide additional information.</p>
</asp:Content>
