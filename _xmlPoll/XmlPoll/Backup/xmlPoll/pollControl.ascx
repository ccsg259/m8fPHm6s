<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="pollControl.ascx.cs"
    Inherits="xmlPoll.pollControl" %>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <table>
            <tr>
                <td id="header">
                    POLL
                </td>
            </tr>
            <tr>
                <td id="head">
                    <asp:Label ID="lblHead" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButtonList ID="rbQ" runat="server" Width="95%">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td id="footer">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/App_Data/pollData.xml" TransformSource="~/App_Data/pollView.xsl"></asp:Xml>
    </asp:View>
</asp:MultiView>