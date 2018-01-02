<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StefaniniProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblTitulo" runat="server" Font-Size="X-Large" Text="Login Page"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblEmail" runat="server" Font-Size="X-Large" Text="E-Mail :"></asp:Label>
                                </td>
                                <td style="text-align: center">
                                    <asp:TextBox ID="txtEmail" runat="server" Font-Size="X-Large" TextMode="Email"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="E-Mail is required!" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblSenha" runat="server" Font-Size="X-Large" Text="Password :"></asp:Label>
                                </td>
                                <td style="text-align: center">
                                    <asp:TextBox ID="TxtSenha" runat="server" Font-Size="X-Large" TextMode="Password"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="rfvSenha" runat="server" ErrorMessage="Senha is required!" ControlToValidate="TxtSenha"></asp:RequiredFieldValidator>
                                </td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align: center">
                                    <asp:Button ID="btnLogin" runat="server" BorderStyle="None" Font-Size="X-Large" Text="Login" OnClick="btnLogin_Click" />
                                </td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="text-align: center">
                                    <asp:Label ID="lblMensagem" runat="server" Font-Size="Large" ForeColor="Red"></asp:Label>
                                </td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
