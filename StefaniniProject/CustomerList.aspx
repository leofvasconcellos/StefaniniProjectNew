<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="StefaniniProject.CustomerList" %>

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
                        <asp:Label ID="lblTitulo" runat="server" Font-Size="X-Large" Text=""></asp:Label>
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSair" runat="server" Text="Logout" OnClick="btnSair_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblNome" runat="server" Text="Name:"></asp:Label>
                                </td>
                                <td style="text-align: center">
                                    <asp:TextBox ID="txtNome" runat="server" Text=""></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlGender" runat="server" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Button ID="btnPesquisar" runat="server" Text="Search" OnClick="btnPesquisar_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblCidade" runat="server" Text="City:"></asp:Label>
                                </td>
                                <td style="text-align: center">
                                    <asp:DropDownList ID="ddlCidade" runat="server" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="lblRegiao" runat="server" Text="Region:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlRegion" runat="server" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Button ID="btnLimpar" runat="server" Text="Clear Fields" OnClientClick="btnLimpar_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblDataInicial" runat="server" Text="Last Purchase:"></asp:Label>
                                </td>
                                <td style="text-align: center">
                                    <asp:TextBox ID="txtDataInicial" runat="server" TextMode="DateTime"></asp:TextBox>
                                    <asp:ImageButton ID="imbCalendar" runat="server" Height="17px"
                                        ImageUrl="~/Images/calendar.png" OnClick="imbCalendar_Click" Width="21px" />
                                    <asp:Calendar ID="Calendar1" runat="server"
                                        OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                                </td>
                                <td>
                                    <asp:Label ID="lblDataFinal" runat="server" Text="until"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtDataFinal" runat="server" TextMode="DateTime"></asp:TextBox>
                                    <asp:ImageButton ID="imbCalendar2" runat="server" Height="17px"
                                        ImageUrl="~/Images/calendar.png" OnClick="imbCalendar2_Click" Width="21px" />
                                    <asp:Calendar ID="Calendar2" runat="server"
                                        OnSelectionChanged="Calendar2_SelectionChanged" Visible="False"></asp:Calendar>
                                </td>
                                <td>
                                    <asp:CompareValidator ID="CompareValidatorDataFinal" runat="server"
                                        ControlToCompare="txtDataInicial" ControlToValidate="txtDataFinal"
                                        ErrorMessage="Data Final não pode ser maior que a data inicial"
                                        Operator="LessThanEqual" Type="Date" ForeColor="Red"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="lblClassificacao" runat="server" Text="Classification:"></asp:Label>
                                </td>
                                <td style="text-align: center">
                                    <asp:DropDownList ID="ddlClassification" runat="server" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="lblSeller" runat="server" Text="Seller:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlSeller" runat="server" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
                                </td>
                                <td></td>
                            </tr>
                        </table>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:GridView ID="grdConsulta" Width="100%" AutoGenerateColumns="false" EmptyDataText="No data available." runat="server" EnableSortingAndPagingCallbacks="True">
                            <Columns>
                                <asp:BoundField DataField="classificacao" HeaderText="Classification" />
                                <asp:BoundField DataField="nome" HeaderText="Name" />
                                <asp:BoundField DataField="telefone" HeaderText="Phone" />
                                <asp:BoundField DataField="genero" HeaderText="Gender" />
                                <asp:BoundField DataField="cidade" HeaderText="City" />
                                <asp:BoundField DataField="regiao" HeaderText="Region" />
                                <asp:BoundField DataField="ultimaCompra" HeaderText="Last Purchase" />
                                <asp:BoundField DataField="vendedor" HeaderText="Seller" />
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
