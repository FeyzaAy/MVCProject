<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="StajProje.Map" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <script src="https://maps.googleapis.com/maps/api/js?v=3.exp&sensor=false" type="text/javascript"></script>  
        <script>  
            var mapcode;  
            var diag;  
            function initialize() {  
                mapcode = new google.maps.Geocoder();  
           
                var lnt = new google.maps.LatLng(38.9637, 35.2433);  
              
                const map = new google.maps.Map(document.getElementById("map_populate"), {
                    zoom: 4,
                    center: lnt,
                });
                const marker = new google.maps.Marker({
                    position: lnt,
                    map: map,
                });
            }  
         
           
            google.maps.event.addDomListener(window, 'load', initialize);  
        </script>  

    
            <h1>Enter Your Location Details</h1>  
      
        <div>  
            <asp:TextBox ID="txt_location" TextMode="MultiLine" Width="400px" Height="70px" runat="server"></asp:TextBox>  
    </div>  
        <div>  
            <input type="button" value="Search" onclick="getmap()">  
        </div>  
    <div id="map_populate" style="width:100%; height:500px; border: 5px solid #5E5454;">  
    </div>  
   
</asp:Content>
