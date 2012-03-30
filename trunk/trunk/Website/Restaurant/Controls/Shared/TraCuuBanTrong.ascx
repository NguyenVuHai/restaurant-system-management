<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TraCuuBanTrong.ascx.cs" Inherits="Controls.Shared.TraCuuBanTrong" %>
<div id="filter">
</div>
<div id="listTable">
    <asp:ListView ID="lvTables" runat="server" ItemPlaceholderID="TableItem">
        <LayoutTemplate>
            <table cellpadding="0" cellspacing="0" border="1" class="display" width="100%" id="data_table" style="border-collapse: collapse;">
                <thead>
                    <tr>
                        <th width="112px">
                            <div class="th_wrapp">
                                Mã Khu Vực</div>
                        </th>
                        <th>
                            <div class="th_wrapp">
                                Mã bàn</div>
                        </th>
                        <th>
                            <div class="th_wrapp">
                                Tên bàn</div>
                        </th>
                        <th>
                            <div class="th_wrapp">
                                Sức chứa</div>
                        </th>
                    </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder runat="server" ID="TableItem"></asp:PlaceHolder>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr class='<%#(Container.DataItemIndex % 2 == 0) ? "odd" : "even" %>'>
                    <td align="center">
                        <asp:Literal ID="ltrMaKhuVuc" runat="server" Text='<%# Eval("MaKhuVuc") %>'></asp:Literal>
                    </td>
                    <td align="center">
                        <asp:Literal ID="ltrMaBan" runat="server" Text='<%# Eval("MaBan") %>'></asp:Literal>
                    </td>
                   <td align="center">
                        <asp:Literal ID="ltrTenBan" runat="server" Text='<%# Eval("TenBan") %>'></asp:Literal>
                    </td>
                    <td align="center">
                        <asp:Literal runat="server" ID="ltrSucChua" Text='<%# Eval("SucChua") %>'></asp:Literal>
                    </td>
                </tr>
        </ItemTemplate>
    </asp:ListView>
</div>
