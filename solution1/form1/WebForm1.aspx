<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="form1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
    Enter value 1:
    <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txt1" ErrorMessage="Enter Value"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="txt1" ErrorMessage="please Enter Digits" 
        ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
    <br>Enter value 2:
    <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txt2" ErrorMessage="Please enter Value"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txt2" ErrorMessage="Please Enter Digits only" 
        ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
    <br>
    <asp:Button ID="addbtn" runat="server" Text="Add" onclick="addbtn_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="subtbtn" runat="server" onclick="subtbtn_Click" 
        Text="Subtract" />
    <asp:Button ID="mulbtn" runat="server" Text="Multiply" onclick="mulbtn_Click" />
    <asp:Button ID="divbtn" runat="server" Text="DIvide" onclick="divbtn_Click" />
    <br />
    <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
    </form>
    </div>
    </form>
</body>
</html>
