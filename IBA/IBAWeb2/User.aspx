<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="IBAWeb2.User" MasterPageFile="~/IBA.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
  
    <div class="page-content">
        <div class="container-fluid">

            <div class="row">
                <div class="col-xl-12">
                    <asp:GridView ID="grdYear" runat="server" AutoGenerateColumns="false" Width="90%" 
                        OnRowDataBound="grdYear_RowDataBound" OnRowCommand="grdYear_RowCommand">
                        <HeaderStyle BackColor="LightBlue" Font-Bold="true" ForeColor="Black" />
                        <Columns>
                            <asp:BoundField DataField="Year" HeaderText="Year" />
                            <asp:TemplateField HeaderText="Submitted">
                                <ItemTemplate>
                                     <span runat="server" id="spanRemove" class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                                    <span runat="server" id="spanOk" class="glyphicon glyphicon-ok" aria-hidden="true"></span>

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
            

            <div class="row" style="margin-top:10px;">
                    Year: <asp:Label ID="lblYear" runat="server" Font-Bold="true" />

                </div>


            <div class="row">
                <asp:GridView ID="grdForms" runat="server" AutoGenerateColumns="false" Width="90%" Visible="false" 
                    OnRowDataBound="grdForm_RowDataBound" OnRowCommand="grdForm_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="Form">
                            <ItemTemplate>
                                <asp:Label id="lblForm" runat="server" />
                            </ItemTemplate>
                            </asp:TemplateField>

                              <asp:TemplateField HeaderText="">
                               <ItemTemplate>
                                <asp:LinkButton ID="btnView" Text="View" runat="server" CommandName="ViewForm" />
                                   </ItemTemplate>
                             </asp:TemplateField>

                         <asp:TemplateField HeaderText="">
                               <ItemTemplate>
                                <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="EditForm" />
                                   </ItemTemplate>
                            </asp:TemplateField>
                      

                    </Columns>

                </asp:GridView>


            </div>




        </div>
    </div>

</asp:Content>
