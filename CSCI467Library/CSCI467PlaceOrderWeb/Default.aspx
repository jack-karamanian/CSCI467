<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSCI467PlaceOrderWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
<table>
    <tr>
        <th>ID</th>
        <th>Description</th>
        <th>Price</th>
    </tr>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>          
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="textBox" Text='<%# Eval("ID") %>' ReadOnly="true"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="textBox1" Text='<%# Eval("Name") %>' ReadOnly="true"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="textBox2" Text='<%# Eval("Price") %>' ReadOnly="true"></asp:TextBox>
                </td>
            </tr>   
        </ItemTemplate>
    </asp:Repeater>
</table>
   



   

    

   

</asp:Content>
