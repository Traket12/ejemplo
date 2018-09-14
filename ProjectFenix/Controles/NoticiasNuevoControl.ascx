<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NoticiasNuevoControl.ascx.cs" Inherits="Controles_NoticiasNuevoControl" %>
<p>
    <asp:Label ID="Label1" runat="server" Text="Titulo"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Width="355px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Contenido"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Height="113px" Width="331px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Foto"></asp:Label>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Seccion"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
</p>
