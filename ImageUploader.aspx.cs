using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO; //added to the project for use of file and path class

namespace L03DataBindingAndFiles
{
    public partial class ImageUploader : System.Web.UI.Page
    {
        protected void Page_Prerender(object sender, EventArgs e)
        {
            //handle the delete operation
            string fileName = Request.QueryString["fileToDelete"];
            if (!string.IsNullOrEmpty(fileName))
            {
                string filePath = MapPath($"~/UploadedImages/{fileName}");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath); //Delete the File
                    lblError.Text=$"{fileName}File Not Found";
                }
                else
                {
                    lblError.Text = "File Not Found";
                }
            }


            //1.calling prerender to ensure the datalist control exists

            //2.specify a location in our project
            DirectoryInfo dir = new DirectoryInfo(MapPath("~/UploadedImages/"));
            //3.set the data source for the datalist using location
            dlstImages.DataSource = dir.GetFiles();
            //4.bind (databind) the source to the object
            dlstImages.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private bool checkFileType(string fileName)
        {
            //capture the extension of the file being passed in,using Path Class
            string ext = Path.GetExtension(fileName);
            //switch or if-else same kaj kore
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }
        protected void btnSave_Click(object sender,EventArgs e)
        {
            //get the file path of the image
            //this is the file where we want our images stored to
            string filePath = "~/UploadedImages/" + fileupload.FileName;
            //check that if it is a valid extension
            if(checkFileType(filePath))
            {
                //if valid,call Save As against the file
                //MapPath:its a special helper method.it retrieves physical path that exists and applies it
                //to the relative path in the application
                fileupload.SaveAs(MapPath(filePath));
                lblError.Text = "File Uploaded Successfully";
            }
            else
            {
                //incompitable file type
                lblError.Text = "File Not Supported";

            }
        }
    }
}