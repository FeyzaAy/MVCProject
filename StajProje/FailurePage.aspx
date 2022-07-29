<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FailurePage.aspx.cs" Inherits="StajProje.FailurePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvArizalar" runat="server" AutoGenerateColumns="True"  PageSize="5"
            ForeColor="#333333" GridLines="None" Width="1220" Height="450" AllowPaging="True" OnPageIndexChanging="grdData_PageIndexChanging_Arizalar" > 
           <editrowstyle BackColor="#999999"></editrowstyle>    
           <footerstyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></footerstyle>    
           <headerstyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></headerstyle>    
           <pagerstyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></pagerstyle>  
           <rowstyle BackColor="#F7F6F3" ForeColor="#333333"></rowstyle>    
           <selectedrowstyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></selectedrowstyle>    
           <sortedascendingcellstyle BackColor="#E9E7E2"></sortedascendingcellstyle>    
           <sortedascendingheaderstyle BackColor="#506C8C"></sortedascendingheaderstyle>    
           <sorteddescendingcellstyle BackColor="#FFFDF8"></sorteddescendingcellstyle>    
           <sorteddescendingheaderstyle BackColor="#6F8DAE"></sorteddescendingheaderstyle>    
    </asp:Gridview>
</asp:Content>
