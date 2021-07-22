<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AplicacionWeb.Index" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript">
        var onKeyUp = function (field) {
            var v = this.processValue(this.getRawValue()),
                field;
            
            if (this.startDateField) {
                field = Ext.getCmp(this.startDateField);
                field.setMaxValue();
                this.dateRangeMax = null;
            } else if (this.endDateField) {
                field = Ext.getCmp(this.endDateField);
                field.setMinValue();
                this.dateRangeMin = null;
            }

            field.validate();
        };
    </script>
</head>
<body runat="server">
    <form runat="server" id="idform">
        <ext:ResourceManager runat="server" />
        <ext:Viewport runat="server" Layout="border">
            <Items>
                <ext:GroupTabPanel ID="GroupTabPanel1" runat="server" Region="Center" TabWidth="130" ActiveGroupIndex="0">
                    <Groups>
                        <%-- Pestaña Estudiantes --%>
                        <ext:GroupTab runat="server" MainItem="1">
                            <Items>
                                <ext:Panel runat="server" TrackMouseOver="true" Title="Usuarios" Icon="TagBlue" TabTip="Usuarios" Padding="10">
                                    <Items>
                                        <ext:FormPanel ID="formPanelUsuarios" runat="server" Title="Panel Usuarios" Padding="5" MonitorValid="true">
                                            <Items>
                                                <ext:TextField 
                                                    runat="server" 
                                                    ID="idUsuarios" 
                                                    IsRemoteValidation="true" 
                                                    FieldLabel="ID" 
                                                    DataIndex="id" 
                                                    Hidden="false" 
                                                    Disabled="true" 
                                                    AllowBlank="false" 
                                                    Text="" 
                                                    AnchorHorizontal="50%" />
                                                <ext:TextField 
                                                    runat="server" 
                                                    ID="contrasenias"
                                                    IsRemoteValidation="true" 
                                                    MinLength="10" 
                                                    MaxLength="10" 
                                                    FieldLabel="Contraseña" 
                                                    DataIndex="contraseña" 
                                                    AllowBlank="false" 
                                                    AnchorHorizontal="50%"
                                                    IndicatorIcon="Add"
                                                    IndicatorText="Añadir"
                                                    MsgTarget="Side">
                                                </ext:TextField>
                                                <ext:TextField 
                                                    runat="server" 
                                                    ID="nombresCuentas" 
                                                    IsRemoteValidation="true" 
                                                    FieldLabel="Nombre Cuenta" 
                                                    DataIndex="nombrePersona" 
                                                    AllowBlank="false" 
                                                    AnchorHorizontal="50%"
                                                    IndicatorIcon="Add"
                                                    IndicatorText="Añadir"
                                                    MsgTarget="Side">
                                                </ext:TextField>
                                                <ext:TextField 
                                                    runat="server" 
                                                    ID="nombrePersonas" 
                                                    IsRemoteValidation="true" 
                                                    MinLength="10" 
                                                    MaxLength="10" 
                                                    FieldLabel="Nombre Persona" 
                                                    DataIndex="nombreCuenta" 
                                                    AllowBlank="false" 
                                                    AnchorHorizontal="50%"
                                                    IndicatorIcon="Add"
                                                    IndicatorText="Añadir"
                                                    MsgTarget="Side">
                                                </ext:TextField>
                                                
                                                

                                                <ext:Button runat="server" ID="botonGuardarUser" Text="Guardar" Icon="Disk">
                                                    <DirectEvents>
                                                        <Click OnEvent="InsertarUser" />
                                                    </DirectEvents>
                                                </ext:Button>

                                                <ext:Button runat="server" Text="Actualizar" Icon="Reload" >
                                                    <ToolTips>
                                                        <ext:ToolTip runat="server" Title="Para actualizar, primero seleccione una fila!" />
                                                    </ToolTips>
                                                    <DirectEvents>
                                                        <Click OnEvent="ActualizarUsuario" />
                                                    </DirectEvents>
                                                </ext:Button>

                                                <ext:Button runat="server" Text="Eliminar" Icon="Decline">
                                                    <DirectEvents>
                                                        <Click OnEvent="EliminarUsuario" />
                                                    </DirectEvents>
                                                </ext:Button>
                                                <ext:Button runat="server" Text="Limpiar los Campos" Icon="Erase">
                                                    <DirectEvents>
                                                        <Click OnEvent="LimpiarCampos" />
                                                    </DirectEvents>
                                                </ext:Button>
                                            </Items>
                                        </ext:FormPanel>

                                    </Items>

                                    <Items>
                                        <ext:GridPanel runat="server" ID="gridPanelUsuarios" Height="500" StripeRows="true" Title="Lista Usuarios" TrackMouseOver="true">
                                            <Store>
                                                <ext:Store runat="server" ID="store_Usuarios">
                                                    <Reader>
                                                        <ext:JsonReader>
                                                            <Fields>
                                                                <ext:RecordField Name="id" />
                                                                <ext:RecordField Name="contraseña" />
                                                                <ext:RecordField Name="nombreCuenta" />
                                                                <ext:RecordField Name="nombrePersona" />
                                                            </Fields>
                                                        </ext:JsonReader>
                                                    </Reader>
                                                </ext:Store>
                                            </Store>
                                            <LoadMask ShowMask="true" />
                                            <ColumnModel runat="server">
                                                <Columns>
                                                    <ext:RowNumbererColumn />
                                                    <ext:Column ColumnID="id" Header="ID" Width="80" DataIndex="id" />
                                                    <ext:Column ColumnID="contasenia" Header="Contraseña" Width="150" DataIndex="contraseña" />
                                                    <ext:Column ColumnID="nombreCuenta" Header="Nombre Cuenta" Width="150" DataIndex="nombreCuenta" />
                                                    <ext:Column ColumnID="NombrePersona" Header="Nombre Persona" Width="150" DataIndex="nombrePersona" />
                                                </Columns>
                                            </ColumnModel>
                                            <SelectionModel>
                                                <ext:RowSelectionModel ID="seleccionFilaEstudiantes" runat="server" SingleSelect="true">
                                                    <Listeners>
                                                        <RowSelect Handler="#{formPanelUsuarios}.getForm().loadRecord(record);" />
                                                    </Listeners>
                                                </ext:RowSelectionModel>
                                            </SelectionModel>
                                        </ext:GridPanel>
                                    </Items>
                                </ext:Panel>
                                <ext:Panel runat="server" Title="Usuarios" Icon="TagBlue" TabTip="Recursos Humanos" Padding="10">
                                    <Items>
                                        <ext:Label runat="server" Text="Aquí podras ingresar nuevos usuarios." Region="Center"></ext:Label>
                                    </Items>
                                </ext:Panel>
                            </Items>
                        </ext:GroupTab>
                    </Groups>
                </ext:GroupTabPanel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
