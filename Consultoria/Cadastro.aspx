<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cadastro.aspx.cs" Inherits="Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="app_code/design/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-fluid">

                <div class="jumbotron">

                    <asp:Label ID="lblcpf" runat="server" Text="CPF"></asp:Label>
                    <asp:TextBox ID="tbxcpf" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblNome" runat="server" Text="Nome do usuario"></asp:Label>
                    <asp:TextBox ID="txbNome" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblemail" runat="server" Text="email"></asp:Label>
                    <asp:TextBox ID="txbemail" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblbairro" runat="server" Text="bairro"></asp:Label>
                    <asp:TextBox ID="tbxbairro" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblcidade" runat="server" Text="cidade"></asp:Label>
                    <asp:TextBox ID="txbcidade" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblestado" runat="server" Text="estado"></asp:Label>
                    <asp:DropDownList id="ddlestado" runat="server">
                        <asp:ListItem Value="SP">SP</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />

                    <asp:Label ID="lblrua" runat="server" Text="rua"></asp:Label>
                    <asp:TextBox ID="tbxbrua" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblnumeroc" runat="server" Text="numero da casa"></asp:Label>
                    <asp:TextBox ID="tbxnumeroc" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lbltel" runat="server" Text="telefone"></asp:Label>
                    <asp:TextBox ID="tbxtel" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblcel" runat="server" Text="celular"></asp:Label>
                    <asp:TextBox ID="tbxcel" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblsenha" runat="server" Text="senha"></asp:Label>
                    <asp:TextBox ID="tbxsenha" runat="server"></asp:TextBox>
                    <br />
                    <br />

                    <asp:Label ID="lblconfirma" runat="server" Text="confirma senha "></asp:Label>
                    <asp:TextBox ID="tbxconfirma" runat="server"></asp:TextBox>

                    <br />
                    <br />
                    <asp:button ID="btCadastrar" runat="server" Text="Cadastrar" OnClick="btCadastrar_Click" />

                </div>


            </div>



        </div>
    </form>
</body>
</html>
