<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSCI467PlaceOrderWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="height: 600px; overflow: auto; align-content: center">   
        <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server">
        
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <input type="checkbox" onclick='onCheckBoxClick(<%#Container.DataItemIndex%>)'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="ID" DataField="Part.ID"/>
            <asp:BoundField HeaderText="Name" DataField="Part.Name"/>
            <asp:BoundField HeaderText="Price" DataField="Part.Price"/>
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox runat="server" ID="quantityTextBox" ClientIDMode="Static" ReadOnly="true" TextMode="Number" Text='<%# Bind("Quantity") %>' min="0" OnTextChanged="quantityTextBox_TextChanged" onchange="onQuantityChange(this)">
                    </asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        </asp:GridView>
        
       
        
        
        
        
        
    </div>
    <div>   
        <h1>Subtotal: </h1>

        <h1 id="subtotal">0.0</h1>
    </div>
    <asp:Button ID="NextButton" runat="server" Text="Button" OnClick="NextButton_Click"/>
    <script>
        var total = 0.0;
        function onCheckBoxClick(index) {

            var grid = document.getElementById("<%=GridView1.ClientID%>");
            
            var checkbox = grid.rows[index + 1].cells[0].children[0];
            var price = grid.rows[index + 1].cells[3];
            var quantity = grid.rows[index + 1].cells[4].children[0];
            

            if(checkbox.checked) {
                quantity.value = 1;
                total += Number(price.innerHTML);
                quantity.readOnly = false;;
            } else {
                var oldQuantity = quantity.value;
                quantity.value = 0;
                quantity.readOnly = true;
                total -= Number(price.innerHTML) * oldQuantity;
            }
            document.getElementById("subtotal").innerHTML = String(total);
            
        }
        
        function onQuantityChange(quantity) {
            
        }
        
    </script>   
</asp:Content>
