using CodeProjectDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProjectDemo.Models
{
    public class FolderProxy : IFolder
    {        
        private List<IFolder> folders;
        private User user;

        public FolderProxy(User user)
        {
            this.user = user;
            this.folders = new List<IFolder>();
        }

        public void PerformOperations()
        {
           switch(this.user.Credential)
            {
                case Credentials.Guest:
                    this.folders.Add(new GuestFolder());                    
                    break;
                case Credentials.OrdinalUser:
                    this.folders.Add(new OrdinalFolder());
                    break;
                case Credentials.SpecialUser:
                    this.folders.Add(new GuestFolder());
                    this.folders.Add(new OrdinalFolder());
                    break;
                case Credentials.Administrator:
                    this.folders.Add(new GuestFolder());
                    this.folders.Add(new OrdinalFolder());
                    this.folders.Add(new UserFolder());
                    break;
                case Credentials.USANsa:
                    this.folders.Add(new GuestFolder());
                    this.folders.Add(new OrdinalFolder());
                    this.folders.Add(new UserFolder());
                    this.folders.Add(new ConfidentialFolder());
                    break;
            }

            foreach (var folder in folders)
            {
                folder.PerformOperations();
            }
        }
    }
}
