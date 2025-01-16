<%@ Page Title="Exercise 7" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImageUploader.aspx.cs" Inherits="L03DataBindingAndFiles.ImageUploader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <!--Build an image uploader,that uploads images to a folder in our project -->
    <h2>Image Uploader</h2>
    <!--We need a datalist control,a file uploadcontrol and a button -->
    <asp:DataList ID="dlstImages" runat="server" RepeatColumns="3" RepeatDirection="Horizontal"></asp:DataList>  <!-- Its in Data section-->

    <asp:FileUpload ID="fileupload" runat="server" />

    <asp:Button ID="btnSave" runat="server" Text="Save/Upload" OnClick="btnSave_Click"/>


</asp:Content>
