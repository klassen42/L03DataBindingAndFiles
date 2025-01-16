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


            }

        }
    }
}