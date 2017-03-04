<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="IBAWeb2.User" MasterPageFile="~/IBA.Master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-content">
        <div class="container-fluid">

            <div class="row">
                <div class="col-xl-12">
                    <asp:GridView ID="grdYear" runat="server" AutoGenerateColumns="false" Width="90%" OnRowDataBound="grdYear_RowDataBound">
                        <HeaderStyle BackColor="LightBlue" Font-Bold="true" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="Year" HeaderText="Year" />
                            <asp:TemplateField HeaderText="Submitted">
                                <ItemTemplate>
                                     <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>

                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Submitted" HeaderText="Submitted" />
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnEditYear" runat="server" Text="Edit"
                                        CommandName="EditYear" CommandArgument='<%#Eval("Year") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                    </asp:GridView>
                </div>
                <!--.col-->
            </div>
            <!--.row-->
        </div>
    </div>

</asp:Content>
