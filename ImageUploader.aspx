<%@ Page Title="Exercise 7" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImageUploader.aspx.cs" Inherits="L03DataBindingAndFiles.ImageUploader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!--Build an image uploader, that uploads images to a folder in our project -->

    <h2>Image Uploader</h2>
    <!--We need a DataList control, a FileUpload control, and a Button -->
    <asp:DataList ID="dlstImages" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">      
        <ItemTemplate>
            
            <!--Display the Image-->
            <asp:Image ID="Image1" runat="server" style="width:200px"
                ImageUrl='<%# Eval("Name","~/UploadedImages/{0}") %>'/><br />

            <!--Display File Name-->
            <%# Eval("Name") %><br />

            <!--Delete Link-->
            <a href='ImageUploader.aspx?fileToDelete=<%# Eval("Name") %>' style="color:red;">Delete</a>

        </ItemTemplate>
    </asp:DataList>  <!-- Its in Data section-->

    <asp:FileUpload ID="fileupload" runat="server" />
    <asp:Button ID="btnSave" runat="server" Text="Save/Upload" OnClick="btnSave_Click"/>
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>

</asp:Content>
