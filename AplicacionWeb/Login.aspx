<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AplicacionWeb.Login" %>

<%@ Import Namespace="Ext.Net.Utilities" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script type="text/javascript">
        Ext.getCmp('Window1').center();
    </script>
</head>
<body>
    <style type="text/css">
        body {
            align-content: center;
            align-self: center;
            align-items: center;
            vertical-align: central;
        }
    </style>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        <div>      
        <ext:Window 
            ID="Window1" 
            runat="server" 
            Closable="false"
            Resizable="false"
            Height="150" 
            Icon="Lock" 
            Title="Login"            
            Width="350"
            Modal="true"
            Padding="5"  
            Layout="Form">
            <Items>
                <ext:TextField 
                    ID="UserName" 
                    runat="server" 
                    FieldLabel="Usuario" 
                    AllowBlank="false"
                    BlankText="Tu nombre es requerido."
                    AnchorHorizontal="100%"
                    />
                <ext:TextField 
                    ID="Password" 
                    runat="server" 
                    InputType="Password" 
                    FieldLabel="Contraseña" 
                    AllowBlank="false" 
                    BlankText="Tu contraseña es requerida."
                    AnchorHorizontal="100%"
                    />
            </Items>
            <Buttons>
                <ext:Button ID="btnLogin" runat="server" Text="Ingresar" Icon="Accept">                    
                    <Listeners>
                        <Click Handler="
                            if (!#{UserName}.validate() || !#{Password}.validate()) {
                                Ext.Msg.alert('Error','TODOS LOS CAMPOS SON OBLIGATORIOS. <br> INGRESE SUS DATOS Y VUELVA A CONTINUAR ');                                
                                return false; 
                            }" />
                    </Listeners>
                    <DirectEvents>
                        <Click OnEvent="btnLogin_Click"
                            Failure="Ext.Msg.show({ 
                            title   : 'Error', 
                            msg     : 'Error al ingresar. \t Vuelva a intentar o intente más tarde. ',
                            minWidth: 200, 
                            modal   : true, 
                            icon    : Ext.Msg.ERROR, 
                            buttons : Ext.Msg.OK 
                            });">
                            <EventMask ShowMask="true" Msg="¨Verificando..."  MinDelay="500" />
                        </Click>
                    </DirectEvents>
                </ext:Button>
            </Buttons>
        </ext:Window>
    </div>
    <ext:KeyMap ID="KeyMapPanel1" runat="server" Target="#{Window1}">
        <ext:KeyBinding StopEvent="true">
            <Keys>
                <ext:Key Code="ENTER" />
            </Keys>
            <Listeners>
                <Event Handler="#{btnLogin}.fireEvent('click')" />
            </Listeners>
        </ext:KeyBinding>
    </ext:KeyMap>
    </form>
</body>
</html>
